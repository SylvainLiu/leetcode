<Query Kind="Program" />

void Main()
{
	CanJump(new int[] {2,0}).Dump();
}

// Define other methods and classes here
public bool CanJump(int[] nums)
{
	if (nums.Length == 0) return true;

	var max = 0;
	var current = 0;
	while (max < nums.Length - 1)
	{
		if (nums[current] == 0)
		{
			if (max > current) 
			{
				current ++;
				continue;
			}
			else 
			{
				return false;
			}
		}
		
		var temp = current + nums[current];
		max = Math.Max(max, nums[current]);
		current ++;
	}
	
	return true;
}