public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var graph = new Dictionary<int, IList<int>>();
        var inDegree = new int[numCourses];
        foreach (var prerequisite in prerequisites) {
            int src = prerequisite[1];
            inDegree[prerequisite[0]] ++;
            if (graph.ContainsKey(src)) {
                graph[src].Add(prerequisite[0]);
            } else {
                graph[src] = new List<int>() {prerequisite[0]};
            }
        }
        
        var queue = new Queue<int>();
        for (int i = 0; i < numCourses; i ++) {
            if (inDegree[i] == 0) queue.Enqueue(i);
        }
        
        var res = new int[numCourses];
        int idx = 0;
        while (queue.Count != 0) {
            int curr = queue.Dequeue();
            res[idx++] = curr;
            if (graph.ContainsKey(curr)) {
                foreach (int dest in graph[curr]) {
                    inDegree[dest] --;
                    if (inDegree[dest] == 0) queue.Enqueue(dest);
                }
            }
        }
        
        if (idx != numCourses) return new int[0];
        
        return res;
    }
}