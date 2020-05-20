<Query Kind="Program" />

void Main()
{
	TopKFrequent(new int[] {4,1,-1,2,-1,2,3}, 2).Dump();
}

public IList<int> TopKFrequent(int[] nums, int k)
{
	var res = new List<int>();
	if (nums.Length == 0 || k == 0) return res;

	var dic = new Dictionary<int, int>();
	for (var i = 0; i < nums.Length; i++)
	{
		if (dic.ContainsKey(nums[i])) dic[nums[i]]++;
		else dic.Add(nums[i], 1);
	}

//	var sort = new SortedDictionary<int, int>(Comparer<int>.Create((x, y) => dic[x].CompareTo(dic[y])));
//	var sort = new SortedDictionary<int, int>(new Comparer(dic));
	var sort = new SortedDictionary<int, int>(Comparer<int>.Create(
		(x, y) =>
		{
			int vx = dic[x], vy = dic[y];
			return vx == vy ? x.CompareTo(y) : vx.CompareTo(vy);
		}));
	
	foreach (var pair in dic)
	{
		sort.Add(pair.Key, pair.Value);
		//if (sort.Count() > k) sort.Remove(sort.First().Key);
	}
	
	return sort.Keys.Take(k).ToList();
}

public class Comparer : IComparer<int> 
{
	private Dictionary<int, int> dic;
	public Comparer(Dictionary<int, int> idc) 
	{
		dic = idc;
	}

	public int Compare(int x, int y)
	{
		return dic[x] == dic[y] ? x.CompareTo(y) : dic[x].CompareTo(dic[y]);
	}
}

//public IList<int> TopKFrequent(int[] nums, int k)
//{
//	if (nums.Length == 0) return null;
//	if (k == 0) return null;
//
//	var dic = new Dictionary<int, int>();
//	for (var i = 0; i < nums.Length; i++)
//	{
//		if (dic.ContainsKey(nums[i])) 
//		{
//			dic[nums[i]]++;
//		}
//		else 
//		{
//			dic.Add(nums[i], 1);
//		}
//	}
//
//	return dic.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToList();	
//}