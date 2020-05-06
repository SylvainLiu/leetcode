<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	HeapSort(toSort).Dump();
}

public int[] HeapSort(int[] toSort)
{
	for (var i = toSort.Length / 2 - 1; i >= 0; i--) 
	{
		Ajust(toSort, i, toSort.Length);
	}

	for (var i = toSort.Length - 1; i > 0; i--) 
	{
		var temp = toSort[0];
		toSort[0] = toSort[i];
		toSort[i] = temp;
		
		Ajust(toSort, 0, i);
	}
	
	return toSort;
}

public void Ajust(int[] toSort, int i, int length)
{
	var val = toSort[i];
	var child = 0;
	while (i * 2 + 1 < length)
	{
		child = 2 * i + 1;
		if (child + 1 < length && toSort[child + 1] > toSort[child]) child++;

		if (toSort[child] > val) 
		{
			toSort[i] = toSort[child];
			i = child;
		}
		else break;
	}
	
	toSort[i] = val;
}