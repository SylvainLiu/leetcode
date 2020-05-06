<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	QuickSort(toSort).Dump();
}

public int[] QuickSort(int[] toSort)
{
	QuickSort(toSort, 0, toSort.Length - 1);
	return toSort;
}

public void QuickSort(int[] toSort, int begin, int end) 
{
	if (begin >= end) return;

	void Swap(int x, int y) 
	{
		var temp = toSort[x];
		toSort[x] = toSort[y];
		toSort[y] = temp;
	}
	
	var pivot = begin;
	var index = pivot + 1;
	for (var i = index; i <= end; i++)
	{
		if (toSort[i] < toSort[pivot])
			Swap(index++, i);
	}
	
	var partition = index - 1;
	Swap(pivot, partition);

	QuickSort(toSort, begin, partition - 1);
	QuickSort(toSort, partition + 1, end);
}