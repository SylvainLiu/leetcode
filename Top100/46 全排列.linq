<Query Kind="Program" />

void Main()
{
	Permute(new int[] {1,2,3}).Dump();
}

public IList<IList<int>> Permute(int[] nums)
{
	var res = new List<IList<int>>();
	if (nums.Length == 0) return res;
	
	var state = new bool[nums.Length];
	var current = new List<int>();
	DSF(res, nums, current, state);
	return res;
}

public void DSF(List<IList<int>> res, int[] nums, List<int> current, bool[] state)
{
	if (current.Count() == nums.Length) { res.Add(current.ToArray()); return;}
	
	for(var i = 0; i < nums.Length; i++)
	{
		if (!state[i]) 
		{
			state[i] = true;
			current.Add(nums[i]);
			DSF(res, nums, current, state);
			current.RemoveAt(current.Count() - 1);
			state[i] = false;
		}
	}
}

//public IList<IList<int>> Permute(int[] nums)
//{
//	var res = new List<IList<int>>();
//	if (nums.Length == 0) return res;
//
//	res.Add(nums);
//	for (int i = 0; i < nums.Length; i++)
//	{
//		var count = res.Count();
//		for (int j = i + 1; j < nums.Length; j++)
//		{			
//			for (int k = 0; k < count; k++)
//			{
//				var copy = res[k].ToArray();
//				var temp = copy[i];
//				copy[i] = copy[j];
//				copy[j] = temp;
//				res.Add(copy);
//			}
//		}
//	}
//	return res;
//}