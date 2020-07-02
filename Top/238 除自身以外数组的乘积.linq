<Query Kind="Program" />

void Main()
{
	ProductExceptSelf(new int[] {1,2,3,4}).Dump();
}

public int[] ProductExceptSelf(int[] nums)
{
	var res = new int[nums.Length];
	var left = new int[nums.Length];
	left[0] = 1;
	var right = new int[nums.Length];
	right[nums.Length - 1] = 1;

	for (var i = 1; i < nums.Length; i++)
	{
		left[i] = left[i - 1] * nums[i - 1];
		right[nums.Length - i - 1] = left[nums.Length - i] * nums[nums.Length - i];
	}

	for (var i = 0; i < nums.Length; i++) 
	{
		res[i] = left[i] * right[i];
	}

	return res;
}