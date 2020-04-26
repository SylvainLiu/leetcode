<Query Kind="Program" />

void Main()
{
	
}

public int MaxSubArray(int[] nums)
{
	return MaxSubArray(nums, 0, nums.Length - 1);
}

public int MaxSubArray(int[] nums, int left, int right)
{
	if (left == right) return nums[left];

	var mid = (left + right) / 2;
	var leftMax = MaxSubArray(nums, left, mid);
	var rightMax = MaxSubArray(nums, mid + 1, right);

	var leftMidMax = int.MinValue;
	var Sum = 0;
	for (var i = mid; i >= left; i--)
	{
		Sum += nums[i];
		leftMidMax = Math.Max(Sum, leftMidMax);
	}

	var rightMidMax = int.MinValue;
	Sum = 0;
	for (var i = mid + 1; i <= right; i++)
	{
		Sum += nums[i];
		rightMidMax = Math.Max(Sum, rightMidMax);
	}

	return Math.Max( Math.Max(leftMax, rightMax), leftMidMax+rightMidMax);
}

// Define other methods and classes here
//public int MaxSubArray(int[] nums)
//{
//	if (nums.Length == 0) return 0;
//	if (nums.Length == 1) return nums[0];
//
//	var dp = 0;
//	var res = int.MinValue;
//	for (var i = 0; i < nums.Length; i++) 
//	{
//		dp = Math.Max(dp, 0) + nums[i];
//		res = Math.Max(dp, res);
//	}
//	
//	return res;
//}