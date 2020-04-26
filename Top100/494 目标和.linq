<Query Kind="Program" />

void Main()
{
	FindTargetSumWays(new int[] { 1, 1, 1, 1, 1 }, 3).Dump();
	FindTargetSumWays(new int[] { 1000 }, -1000).Dump();
	FindTargetSumWays(new int[] { 0,0,0,0,0,0,0,0,1 }, 1).Dump();
}


public int FindTargetSumWays(int[] nums, int S)
{
	if (nums.Length == 0) return 0;

	var target = 0;
	for (var i = 0; i < nums.Length; i++)
		target += nums[i];
	target += S;
	
	if (target % 2 != 0) return 0;
	target /= 2;
	if (target < -1000 || target > 1000) return 0;

	var dp = new int[2001];
	dp[1000] = 1;
	
	for (var i = 0; i < nums.Length; i++)
		for (var j = target + 1000; j >= nums[i] + 1000 ; j--)
		{
			dp[j] += dp[j - nums[i]];
		}
	return dp[target + 1000];
}

//public int FindTargetSumWays(int[] nums, int S)
//{
//	if (nums.Length == 0) return 0;
//
//	var memo = new Dictionary<int, int>[nums.Length];
//	for (var i = 0; i < memo.Length; i++) 
//	{
//		memo[i] = new Dictionary<int, int>();
//	}
//	
//	return FindTargetSumWays(nums, S, 0, 0, memo);
//}
//
//public int FindTargetSumWays(int[] nums, int S, int current, int index, Dictionary<int, int>[] memo)
//{
//	if (index == nums.Length && current == S) return 1;
//	if (index == nums.Length && current != S) return 0;
//	
//	if (memo[index].ContainsKey(current)) {return memo[index][current]; }
//	
//	var plus = FindTargetSumWays(nums, S, current + nums[index], index + 1, memo);
//	var sub = FindTargetSumWays(nums, S, current - nums[index], index + 1, memo);
//	
//	memo[index][current] = plus + sub;
//	return plus + sub;
//}