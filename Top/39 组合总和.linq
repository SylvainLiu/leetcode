<Query Kind="Program" />

void Main()
{
	
}

public IList<IList<int>> CombinationSum(int[] candidates, int target)
{
	if (candidates.Length == 0) return res;
	
	BT(candidates, target, 0, new List<int>());
	return res;
}

public IList<IList<int>> res = new List<IList<int>>();
public void BT(int[] candidates, int target, int index, List<int> current)
{
	if (target == 0) { res.Add(current.ToList()); return; }
	if (index == candidates.Length) return;

	var limit = target / candidates[index];
	if (limit != 0)
	{
		var tail = Enumerable.Repeat(candidates[index], limit);
		current = current.Concat(tail).ToList();
		
		for (var i = limit; i >= 1; i--)
		{
			BT(candidates, target - i * candidates[index], index + 1, current);
			current.RemoveAt(current.Count - 1);
		}
	}

	BT(candidates, target, index + 1, current);
}

//public IList<IList<int>> CombinationSum(int[] candidates, int target)
//{
//	var res = new List<IList<int>>();
//	if (candidates.Length == 0) return res;
//	
//	BackTrack(res, new List<int>(), candidates, target, 0);
//	return res;
//}
//
//public void BackTrack(IList<IList<int>> res, IList<int> current, int[] candidates, int target, int index)
//{
//	if (target == 0) { res.Add(current.ToList()); return; }
//	
//	for (var i = index; i < candidates.Length; i++)
//	{
//		if (target < candidates[i]) { continue; }
//		
//		current.Add(candidates[i]);
//		BackTrack(res, current, candidates, target - candidates[i], i);
//		current.RemoveAt(current.Count() - 1);
//	}
//}