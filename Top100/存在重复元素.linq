<Query Kind="Program" />

void Main()
{
	
}

public bool ContainsDuplicate(int[] nums)
{
	if (nums.Length == 0) return false;
	
	var set = new HashSet<int>(nums.Length);

	for (var i = 0; i < nums.Length; i++)
	{
		if (!set.Add(nums[i])) 
		{
			return true;	
		}
	}
	
	return false;
}