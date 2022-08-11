public class TrieNode {
    public TrieNode[] children;
    public bool isEnd;
    public TrieNode() {
        children = new TrieNode[26];
        isEnd = false;
    }
}

public class WordDictionary {
    private TrieNode root;
    
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode curr = root;
        for (int i = 0; i < word.Length; i ++) {
            char c = word[i];
            if (curr.children[c - 'a'] == null)
                curr.children[c - 'a'] = new TrieNode();
            curr = curr.children[c - 'a'];
        }
        curr.isEnd = true;
    }
    
    private bool DFSHelper(string word, int index, TrieNode curr) {
        if (index == word.Length && curr.isEnd) return true;
        if (index == word.Length) return false;
        
        char c = word[index];
        if (c != '.') {
            if (curr.children[c - 'a'] == null) return false;
            if (DFSHelper(word, index + 1, curr.children[c - 'a'])) return true;
        } else {
            for (int i = 0; i < 26; i ++) {
                if (curr.children[i] != null) {
                    if (DFSHelper(word, index + 1, curr.children[i])) return true;
                }
            }
        }
        return false;
    }
    
    public bool Search(string word) {
        return DFSHelper(word, 0, root);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */