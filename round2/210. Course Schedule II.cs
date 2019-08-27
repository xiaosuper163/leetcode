public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        int[] inDegree = new int[numCourses];
        var edges = new Dictionary<int, List<int>>();
        foreach (var prerequisite in prerequisites) {
            if (edges.ContainsKey(prerequisite[1])) {
                edges[prerequisite[1]].Add(prerequisite[0]);
                inDegree[prerequisite[0]]++;
            } else {
                edges[prerequisite[1]] = new List<int>(){prerequisite[0]};
                inDegree[prerequisite[0]]++;
            }
        }
        
        var queue = new Queue<int>();
        for (int i=0; i<numCourses; i++) {
            if (inDegree[i] == 0) queue.Enqueue(i);
        }
        
        int[] res = new int[numCourses];
        int index = 0;
        while (queue.Count != 0) {
            int src = queue.Dequeue();
            res[index++] = src;
            if (edges.ContainsKey(src)) {
                foreach (int dest in edges[src]) {
                    inDegree[dest]--;
                    if (inDegree[dest] == 0) queue.Enqueue(dest);
                }
            }
        }
        if (index < numCourses) return new int[0];
        return res;
    }
}