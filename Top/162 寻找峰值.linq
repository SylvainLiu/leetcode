<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int FindPeakElement(int[] nums)
{
	if (nums == null || nums.Length == 0) return -1;
	
	var l = 0;
	var r = nums.Length - 1;
	while (l < r) 
	{
		var mid = l + (r - l) / 2;
		if (nums[mid] < nums[mid + 1]) 
		{
			l = mid + 1;
		}
		else 
		{
			r = mid;
		}
	}
	
	return l;
}