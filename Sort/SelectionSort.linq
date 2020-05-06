<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	SelectionSort(toSort).Dump();
}

public int[] SelectionSort(int[] toSort)
{
	for (var i = 0; i < toSort.Length; i++)
	{
		var min = i;
		for (var j = i; j < toSort.Length; j++)
		{
			min = toSort[j] < toSort[min] ? j : min;
		}
		
		var temp = toSort[i];
		toSort[i] = toSort[min];
		toSort[min] = temp;
	}
	return toSort;
}