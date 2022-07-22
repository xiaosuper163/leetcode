public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        var res = new List<string>();
        DFSHelper(s, 0, "", 0, res);
        return res;
    }
    
    private void DFSHelper(string s, int index, string currStr, int size, IList<string> res) {
        if (index >= s.Length && size == 4) {
            res.Add(currStr);
            return;
        }
        
        if (index >= s.Length) return;        
        if (size >= 4 && index < s.Length) return;
        
        if (index != 0) 
            currStr += ".";
        
        //Console.WriteLine($"len1 - index:{index}, s.Length:{s.Length}, size: {size}");
        DFSHelper(s, index + 1, currStr + s.Substring(index, 1), size + 1, res);
        
        if (index + 1 < s.Length && s[index] != '0') {
            DFSHelper(s, index + 2, currStr + s.Substring(index, 2), size + 1, res);
        }
        if (index + 2 < s.Length && s[index] != '0' && Int32.Parse(s.Substring(index, 3)) < 256) {
            DFSHelper(s, index + 3, currStr + s.Substring(index, 3), size + 1, res);
        }
    }
}