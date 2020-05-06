<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	InsertionSort(toSort).Dump();
}

public int[] InsertionSort(int[] toSort)
{
	for (var i = 1; i < toSort.Length; i++)
	{
		var toInsert = toSort[i];
		var index = i;
		while (index > 0 && toInsert < toSort[index - 1])
		{
			toSort[index] = toSort[--index];
		}
		
		toSort[index] = toInsert;
	}
	return toSort;
}