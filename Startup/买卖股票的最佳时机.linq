<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int MaxProfit(int[] prices)
{
	if (prices.Length == 0 || prices.Length == 1) return 0;
	
	var minPrice = int.MaxValue;
	var maxProfit = 0;
	for (var i = 0; i < prices.Length; i++)
	{
		if (minPrice > prices[i]) { minPrice = prices[i]; }
		else if (prices[i] - minPrice > maxProfit) {maxProfit = prices[i] - minPrice;}
	}
	return maxProfit;
}

//public int MaxProfit(int[] prices)
//{
//	if (prices.Length == 0 || prices.Length == 1) return 0;
//
//	var dp = new int[2][];
//	dp[0] = Enumerable.Repeat(0, prices.Length).ToArray();
//	dp[1] = Enumerable.Repeat(0, prices.Length).ToArray();
//
//	dp[0][0] = prices[0];
//	dp[0][1] = 0;
//
//	for (var i = 1; i < prices.Length; i++) 
//	{
//		dp[0][i] = prices[i] < dp[0][i-1] ? prices[i] : dp[0][i-1];
//		dp[1][i] = prices[i] - dp[0][i-1] > dp[1][i-1] ? prices[i] - dp[0][i-1] : dp[1][i-1];
//	}
//	
//	return dp[1][prices.Length];
//}