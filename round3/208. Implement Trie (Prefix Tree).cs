public class TrieNode {
    public bool isEnd;
    public TrieNode[] children;
    
    public TrieNode() {
        isEnd = false;
        children = new TrieNode[26];
    }
}

public class Trie {
    
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode cursor = root;
        for (int i = 0; i < word.Length; i ++) {
            char c = word[i];
            if (cursor.children[c - 'a'] == null) {
                cursor.children[c - 'a'] = new TrieNode();
            }
            cursor = cursor.children[c - 'a'];
        }
        cursor.isEnd = true;
    }
    
    public bool Search(string word) {
        TrieNode cursor = root;
        for (int i = 0; i < word.Length; i ++) {
            char c = word[i];
            if (cursor.children[c - 'a'] == null) return false;
            cursor = cursor.children[c - 'a'];
        }
        if (cursor.isEnd) return true;
        return false;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode cursor = root;
        for (int i = 0; i < prefix.Length; i ++) {
            char c = prefix[i];
            if (cursor.children[c - 'a'] == null) return false;
            cursor = cursor.children[c - 'a'];
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