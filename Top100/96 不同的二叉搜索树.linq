<Query Kind="Program" />

void Main()
{
	NumTrees(3).Dump();
}

public int NumTrees(int n)
{
	if (n == 0) return 0;
	var dp = new int[n + 1];
	dp[0] = 1;
	dp[1] = 1;

	for (var i = 2; i < n + 1; i++)
		for (var j = 0; j < i; j++) 
		{
			dp[i] += dp[j] * dp[i - j - 1];
		}
		
	return dp[n];
}