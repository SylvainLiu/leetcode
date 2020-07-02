<Query Kind="Program" />

void Main()
{
	CoinChange(new int[] {2}, 3).Dump();
}

public int CoinChange(int[] coins, int amount)
{
	if (coins.Length == 0) return -1;
	
	var dp = Enumerable.Repeat(amount + 1, amount + 1).ToArray();
	dp[0] = 0;
	for (var i = 1; i < dp.Length; i++)
		for (var j = 0; j < coins.Length; j++)
		{
			if (i - coins[j] >= 0)
			{
				dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
			}
		}
	
	return dp[amount] > amount ? -1 : dp[amount];
}

// Define other methods and classes here
//public int CoinChange(int[] coins, int amount)
//{
//	if (coins.Length == 0) return -1;
//
//	var memo = new Dictionary<int, bool>[coins.Length];
//	for (var i = 0; i < memo.Length; i++) 
//	{
//		memo[i] = new Dictionary<int, bool>();
//	}
//	return BackTrack(coins, amount, 0, memo);
//}
//
//public int BackTrack(int[] coins, int rest, int j, Dictionary<int, bool>[] memo)
//{
//	if (rest == 0) return 0;
//	if (rest < 0 || j >= coins.Length) return -1;
//	if (memo[j].ContainsKey(rest) && !memo[j][rest]) return -1;
//
//	var min = int.MaxValue;
//	for (var x = 0; x <= rest / coins[j]; x++)
//	{
//		var res = BackTrack(coins, rest - x * coins[j], j + 1, memo);
//		if (res != -1) { min = Math.Min(min, res + x); }
//	}
//
//	if (!memo[j].ContainsKey(rest))
//	{
//		if (min != int.MaxValue) { memo[j].Add(rest, true); }
//		else { memo[j].Add(rest, false); }
//	}
//	return min == int.MaxValue ? -1 :  min;
//}