<Query Kind="Program" />

void Main()
{
	MaxProfit(new int[] {1,2,3,0,2}).Dump();
}

public int MaxProfit(int[] prices)
{
	if (prices.Length <= 1) return 0;
	
	var dp = new int[prices.Length, 3];
	dp[0, 0] = 0;
	dp[0, 1] = 0 - prices[0];
	dp[0, 2] = 0;
	for (var i = 1; i < prices.Length; i++) 
	{
		dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 2]);
		dp[i, 1] = Math.Max(dp[i - 1, 0] - prices[i], dp[i - 1, 1]);
		dp[i, 2] = dp[i - 1, 1] + prices[i];
	}
	
	return Math.Max(dp[prices.Length - 1, 2], dp[prices.Length - 1, 0]);
}