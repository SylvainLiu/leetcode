<Query Kind="Program" />

void Main()
{
	
}

public IList<int> FindDisappearedNumbers(int[] nums)
{
	for (var i = 0; i < nums.Length; i++) 
	{
		var index = Math.Abs(nums[i]) - 1;
		if (nums[index] > 0) nums[index] *= -1;
	}
	
	var res = new List<int>();
	for (var i = 0; i < nums.Length; i++)
	{
		if (nums[i] > 0) res.Add(i + 1);
	}
	
	return res;
}

// Define other methods and classes here
//public IList<int> FindDisappearedNumbers(int[] nums)
//{
//	for (var i = 0; i < nums.Length; i++)
//	{
//		var next = Math.Abs(nums[i]) - 1;		
//		if (nums[next] > 0) nums[next] *= -1;
//	}
//
//	var count = new List<int>();
//	for (var i = 0; i < nums.Length; i++)
//	{
//		if (nums[i] > 0) count.Add(i + 1);
//	}
//	
//	return count;
}