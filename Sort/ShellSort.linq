<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	ShellSort(toSort).Dump();
}

public int[] ShellSort(int[] toSort)
{
	var gap = 1;
	while (gap < toSort.Length / 3) 
	{
		gap = gap * 3 + 1;
	}

	while (gap > 0)
	{
		for (var i = gap; i < toSort.Length; i++)
		{
			var toInsert = toSort[i];
			var j = i;
			while (j >= gap && toInsert < toSort[j - gap])
			{
				toSort[j] = toSort[j - gap];
				j -= gap;
			}
			toSort[j] = toInsert;
		}
		gap = (int) (gap / 3);
	}
	
	return toSort;
}