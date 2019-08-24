public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var graph = new Dictionary<int, List<int>>();
        int[] inDegree = new int[numCourses];
        for (int i=0; i<prerequisites.Length; i++) {
            if (graph.ContainsKey(prerequisites[i][1])) {
                graph[prerequisites[i][1]].Add(prerequisites[i][0]);
                inDegree[prerequisites[i][0]]++;
            }                
            else {
                graph[prerequisites[i][1]] = new List<int>(){prerequisites[i][0]};  
                inDegree[prerequisites[i][0]]++;
            } 
        }
        Queue<int> q = new Queue<int>();
        for (int i=0; i<numCourses; i++) {
            if (inDegree[i] == 0) q.Enqueue(i);
            //Console.WriteLine(inDegree[i]);
            //Console.WriteLine(graph[i][0]);
        }
        while (q.Count != 0) {
            int src = q.Dequeue();
            if (graph.ContainsKey(src)) {
                foreach (var dest in graph[src]) {
                    inDegree[dest]--;
                    if (inDegree[dest] == 0) q.Enqueue(dest);
                }
            }
        }
        for (int i=0; i<numCourses; i++) {
            if (inDegree[i] != 0) return false;
        }
        return true;
    }
}