import pandas as pd
import numpy as np
from pandas.api.types import is_numeric_dtype
import xgboost as xgb
import matplotlib
import matplotlib.pyplot as plt
import pickle
from sklearn import preprocessing
from sklearn.metrics import roc_curve
from scipy.stats import zscore
from sklearn.metrics import confusion_matrix, classification_report,\
                            precision_recall_curve, average_precision_score,\
                            auc, roc_curve, roc_auc_score
from sklearn.ensemble import RandomForestClassifier
# import tensorflow as tf

def save_obj(obj, name ):
    with open('obj/'+ name + '.pkl', 'wb') as f:
        pickle.dump(obj, f, pickle.HIGHEST_PROTOCOL)

def load_obj(name ):
    with open('obj/' + name + '.pkl', 'rb') as f:
        return pickle.load(f)
    
def display_all(df):
    with pd.option_context("display.max_rows", 1000):
        with pd.option_context("display.max_columns", 1000):
            display(df)

def process_dates(df,date):
    attrs = ['Day', 'Dayofweek', 'Is_month_end', 'Is_month_start']
    for attr in attrs:
        df[attr] = getattr(df[date].dt, attr.lower())
    return df

def my_roc(y_true, y_prob):
    if isinstance(y_true,pd.core.series.Series):
        y_true = np.array(y_true.tolist())
    if isinstance(y_true,list):
        y_true = np.array(y_true)
    sort_index = np.argsort(y_prob)[::-1]
    y_prob = y_prob[sort_index]
    y_true = y_true[sort_index]
    num_p = y_true.sum()
    num_n = len(y_true) - num_p
    fp = 0
    tp = 0
    fps = []
    tps = []
    prob_prev = -99
    i = 0
    while i < len(y_true):
        if y_prob[i]!=prob_prev:
            fps.append(fp/num_n)
            tps.append(tp/num_p)
            prob_prev=y_prob[i]
        if y_true[i]==1:
            tp+=1
        else:
            fp+=1
        i+=1
    fps.append(fp/num_n)
    tps.append(tp/num_p)
    return np.array(fps), np.array(tps)

# Adapted from SKlearn, conservative (actual should be higher)
def my_score1(ground_truth, predictions):
    fpr,tpr,threhold = roc_curve(ground_truth, predictions) 
    tpr1 = tpr[(fpr>=0.001).argmax()-1]
    tpr2 = tpr[(fpr>=0.005).argmax()-1] 
    tpr3 = tpr[(fpr>=0.01).argmax()-1]
    return 0.4 * tpr1 + 0.3 * tpr2 + 0.3* tpr3

# suitable for lightGBM
def my_score2(predictions, xtrain): 
    ground_truth = xtrain.get_label()
    fpr,tpr = my_roc(ground_truth, predictions)
    tpr1 = tpr[(fpr>=0.001).argmax()-1]
    tpr2 = tpr[(fpr>=0.005).argmax()-1] 
    tpr3 = tpr[(fpr>=0.01).argmax()-1]
    return 'score', 0.4 * tpr1 + 0.3 * tpr2 + 0.3* tpr3, True

# suitable for xgboost    
def my_score3(predictions, xtrain): #
    ground_truth = xtrain.get_label()
    fpr,tpr = my_roc(ground_truth, predictions)
    tpr1 = tpr[(fpr>=0.001).argmax()-1]
    tpr2 = tpr[(fpr>=0.005).argmax()-1] 
    tpr3 = tpr[(fpr>=0.01).argmax()-1]
    return 'score', 0.4 * tpr1 + 0.3 * tpr2 + 0.3* tpr3

def norm_standardize(df, start=0):
    for col in df.columns[start:]:
        a = df[col]
        z = a
        z[~np.isnan(a)] = zscore(a[~np.isnan(a)])
        df[col] = z
            
def norm_maxmin(df, start=0):
    for col in df.columns[start:]:
        df[col]=(df[col]-df[col].min())/(df[col].max()-df[col].min())
        
def train_cats(df_raw):
    for n, c in df.items():
        if is_string_dtype(c):
            df[n] = c.astype('category').cat.as_ordered()
            
def apply_cats(df, trn):
    for n,c in df.items():
        if trn[n].dtype.name=='category':
            df[n] = pd.Categorical(c, categories=trn[n].cat.categories, ordered=True)
            
def print_score(m):
    res = {"train_auc": roc_auc_score(y_train, m.predict_proba(X_train)[:,1]),\
           "test_auc": roc_auc_score(y_test, m.predict_proba(X_test)[:,1]),\
           "train_score": m.score(X_train, y_train),\
           "test_score": m.score(X_test, y_test)}
    if hasattr(m, 'oob_score_'):
        res['oob_score'] = m.oob_score_
    print(res)
    
def plot_confusion_matrix(cm, classes,
                          normalize=False,
                          title='Confusion matrix',
                          cmap=plt.cm.Blues):
    """
    This function prints and plots the confusion matrix.
    Normalization can be applied by setting `normalize=True`.
    """
    if normalize:
        cm = cm.astype('float') / cm.sum(axis=1)[:, np.newaxis]
        # print("Normalized confusion matrix")
    # else:
        # print('Confusion matrix, without normalization')

    # print(cm)
    
    figsize=(16,8)
    plt.imshow(cm, interpolation='nearest', cmap=cmap)
    plt.title(title)
    plt.colorbar()
    tick_marks = np.arange(len(classes))
    plt.xticks(tick_marks, classes, rotation=45)
    plt.yticks(tick_marks, classes)

    fmt = '.2f' if normalize else 'd'
    thresh = cm.max() / 2.
    for i, j in itertools.product(range(cm.shape[0]), range(cm.shape[1])):
        plt.text(j, i, format(cm[i, j], fmt),
                 horizontalalignment="center",
                 color="white" if cm[i, j] > thresh else "black")

    plt.tight_layout()
    plt.ylabel('True label')
    plt.xlabel('Predicted label')

def plotPRC1(y_true, y_pred):
    precision, recall, thresholds = precision_recall_curve(y_true, y_pred)
    average_precision = average_precision_score(y_true, y_pred)
    plt.step(recall, precision, color='b', alpha=0.2,
             where='post')
    plt.fill_between(recall, precision, step='post', alpha=0.2,
                     color='b')
    plt.xlabel('Recall')
    plt.ylabel('Precision')
    plt.ylim([0.0, 1.0])
    plt.xlim([0.0, 1.0])
    ax2 = plt.gca().twinx()
    plt.step(recall[1:], thresholds, color='red', alpha=0.2,
             where='post')
    plt.plot([0,1], [0,1], color="darkorange", linestyle="--")
    plt.ylabel('Threshold')
    plt.ylim([0.0, 1.0])
    plt.xlim([0.0, 1.0])
    plt.title('2-class Precision-Recall curve: AP={0:0.2f}'.format(
              average_precision))
    
def plotPRC2(truth, proba):
    precision, recall, thrd = precision_recall_curve(truth, proba)
    ap = average_precision_score(truth, proba)
    plt.figure(figsize=(16,8))
    plt.plot(recall, precision, color="darkorange", label=f"Precision Recall Curve AP: {ap}")
    plt.plot([0,1], [0,1], color="navy", linestyle="--")
    plt.xlabel("Recall")
    plt.ylabel("Precision")
    plt.legend(loc="upper right")
    
def plotROC(y_test, y_pred):
    fpr,tpr,threhold = roc_curve(y_test, y_pred)
    plt.scatter(fpr, tpr)
    plt.xlabel('False Positive Rate')
    plt.ylabel('True Positive Rate')
    plt.title('ROC curve')
    plt.show()

def myNormalize(df, cols):
    for col in cols:
        df[col] = (df[col] - df[col].mean())/df[col].std()

def plotFI(m, cols, max_num_features=None, importance_type='split'):
    '''
    m: XGBClassifier;
    cols: python list or numpy array, a list of feature names;
    max_num_features: int, the number of features shown in the graph;
    importance_type: str, 'split' or 'gain'
    '''
    print('Plot feature importances...')
    tuples = sorted(zip(cols, m.booster_.feature_importance(importance_type=importance_type)), key=lambda x: x[1])
    if max_num_features is not None and max_num_features > 0:
        tuples = tuples[-max_num_features:]
    labels, values = zip(*tuples)   
    ylocs = np.arange(len(values))
    _, ax = plt.subplots(1, 1, figsize=(12,8))
    ax.barh(ylocs, values, align='center', height=0.2)
    for x, y in zip(values, ylocs):
        ax.text(x + 1, y, x, va='center')
    ax.set_yticks(ylocs)
    ax.set_yticklabels(labels)
    ax.set_title('Feature importance')
    return ax