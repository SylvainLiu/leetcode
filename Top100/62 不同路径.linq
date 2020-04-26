<Query Kind="Program" />

void Main()
{
	UniquePaths(3, 2).Dump();
}

public int UniquePaths(int m, int n)
{
	if (m == 0 || n == 0) return 0;

	var dp = Enumerable.Repeat(1, n).ToArray();
	for (var i = 1; i < m; i++)
		for (var j = 1; j < n; j++)
		{
			dp[j] = dp[j - 1] + dp[j];
		}
	
	return dp[n - 1];
}