public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> st = new Stack<string>();
        string[] tokenArray = path.Split('/');
        foreach(string curr in tokenArray) {
            if (!(st.Count==0) && curr.Equals("..")) {
                st.Pop();
            } else if (!curr.Equals(".") && !curr.Equals("") && !curr.Equals("..")) {
                st.Push(curr);
            }
        }
        return "/"+string.Join("/", st.ToArray().Reverse());
    }
}