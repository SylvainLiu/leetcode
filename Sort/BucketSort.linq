<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, -1, 13, 2, -1, -5, 12};
	CountingSort(toSort).Dump();
}

public int[] CountingSort(int[] toSort)
{
	var max = int.MinValue;
	var min = int.MaxValue;
	for (var i = 0; i < toSort.Length; i++)
	{
		max = Math.Max(toSort[i], max);
		min = Math.Min(toSort[i], min);
	}

	var size = 3;
	var count = (max - min + 1) / size + 1;
	var buckets = new List<int>[count];
	
	for (var i = 0; i < buckets.Length; i++) 
		buckets[i] = new List<int>();

	for (var i = 0; i < toSort.Length; i++) 
	{
		buckets[(toSort[i] - min + 1)/size].Add(toSort[i]);
	}

	var index = 0;
	for (var i = 0; i < buckets.Length; i++) 
	{
		buckets[i] = buckets[i].OrderBy(x => x).ToList();
		for (var j = 0; j < buckets[i].Count; j++) 
		{
			toSort[index++]	 = buckets[i][j];
		}
	}

	return toSort;
}