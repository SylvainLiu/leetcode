<Query Kind="Program" />

void Main()
{
	FourSum(new int[] { -1, -5, -5, -3, 2, 5, 0, 4 }, -7).Dump();
}

// Define other methods and classes here
public IList<IList<int>> FourSum(int[] nums, int target)
{
	var res = new List<IList<int>>();
	if (nums.Length < 4) return res;

	nums = nums.OrderBy(x => x).ToArray();
	for (var i = 0; i < nums.Length - 3; i++)
	{
		if (nums[i] > 0) break;
		if (i > 0 && nums[i] == nums[i - 1]) continue;

		for (var j = i + 1; j < nums.Length - 2; j++)
		{
			if (j > i + 1 && nums[j] == nums[j - 1]) continue;
			var tar = target - nums[i] - nums[j];

			var l = j + 1;
			var r = nums.Length - 1;
			while (l < r)
			{
				var sum = nums[l] + nums[r];
				if (sum == tar)
				{
					res.Add(new List<int> { nums[i], nums[j], nums[l], nums[r] });
					while (l < r && nums[l] == nums[++l]) { }
					while (l < r && nums[r] == nums[--r]) { }
				}
				if (sum > tar) r--;
				if (sum < tar) l++;
			}
		}
	}

	return res;
}