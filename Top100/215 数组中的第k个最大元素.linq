<Query Kind="Program" />

void Main()
{
	FindKthLargest(new int[] {2,1}, 2).Dump();
}

public int FindKthLargest(int[] nums, int k)
{
	if (nums.Length == 0) return 0;
	return nums.OrderByDescending(x => x).Skip(k-1).First();
}

//public int FindKthLargest(int[] nums, int k)
//{
//	if (nums.Length == 0) return 0;
//	var sort = new SortedList<int, int>();
//
//	for (var i = 0; i < nums.Length; i++)
//	{
//		if (sort.ContainsKey(nums[i])) sort[nums[i]]++;
//		else sort.Add(nums[i], 1);
//
//		if (i >= k) 
//		{
//			var first = sort.First().Key;
//			sort[first]--;
//			if (sort[first] == 0) sort.Remove(first);
//		}
//	}
//	
//	return sort.First().Key;
//}