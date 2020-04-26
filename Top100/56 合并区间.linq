<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int[][] Merge(int[][] intervals)
{
	if (intervals.Length == 0) return null;
	if (intervals.Length == 1) return intervals;
	
	intervals = intervals.OrderBy(x => x, new Comparer()).ToArray();

	var res = new List<int[]>();
	var pre = intervals[0];
	for (var i = 1; i < intervals.Length; i++)
	{
		if (intervals[i][0] <= pre[1]) 
		{
			pre[1] = intervals[i][1] > pre[1] ? intervals[i][1] : pre[1];
			continue;
		}
		else 
		{
			res.Add(pre);
			pre = intervals[i];
		}
	}
	
	res.Add(pre);	
	return res.ToArray();
}

class Comparer : IComparer<int[]> 
{
	public int Compare(int[] x, int[] y)
	{
		return x[0] == y[0] ? x[1].CompareTo(x[1]) : x[0].CompareTo(x[0]);
	}
}