class Solution {
    public List<List<Integer>> getSkyline(int[][] buildings) {
        List<int[]> heights = new ArrayList<>();
        for (int[] b: buildings) {
            heights.add(new int[]{b[0], - b[2]});
            heights.add(new int[]{b[1], b[2]});
        }
        Collections.sort(heights, (a, b) -> (a[0] == b[0]) ? a[1] - b[1] : a[0] - b[0]);
        TreeMap<Integer, Integer> heightMap = new TreeMap<>(Collections.reverseOrder());
        heightMap.put(0,1);
        int prevHeight = 0;
        List<List<Integer>> skyLine = new LinkedList<>();
        for (int[] h: heights) {
            if (h[1] < 0) {
                Integer cnt = heightMap.get(-h[1]);
                cnt = ( cnt == null ) ? 1 : cnt + 1;
                heightMap.put(-h[1], cnt);
            } else {
                Integer cnt = heightMap.get(h[1]);
                if (cnt == 1) {
                    heightMap.remove(h[1]);
                } else {
                    heightMap.put(h[1], cnt - 1);
                }
            }
            int currHeight = heightMap.firstKey();
            if (prevHeight != currHeight) {
                skyLine.add(new ArrayList<Integer>(){{add(h[0]); add(currHeight);}});
                prevHeight = currHeight;
            }
        }
        return skyLine;
    }
}


// public class Solution {
//     public IList<IList<int>> GetSkyline(int[][] buildings) {
//         List<Tuple<int, int>> h = new List<Tuple<int, int>>();
//         var res = new List<IList<int>>();
//         foreach (var building in buildings) {
//             h.Add(new Tuple<int, int>(building[0], -building[2]));
//             h.Add(new Tuple<int, int>(building[1], building[2]));
//         }
//         var m = new SortedMultiSet<int>();
//         m.Add(0);
//         h.Sort();
//         int pre = 0, curr = 0;
//         foreach (var a in h) {
//             if (a.Item2 < 0) m.Add(-a.Item2);
//             else m.Remove(a.Item2);
//             curr = m.Peek();
//             if (curr != pre) {
//                 res.Add(new List<int>(){a.Item1, curr});
//                 pre = curr;
//             }
//         }
//         return res;
//     }
// }
// public class SortedMultiSet<T> : IEnumerable<T>
// {
//     private SortedDictionary<T, int> _dict; 

//     public SortedMultiSet()
//     {
//         _dict = new SortedDictionary<T, int>();
//     }

//     public SortedMultiSet(IEnumerable<T> items) : this()
//     {
//         Add(items);
//     }

//     public bool Contains(T item)
//     {
//         return _dict.ContainsKey(item);
//     }

//     public void Add(T item)
//     {
//         if (_dict.ContainsKey(item))
//             _dict[item]++;
//         else
//             _dict[item] = 1;
//     }

//     public void Add(IEnumerable<T> items)
//     {
//         foreach (var item in items)
//             Add(item);
//     }

//     public void Remove(T item)
//     {
//         if (!_dict.ContainsKey(item))
//             throw new ArgumentException();
//         if (--_dict[item] == 0)
//             _dict.Remove(item);
//     }

//     // Return the last value in the multiset
//     public T Peek()
//     {
//         if (!_dict.Any())
//             throw new NullReferenceException();
//         return _dict.Last().Key;
//     }

//     // Return the last value in the multiset and remove it.
//     public T Pop()
//     {
//         T item = Peek();
//         Remove(item);
//         return item;
//     }

//     public IEnumerator<T> GetEnumerator()
//     {
//         foreach(var kvp in _dict)
//             for(int i = 0; i < kvp.Value; i++)
//                 yield return kvp.Key;
//     }

//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return this.GetEnumerator();
//     }
// }