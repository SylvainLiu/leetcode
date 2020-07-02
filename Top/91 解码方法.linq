<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int NumDecodings(string s)
{
	if (string.IsNullOrEmpty(s)) return 0;
	if (s[0] == '0') return 0;

	var dp = new int[s.Length + 1];
	dp[0] = 1;
	dp[1] = 1;
	
	for (var i = 1; i < s.Length; i++)
	{
		if (s[i] == '0')
		{
			if (s[i - 1] == '1' || s[i - 1] == '2') dp[i + 1] = dp[i - 1];
			else return 0;
		}
		else if (s[i - 1] == '1') dp[i + 1] = dp[i - 1] + dp[i];
		else if (s[i - 1] == '2' && s[i] - '0' <= 6) dp[i + 1] = dp[i - 1] + dp[i];
		else dp[i + 1] = dp[i];
	}
	
	return dp[s.Length];
}