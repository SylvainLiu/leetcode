<Query Kind="Program" />

void Main()
{
	FindUnsortedSubarray(new int[] {1,2,3,4});
}

public int FindUnsortedSubarray(int[] nums)
{
	if (nums.Length == 0 || nums.Length == 1) return 0;

	var min = int.MaxValue;
	var max = int.MinValue;
	var flag = false;
	for (var i = 1; i < nums.Length; i++)
	{
		if (nums[i] < nums[i -1]) flag = true;
		if (flag) min = Math.Min(min, nums[i]);
	}
	if (!flag) return 0;
	
	flag = false;
	for (var i = nums.Length - 2; i >= 0; i--)
	{
		if (nums[i] > nums[i + 1]) flag =true;
		if (flag) max = Math.Max(max, nums[i]);
	}

	var index = 0;
	while (index < nums.Length)
	{
		if (nums[index] > min) { min = index; break;}
		index++;
	}

	index = nums.Length - 1;
	while (index >= 0)
	{
		if (nums[index] < max) { max = index; break; }
		index--;
	}
	
	return Math.Max(0, max - min + 1);
}

// Define other methods and classes here
//public int FindUnsortedSubarray(int[] nums)
//{
//	if (nums.Length == 0 || nums.Length == 1) return 0;
//	
//	var min = int.MaxValue;
//	var max = int.MinValue;
//	var flag = false;
//	for (var i = 1; i < nums.Length; i++)
//	{
//		if (nums[i] < nums[i - 1]) flag = true;
//		if (flag) min = Math.Min(min, nums[i])
//	}
//	flag = false;
//	for (var i = nums.Length - 2; i >= 0; i--)
//	{
//		if (nums[i] > nums[i + 1]) flag = true;
//		if (flag) max = Math.Max(max, nums[i])
//	}
//	int l, r;
//	for (l = 0; l < nums.Length; l++)
//	{
//		if (min < nums[l])
//			break;
//	}
//	for (r = nums.Length - 1; r >= 0; r--)
//	{
//		if (max > nums[r])
//			break;
//	}
//
//	return Math.Max(0, r - l + 1);
//}