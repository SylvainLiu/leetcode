<Query Kind="Program" />

void Main()
{
	LengthOfLIS(new int[] {10,9,2,5,3,7,101,18}).Dump();
}

public int LengthOfLIS(int[] nums)
{
	if (nums.Length <= 0) return nums.Length;
	
	var dp = new List<int>();
	dp.Add(nums[0]);

	for (var i = 1; i < nums.Length; i++)
	{
		if (dp[dp.Count() - 1] < nums[i]) 
		{
			dp.Add(nums[i]);
		}
		else 
		{
			var left = 0;
			var right = dp.Count() - 1;
			while (left <= right) 
			{
				var mid = left + (right - left) / 2;
				if (dp[mid] < nums[i]) left = mid + 1;
				else right = mid;
			}
			dp[left] = nums[i];
		}
	}
	
	return dp.Count();
}

//
//public int LengthOfLIS(int[] nums)
//{
//	if (nums.Length == 0 || nums.Length == 1) return nums.Length;
//
//	var dp = new int[nums.Length];
//	dp[0] = 1;
//	var ans = 0;
//	
//	for (var i = 1; i < nums.Length; i++)
//	{
//		var ansi = 0;
//		for (var j = 0; j < i; j++)
//		{
//			if (nums[i] > nums[j]) 
//			{
//				ansi = Math.Max(ansi, dp[j]);
//			}
//		}
//		dp[i] = ansi + 1;
//		ans = Math.Max(ans, dp[i]);
//	}
//	
//	return ans;
//}