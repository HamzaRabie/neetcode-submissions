public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> dq = new(); 
        int n = nums.Length;
        int[] res = new int[n - k + 1];

        for (int i = 0; i < n; i++) {
            while (dq.Count > 0 && nums[dq.Last.Value] < nums[i]) {
                dq.RemoveLast();
            }

            dq.AddLast(i);

            if (dq.First.Value <= i - k) {
                dq.RemoveFirst();
            }

            if (i >= k - 1) {
                res[i - k + 1] = nums[dq.First.Value];
            }
        }

        return res;
    }
}