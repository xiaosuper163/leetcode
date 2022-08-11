public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        var res = new List<string>();
        
        Trie t = new Trie();
        
        foreach(string word in words) {
            t.Insert(word);
        }
        
        int m = board.Length, n = board[0].Length;
        
        bool[][] visited = new bool[m][];
        for (int i = 0; i < m; i ++) {
            visited[i] = new bool[n];
        }
        
        for (int i = 0; i < m; i ++) {
            for (int j = 0; j < n; j ++) {
                DFSHelper(board, i, j, t.root, res, visited);
            }
        }
        
        return res;
    }
    
    private void DFSHelper(char[][] board, int i, int j, TrieNode curr, IList<string> res, bool[][] visited) {
        if (curr.str != null) {
            res.Add(curr.str);
            curr.str = null; // this is to avoid duplicates in the result
        }
        
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || curr.children[board[i][j] - 'a'] == null || visited[i][j]) return;
        TrieNode next = curr.children[board[i][j] - 'a'];
        
        visited[i][j] = true;
        DFSHelper(board, i+1, j, next, res, visited);
        DFSHelper(board, i-1, j, next, res, visited);
        DFSHelper(board, i, j+1, next, res, visited);
        DFSHelper(board, i, j-1, next, res, visited);
        visited[i][j] = false;
    }
}

public class TrieNode {
    public TrieNode[] children;
    public string str;
    public TrieNode() {
        children = new TrieNode[26];
    }
}

public class Trie {
    public TrieNode root;
    
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        for (int i = 0; i < word.Length; i ++) {
            char c = word[i];
            if (curr.children[c - 'a'] == null) {
                curr.children[c - 'a'] = new TrieNode();
            }
            curr = curr.children[c - 'a'];
        }
        curr.str = word;
    }
}