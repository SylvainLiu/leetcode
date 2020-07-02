<Query Kind="Program" />

void Main()
{
	MaxEvents(new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 1, 2 }}).Dump();
}

//Define other methods and classes here
public int MaxEvents(int[][] events)
{
	if (events == null) return 0;
	if (events.Length < 2) return events.Length;

	Array.Sort(events, (int[] x, int[] y) => 
	{
		return x[1] != y[1] ? x[1].CompareTo(y[1]) : x[0].CompareTo(y[0]);
	});


	var hash = new HashSet<int>();
	for (var i = 0; i < events.Length; i++)
	{
		for (var j = events[i][0]; j <= events[i][1]; j++)
		{
			if (!hash.Contains(j))
			{
				hash.Add(j);
				break;
			}
		}		
	}
	
	return hash.Count();
}

//public int MaxEvents(int[][] events)
//{
//	if (events == null || events.Length == 0) return 0;
//	
//	events = events.OrderBy(x => x[0]).ToArray();
//
//	var heap = new SortedDictionary<int, int>();
//
//	var i = 0;
//	var cur = 1;
//	var res = 0;
//	while (i < events.Length || heap.Any())
//	{
//		while (i < events.Length && events[i][0] == cur) 
//		{
//			if (heap.ContainsKey(events[i][1])) heap[events[i][1]]++;
//			else heap.Add(events[i][1], 1);
//			
//			i++;
//		}
//
//		while (heap.Any() && heap.First().Key < cur) 
//		{
//			heap.Remove(heap.First().Key);
//		}
//
//		if (heap.Any()) 
//		{
//			var top = heap.First().Key;
//			res ++;
//
//			if (--heap[top] == 0) { heap.Remove(top);}
//		}
//		
//		cur++;
//	}
//	
//	return res;
//}