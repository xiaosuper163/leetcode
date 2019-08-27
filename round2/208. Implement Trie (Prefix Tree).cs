public class TreeNode {
    public bool IsWord {get; set;}
    public TreeNode[] children;
    public TreeNode() {
        IsWord = false;
        children = new TreeNode[26];
    }
}
public class Trie {
    private TreeNode root;

    /** Initialize your data structure here. */
    public Trie() {
        root = new TreeNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TreeNode cursor = root;
        for(int i=0; i<word.Length; i++) {
            char curr = word[i];
            if (cursor.children[curr-'a'] == null) {
                cursor.children[curr-'a'] = new TreeNode();
            }
            cursor = cursor.children[curr-'a'];
        }
        cursor.IsWord = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        TreeNode cursor = root;
        for(int i=0; i<word.Length; i++) {
            char curr = word[i];
            if (cursor.children[curr-'a'] == null) {
                return false;
            }
            cursor = cursor.children[curr-'a'];
        }
        if (cursor.IsWord) {
            return true;
        } else {
            return false;
        }
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TreeNode cursor = root;
        for(int i=0; i<prefix.Length; i++) {
            char curr = prefix[i];
            if (cursor.children[curr-'a'] == null) {
                return false;
            }
            cursor = cursor.children[curr-'a'];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */