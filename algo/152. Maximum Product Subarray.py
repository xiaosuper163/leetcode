# my solution might be too complicated, not easy to memorize
# an easier solution could be calculating max(lastMax*this, lastMin*this, this)

class Solution:
    def maxProduct(self, nums: 'List[int]') -> 'int':
        if len(nums) == 0:
            return
        if len(nums) == 1:
            return nums[0]
        helper_list = [nums[0]]
        for i in range(1,len(nums)):
            if nums[i] > 0:
                if helper_list[i-1] > 0:
                    helper_list.append(nums[i]*helper_list[i-1])
                else:
                    helper_list.append(nums[i])
            elif nums[i] == 0:
                helper_list.append(0)
            else:  # current number is negative
                j = i-1
                product = nums[i]
                while j>=0 and nums[j] > 0:
                    product *= nums[j]
                    j -= 1
                if j<0:
                    helper_list.append(nums[i])
                else:
                    product *= nums[j]
                    k = j - 1
                    if k>=0 and helper_list[k] > 0:
                        product *= helper_list[k]
                    helper_list.append(product)
        print(helper_list)
        return max(helper_list)