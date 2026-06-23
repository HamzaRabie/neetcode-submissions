public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] memo = new int[amount + 1];
        Array.Fill(memo, -1);

        int res = DP(coins, amount, memo);

        return res == 10001 ? -1 : res;
    }

    int DP(int[] coins, int amount, int[] memo)
    {
    if (amount == 0) return 0;
    if (amount < 0) return 10001;

    if (memo[amount] != -1)
        return memo[amount];

    int res = 10001;

    foreach (int coin in coins)
    {
        res = Math.Min(
            res,
            1 + DP(coins, amount - coin, memo)
        );
    }

    return memo[amount] = res;
    }
}