<Query Kind="Program" />

void Main()
{
	CanPartition(new int[] {1, 1}).Dump();
}

public bool CanPartition(int[] nums)
{
	if (nums.Length == 1) return false;
 
 	var sum = 0;
	for (var i = 0; i < nums.Length; i++)
		sum += nums[i];

	if (sum % 2 != 0) return false;
 	sum /= 2;

	var memo = new bool[nums.Length, sum + 1];
	if (sum > nums[0]) memo[0, nums[0]] = true;

	for (var i = 1; i < nums.Length; i++)
		for (var j = 0; j < sum + 1; j++) 
		{
			if (j == nums[i]) 
			{
				memo[i, j] = true;
			}
			else if (j > nums[i])
			{
				memo[i, j] = memo[i - 1, j] || memo[i - 1, j - nums[i]];
			}

			if (j == sum && memo[i, j]) { return true; }
		}
		
	return false;
}

// Define other methods and classes here
//public bool CanPartition(int[] nums)
//{
//	if (nums.Length == 1) return false;
//
//	var sum = 0;
//	for (var i = 0; i < nums.Length; i++) 
//	{
//		sum += nums[i];
//	}
//	
//	if (sum % 2 != 0) return false;
//	sum /= 2;
//
//	memo = new int[nums.Length][];
//	for (var i = 0; i < memo.Length; i++)
//	{
//		memo[i] = new int[sum + 1];
//	}
//	
//	nums = nums.OrderBy(x => x).ToArray();
//	return BackTrack(nums, nums.Length - 1, sum);
//}
//
//public int[][] memo;
//public bool BackTrack(int[] nums, int i, int rest)
//{
//	if (rest < 0 || i == 0) { return false; }
//	if (rest == 0) { return true; }
//
//	if (memo[i][rest] != 0)
//	{
//		return memo[i][rest] == 1;
//	}
//	
//	var res1 = BackTrack(nums, i - 1, rest - nums[i]);
//	var res2 = BackTrack(nums, i - 1, rest);
//	
//	memo[i][rest] = res1 || res2 ? 1 : 2;
//	return res1 || res2;
//}