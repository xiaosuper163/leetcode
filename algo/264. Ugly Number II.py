# @9 Priority Queue
class Solution:
    def nthUglyNumber(self, n: int) -> int:
        import heapq
        hq = [1]
        helper_dict = {1:1}
        for i in range(n):
            res = heapq.heappop(hq)
            for factor in [2,3,5]:
                newValue = factor*res
                if helper_dict.get(newValue, 0) == 0:
                    heapq.heappush(hq, newValue)
                    helper_dict[newValue] = 1
        return res