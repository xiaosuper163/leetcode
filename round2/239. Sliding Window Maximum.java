class Solution {
    public int[] maxSlidingWindow(int[] nums, int k) {
        if (nums.length == 0) return new int[0];
        int[] res = new int[nums.length - k + 1];
        Deque<Integer> q = new ArrayDeque();
        int ri = 0;
        for (int i = 0; i < nums.length; i++) {
            while (!q.isEmpty() && q.peek() <= i-k) {
                q.poll();
            }
            while (!q.isEmpty() && nums[q.peekLast()] < nums[i]) {
                q.pollLast();
            }
            q.offer(i);
            if (i >= k - 1) {
                res[ri++] = nums[q.peek()];
            }
        }
        return res;
    }
}