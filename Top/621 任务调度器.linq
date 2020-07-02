<Query Kind="Program" />

void Main()
{
	LeastInterval(new char[] {'A','A','A','A','A','A','B','C','D','E','F','G'}, 2).Dump();
}

public int LeastInterval(char[] tasks, int n)
{
	if (n < 1) return tasks.Length;

	var arr = new int[26];
	var dic = new SortedDictionary<int, int>(Comparer<int>.Create((x, y) => arr[x] == arr[y] ? y.CompareTo(x): arr[y].CompareTo(arr[x])));
	for (var i = 0; i < tasks.Length; i++)
		arr[tasks[i] - 'A']++;
	for (var i = 0; i < 26; i++)
	{
		if (arr[i] != 0) dic.Add(i, arr[i]);
	}

	var res = 0;
	while (dic.Any())
	{
		var temp = new List<int>();
		var count = 0;
	
		while (count <= n)
		{
			if (dic.Any()) 
			{
				var key = dic.First().Key;
				dic.Remove(key);
				if (--arr[key] > 0)
					temp.Add(key);
			}
			else if (!temp.Any())
			{
				break;
			}
			res++;
			count++;
		}
		for (var i = 0; i < temp.Count(); i++) 
		{
			if (arr[temp[i]] > 0)
				dic.Add(temp[i], arr[temp[i]]);
		}
	}

	return res;
}

//public int LeastInterval(char[] tasks, int n)
//{
//	if (n < 1) return tasks.Length;
//	
//	var arr = new int[26];
//	for (var i = 0; i < tasks.Length; i++)
//		arr[tasks[i] - 'A']++;
//	var map = arr.Where(x => x!= 0).OrderByDescending(x => x).ToArray();
//		
//	var res = 0;
//	while (map.Any())
//	{
//		var count = 0;
//		while (count <= n) 
//		{
//			if (map[0] == 0) break;
//			if (count < map.Count() && map[count] > 0) map[count]--;
//			res++;
//			count++;
//		}
//		map = map.Where(x => x!= 0).OrderByDescending(x => x).ToArray();
//	}
//	
//	return res;
//}