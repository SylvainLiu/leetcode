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

	var buckets = new int[max - min + 1];
	for (var i = 0; i < toSort.Length; i++)
	{
		buckets[toSort[i] - min]++;
	}

	var index = 0;
	for (var i = 0; i < buckets.Length; i++)
	{
		while (buckets[i] > 0) 
		{
			buckets[i]--;
			toSort[index++] = i + min;
		}
	}
	
	return toSort;
}