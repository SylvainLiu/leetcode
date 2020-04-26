<Query Kind="Program" />

void Main()
{
	Rob(new int[] {1, 2, 3, 1}).Dump();
}

// Define other methods and classes here
public int Rob(int[] nums)
{
	if (nums.Length == 0) return 0;
	
	var dp = new int[2];
	dp[0] = 0;
	dp[1] = nums[0];

	for (var i = 1; i < nums.Length; i++) 
	{
		var temp = dp[0];
		dp[0] = Math.Max(dp[0], dp[1]);
		dp[1] = dp[0] + nums[i];
	}
	
	return Math.Max(dp[0], dp[1]);
}

//public int Rob(int[] nums)
//{
//	if (nums.Length == 0) return 0;
//	if (nums.Length == 1) return nums[0];
//
//	var dp = new int[2][];
//	dp[0] = Enumerable.Repeat(0, nums.Length).ToArray();
//	dp[1] = Enumerable.Repeat(0, nums.Length).ToArray();
//
//	dp[0][0] = 0;
//	dp[1][0] = nums[0];
//
//	dp[0][1] = nums[0];
//	dp[1][1] = nums[1];
//
//	for (var i = 2; i < nums.Length; i++) 
//	{
//		dp[0][i] = Math.Max(dp[0][i-1], dp[1][i-1]);
//		dp[1][i] = Math.Max(dp[0][i-2], dp[1][i-2]) + nums[i];
//	}
//	
//	return Math.Max(dp[0][nums.Length - 1], dp[1][nums.Length - 1]);
//}