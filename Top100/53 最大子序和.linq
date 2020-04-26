<Query Kind="Program" />

void Main()
{
	
}

public int MaxSubArray(int[] nums)
{
	if (nums.Length == 0) return 0;
	return MaxSubArray(nums, 0, nums.Length - 1);
}

public int MaxSubArray(int[] nums, int left, int right) 
{
	if (left == right) return nums[left];

	var mid = left + (right - left) / 2;
	var valLeft = MaxSubArray(nums, left, mid);
	var valRight = MaxSubArray(nums, mid + 1, right);

	var sum = 0;
	var maxLeft = int.MinValue;
	for (var i = mid; i >= left; i--) 
	{
		sum += nums[i];
		maxLeft = Math.Max(maxLeft, sum);
	}
	
	sum = 0;
	var maxRight = int.MinValue;
	for (var i = mid + 1; i <= right; i++)
	{
		sum += nums[i];
		maxRight = Math.Max(maxRight, sum);
	}
	
	return Math.Max(Math.Max(valLeft, valRight), maxLeft + maxRight);
}



//public int MaxSubArray(int[] nums)
//{
//	if (nums.Length == 0) return 0;
//	
//	var dp = new int[nums.Length];
//	dp[0] = nums[0];
//	var res = nums[0];
//	for (var i = 1; i < nums.Length; i++) 
//	{
//		nums[i] = nums[i - 1] < 0? nums[i] : nums[i-1] + nums[i];
//		res = Math.Max(nums[i], res);
//	}
//	
//	return res;
//}

//public int MaxSubArray(int[] nums)
//{
//	return MaxSubArray(nums, 0, nums.Length - 1);
//}
//
//public int MaxSubArray(int[] nums, int left, int right)
//{
//	if (left == right) return nums[left];
//
//	var mid = (left + right) / 2;
//	var leftMax = MaxSubArray(nums, left, mid);
//	var rightMax = MaxSubArray(nums, mid + 1, right);
//
//	var leftMidMax = int.MinValue;
//	var Sum = 0;
//	for (var i = mid; i >= left; i--)
//	{
//		Sum += nums[i];
//		leftMidMax = Math.Max(Sum, leftMidMax);
//	}
//
//	var rightMidMax = int.MinValue;
//	Sum = 0;
//	for (var i = mid + 1; i <= right; i++)
//	{
//		Sum += nums[i];
//		rightMidMax = Math.Max(Sum, rightMidMax);
//	}
//
//	return Math.Max( Math.Max(leftMax, rightMax), leftMidMax+rightMidMax);
//}

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