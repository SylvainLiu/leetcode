<Query Kind="Program" />

void Main()
{
	MaxCoins(new int[] {7,9,8,0,7,1,3,5,5,2,3}).Dump();
}

public int MaxCoins(int[] nums) 
{
	if (nums.Length == 0) return 0;

	var array = new int[nums.Length + 2];
	for (var i = 1; i < nums.Length + 1; i++)
		array[i] = nums[i - 1];
	array[0] = 1;
	array[array.Length - 1] = 1;

	var memo = new int[array.Length, array.Length];
	return Chop(array, 0, array.Length - 1, memo);
}

public int Chop(int[] array, int left, int right, int[,] memo) 
{
	if (right - left == 1) return 0;	
	if (memo[left, right] != 0) return memo[left, right];
	
	var res = 0;
	for (var i = left + 1; i < right; i++)
	{
		var maxL = Chop(array, left, i, memo);
		var maxR = Chop(array, i, right, memo);
		res = Math.Max(res, maxL + maxR + array[left] * array[right] * array[i]);
	}
	memo[left, right] = res;
	return res;
}


//public int MaxCoins(int[] nums)
//{
//	var length = nums.Length;
//	length += 2;
//	var nums2 = new int[length];
//	nums2[0] = 1;
//	nums2[length - 1] = 1;
//	for (var i = 1; i < length - 1; i++) 
//	{
//		nums2[i] = nums[i-1];
//	}
//
//	var dp = new int[length, length];
//	for (var i = 0; i < length - 1; i++) 
//	{
//		dp[i, i + 1] = 0;
//	}
//
//	for (var len = 3; len <= length; len++)
//		for (var i = 0; i + len - 1 < length; i++) 
//		{
//			var j = i + len -1;
//			dp[i, j] = int.MinValue;
//			for (var k = i + 1; k <= j - 1; k++) 
//			{
//				dp[i, j] = Math.Max(dp[i,j], dp[i,k] + dp[k,j] + nums2[i]*nums2[k]*nums2[j]);
//			}
//		}
//		
//	return dp[0, length-1];
//}