public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var graph = new Dictionary<int, IList<int>>();
        var inDegree = new int[numCourses];
        var queue = new Queue<int>();
        
        foreach (int[] prerequisite in prerequisites) {
            
            if (!graph.ContainsKey(prerequisite[0])) {
                graph[prerequisite[0]] = new List<int>() {prerequisite[1]};
            } else {
                graph[prerequisite[0]].Add(prerequisite[1]);
            }
            inDegree[prerequisite[1]] ++;
        }
        
        for (int i = 0; i < numCourses; i ++) {
            if (inDegree[i] == 0) queue.Enqueue(i);
        }
                
        while (queue.Count != 0) {
            int curr = queue.Dequeue();
            
            if (graph.ContainsKey(curr)) {
                foreach (int target in graph[curr]) {
                    inDegree[target] --;
                    if (inDegree[target] == 0) {
                        queue.Enqueue(target);
                    }               
                }
            }            
        }
        
        for (int i = 0; i < numCourses; i ++) {
            if (inDegree[i] != 0) return false;
        }
        
        return true;
    }
}