<Query Kind="Program" />

void Main()
{
	MaxProduct(new int[] {-2}).Dump();
}

// Define other methods and classes here
public int MaxProduct(int[] nums)
{
	if (nums.Length == 0) return 0;

	var dpMax = new int[nums.Length];
	var dpMin = new int[nums.Length];
	dpMax[0] = nums[0];
	dpMin[0] = nums[0];
	
	var max = nums[0];
	for (var i = 1; i < nums.Length; i++)
	{
		dpMax[i] = Math.Max(Math.Max(dpMax[i - 1] * nums[i], dpMin[i - 1] * nums[i]), nums[i]);
		dpMin[i] = Math.Min(Math.Min(dpMax[i - 1] * nums[i], dpMin[i - 1] * nums[i]), nums[i]);
		
		max = Math.Max(max, dpMax[i]);
	}
	
	return max;
}