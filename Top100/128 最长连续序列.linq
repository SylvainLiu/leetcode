<Query Kind="Program" />

void Main()
{
	LongestConsecutive(new int[] {0,3,7,2,5,8,4,6,0,1}).Dump();
}

// Define other methods and classes here
public int LongestConsecutive(int[] nums)
{
	if (nums.Length == 0) return 0;

	var dic = new HashSet<int>(nums);
	var max = 1;
	for (var i = 0; i < nums.Length; i++)
	{
		if (dic.Contains(nums[i] - 1)) 
		{
			continue;
		}

		var current = nums[i];
		var tempL = 1;
		while(dic.Contains(++current))
		{
			tempL++;
		}
		max = Math.Max(tempL, max);
	}

	return max;
}