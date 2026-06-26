public class Solution
{
    Dictionary<(int, int), int> memo = new();

    public int FindTargetSumWays(int[] nums, int target)
    {
        return DP(0, target, nums);
    }

    int DP(int i, int target, int[] nums)
    {
        if (i == nums.Length)
            return target == 0 ? 1 : 0;

        if (memo.ContainsKey((i, target)))
            return memo[(i, target)];

        int res =
            DP(i + 1, target - nums[i], nums) +
            DP(i + 1, target + nums[i], nums);

        return memo[(i, target)] = res;
    }
}