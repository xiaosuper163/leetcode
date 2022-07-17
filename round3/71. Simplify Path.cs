public class Solution {
    public string SimplifyPath(string path) {
        IList<string> lst = new List<string>();
        
        for (int i = 0; i < path.Length; i ++) {
            if (path[i] == '/') {
                continue;
            } else {
                int j = i + 1;
                while (j < path.Length && path[j] != '/') {
                    j ++;
                }
                
                string dirName = path.Substring(i, j - i);
                if (dirName == "..") {
                    if(lst.Count > 0) lst.RemoveAt(lst.Count - 1);
                } else if (dirName == ".") {
                    
                } else  {
                    lst.Add(dirName);
                }
                
                i = j - 1;
            }
        }
        
        return "/" + string.Join('/', lst);
    }
}