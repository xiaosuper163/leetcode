# Definition for an interval.
# class Interval:
#     def __init__(self, s=0, e=0):
#         self.start = s
#         self.end = e

class Solution:
    def merge(self, intervals: 'List[Interval]') -> 'List[Interval]':
        helper_dict = {}
        for interval in intervals:
            if interval.start not in helper_dict.keys():
                helper_dict[interval.start] = interval
            else:
                if interval.end > helper_dict[interval.start].end:
                    helper_dict[interval.start] = interval
                else:
                    continue
        helper_dict = sorted(helper_dict.items())
        res = []
        for i in range(len(helper_dict)):
            currInterval = helper_dict[i][1]
            if i == 0:
                res.append(currInterval)
            else:
                lastInterval = res[-1]
                if currInterval.start> lastInterval.end:
                    res.append(currInterval)
                else:
                    res[-1].end = max(lastInterval.end, currInterval.end)
        return res