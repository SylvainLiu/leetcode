<Query Kind="Program" />

void Main()
{
	ClimbStairs(3).Dump();
}

public int ClimbStairs(int n)
{
	if (n <= 2) return n;

	var dp = new int[n + 1];
	dp[1] = 1;
	dp[2] = 2;

	for (var i = 3; i < n + 1; i++)
	{
		dp[i] = dp[i-1] + dp[i-2];
	}
	
	return dp[n];
}

//public int ClimbStairs(int n) 
//{
//	var dp = Enumerable.Repeat(0, n).ToArray();
//	dp[0] = 1;
//	dp[1] = 2;
//
//	if (n <= 2) return dp[n-1];
//	
//	for (var i = 2; i < n - 1; i++) 
//	{
//		dp[i] = dp[i-1] + dp[i-2];
//	}
//	
//	return dp[n-1];
//}

// Define other methods and classes here
//public int ClimbStairs(int n)
//{
//	if (n == 1) return 1;
//	if (n == 2) return 2;
//
//	var cache = Enumerable.Repeat(0, n).ToArray();
//	cache[0] = 1;
//	cache[1] = 2;
//
//	return ClimbStairs(cache, n);
//}
//
//public int ClimbStairs(int[] cache, int n)
//{
//	if (cache[n - 1] != 0) return cache[n - 1];
//
//	var sub1 = 0;
//	var sub2 = 0;
//	if (cache[n - 2] != 0) 
//	{
//		sub1 = cache[n - 2];
//	}
//	else 
//	{
//		sub1 = ClimbStairs(cache, n - 1);
//		cache[n - 2] = sub1;
//	}
//
//	if (cache[n - 3] != 0)
//	{
//		sub2 = cache[n - 3];
//	}
//	else
//	{
//		sub2 = ClimbStairs(cache, n - 2);
//		cache[n - 3] = sub2;
//	}
//
//	cache[n - 1] = sub1 + sub2;
//	cache[n - 2] = sub1;
//	cache[n - 3] = sub2;
//	return cache[n - 1];
//}