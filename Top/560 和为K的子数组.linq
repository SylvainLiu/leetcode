<Query Kind="Program" />

void Main()
{
	SubarraySum(new int[] {1, 1, 1}, 2).Dump();
}

public int SubarraySum(int[] nums, int k)
{
	if (nums.Length == 0) return 0;

	var dp1 = new Dictionary<int, int>();
	dp1.Add(0,1);
	var sum = 0;
	var count = 0;
	for (var i = 0; i < nums.Length; i++)
	{
		sum += nums[i];

		if (dp1.ContainsKey(sum - k))
		{
			count += dp1[sum-k];
		}

		if (dp1.ContainsKey(sum))
		{
			dp1[sum] += 1;
		}
		else
		{
			dp1.Add(sum, 1);
		}
	}

	return count;
}