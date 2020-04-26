<Query Kind="Program" />

void Main()
{
	Subsets(new int[] {1, 2, 3}).Dump();
}

public IList<IList<int>> Subsets(int[] nums)
{
	var res = new List<IList<int>>();
	BT(nums, res, new List<int>(), 0);
	return res;
}

public void BT(int[] nums, List<IList<int> > res, List<int> current, int i)
{
	if (i == nums.Length) 
	{
		res.Add(current.ToList());
		return;
	}

	BT(nums, res, current, i + 1);

	current.Add(nums[i]);
	BT(nums, res, current, i + 1);
	current.RemoveAt(current.Count() - 1);
}

// Define other methods and classes here
//public IList<IList<int>> Subsets(int[] nums)
//{
//	var res = new List<IList<int>>();
//	res.Add(new List<int>());
//	
//	for (var i = 0; i < nums.Length; i++)
//	{
//		var temp = new List<IList<int>>();
//		foreach (var list in res)
//		{
//			var copy = list.ToList();
//			copy.Add(nums[i]);
//			temp.Add(copy);
//		}
//		res = temp.Concat(res).ToList();
//	}
//	
//	return res.ToList();
//}