<Query Kind="Program" />

void Main()
{
	MissingNumber(new int[] {2, 0}).Dump();
}

// Define other methods and classes here
public int MissingNumber(int[] nums)
{
	if (nums.Length == 0) return 0;

	var set = new HashSet<int>();
	for (var i = 0; i < nums.Length; i++)
	{
		if (set.Contains(nums.Length - nums[i])) 
		{
			set.Remove(nums.Length - nums[i]);
		}
		else 
		{
			set.Add(nums[i]);
		}
	}

	if (set.Count() == 0) { return nums.Length / 2; }
	
	if (set.Count() == 2) { set.Remove(nums.Length / 2); }
	return nums.Length - set.First();
}