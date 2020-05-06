<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	BubbleSort(toSort).Dump();
}

public int[] BubbleSort(int[] toSort)
{
	var swaped = false;
	for (var i = 0; i < toSort.Length; i++)
	{
		swaped = false;
		for (var j = 0; j < toSort.Length - i - 1; j++)
		{
			if (toSort[j] > toSort[j + 1])
			{
				var temp = toSort[j];
				toSort[j] = toSort[j + 1];
				toSort[j + 1] = temp;
				swaped = true;
			}
		}
		if (!swaped) break;
	}
	return toSort;
}