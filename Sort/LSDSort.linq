<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, 56, 13, 2, 12};
	CountingSort(toSort).Dump();
}

public int[] CountingSort(int[] toSort)
{
	var maxbit = 2;
	
	var buckets = new List<int>[10];
	for (var i = 0; i < buckets.Length; i++) 
		buckets[i] = new List<int>();

	var bit = 1;
	var mod = 10;
	
	while (bit < 100)
	{
		for (var i = 0; i < toSort.Length; i++) 
		{
			buckets[(toSort[i] % mod)/bit].Add(toSort[i]);
		}

		var index = 0;
		for (var i = 0; i < buckets.Length; i++)
		{
			while (buckets[i].Count > 0) 
			{
				toSort[index++] = buckets[i].First();
				buckets[i].RemoveAt(0);
			}
		}
		
		bit *= 10;
		mod *= 10;
	}

	return toSort;
}