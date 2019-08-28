public class TreeNode {
    public TreeNode[] children;
    public bool IsWord {get; set;}
    public TreeNode() {
        children = new TreeNode[26];
        IsWord = false;
    }
}

public class WordDictionary {
    private TreeNode root;

    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TreeNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        TreeNode cursor = root;
        for (int i=0; i<word.Length; i++) {
            int index = word[i]-'a';
            if (cursor.children[index] == null) cursor.children[index] = new TreeNode();
            cursor = cursor.children[index];
        }
        cursor.IsWord = true;
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        return dfs(word, 0, root);
    }
    
    private bool dfs(string word, int i, TreeNode r) {
        if (i == word.Length) return r.IsWord;
        if (word[i] == '.') {
            foreach (TreeNode child in r.children) {
                if (child != null && dfs(word, i+1, child)) {
                    return true;
                }
            }
        } else {
            int index = word[i] - 'a';
            if (r != null && r.children[index] != null && dfs(word, i+1, r.children[index])) {
                return true;
            }
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */