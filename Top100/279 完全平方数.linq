<Query Kind="Program" />

void Main()
{
	NumSquares(13).Dump();
}

public int NumSquares(int n)
{
	if (n <= 0) return 0;

	var dp = new int[n + 1];
	dp[0] = 0;
	
	for (var i = 1; i < n + 1; i++)
	{
		dp[i] = int.MaxValue;
		for (var j = 1; j <= Math.Sqrt(i); j++)
		{
			dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
		}
	}

	return dp[n];
}