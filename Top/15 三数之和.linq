<Query Kind="Program" />

void Main()
{
	ThreeSum(new int[] {-1,0,1,2,-1,-4}).Dump();
}

public IList<IList<int>> ThreeSum(int[] nums)
{
	var res = new List<IList<int>>(); 
	if (nums.Length <= 2) return res;

	nums = nums.OrderBy(x => x).ToArray();
	for (var i = 0; i < nums.Length; i++) 
	{
		if (nums[i] >= 0) break;
		if (i > 0 && nums[i] == nums[i-1]) continue;
		
		var l = i + 1;
		var r = nums.Length - 1;
		while (l < r) 
		{
			var sum = nums[i] + nums[l] + nums[r];
			if (sum == 0)
			{
				res.Add(new List<int> { nums[i], nums[l], nums[r] });
				while (l < r && nums[l] == nums[++l]);
				while (l < r && nums[r] == nums[--r]);
			}
			if (sum < 0) l++;
			if (sum > 0) r--;
		}
	}
	return res;
/}