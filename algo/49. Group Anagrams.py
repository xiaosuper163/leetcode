class Solution:
    def groupAnagrams(self, strs: 'List[str]') -> 'List[List[str]]':
        helper_dict = {}
        for word in strs:
            tempStr = ''.join(sorted(word))
            if helper_dict.get(tempStr) is None:
                helper_dict[tempStr] = [word]
            else:
                helper_dict[tempStr].append(word)
        return list(helper_dict.values())