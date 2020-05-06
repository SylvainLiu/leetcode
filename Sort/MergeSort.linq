<Query Kind="Program" />

void Main()
{
	var toSort = new int[] {5, 0, 1, 13, 7, 9, 10, -32, 56, 2, -1, -5, 12};
	MergeSort(toSort).Dump();
}

public int[] MergeSort(int[] toSort) 
{
	for (var step = 1; step < toSort.Length; step <<= 1) 
	{
		for (var index = 0; index < toSort.Length; index += (step * 2))
		{
			MergeSort(toSort, index, Math.Min(index + step, toSort.Length - 1), Math.Min(index + step * 2 - 1, toSort.Length - 1));
		}
	}
	return toSort;
}

public void MergeSort(int[] toSort, int left, int mid, int right) 
{
	var temp = new int[right - left + 1];
	var current = 0;
	var r = mid;
	var l = left;
	while (l <= mid - 1 && r <= right)
	{
		if (toSort[l] < toSort[r]) 
		{
			temp[current] = toSort[l++];
		}
		else
		{
			temp[current] = toSort[r++];
		}
		current++;
	}
	var rest = l == mid ? r : l;
	while (current < temp.Length) 
	{
		temp[current++] = toSort[rest++];
	}
	for (var i = 0; i < temp.Length; i++) 
	{
		toSort[i + left] = temp[i];
	}
}

//public int[] MergeSort(int[] toSort)
//{
//	return MergeSort(toSort, 0, toSort.Length - 1);
//}
//
//public int[] MergeSort(int[] toSort, int left, int right) 
//{
//	if (left == right)
//	{
//		return new int[] {toSort[left]};
//	}
//
//	var mid = left + (right - left) / 2;
//	var lArray = MergeSort(toSort, left, mid);
//	var rArray = MergeSort(toSort, mid + 1, right);
//	
//	var res = new int[lArray.Length + rArray.Length];
//	var current = 0;
//	var l = 0;
//	var r = 0;
//	while (l < lArray.Length && r < rArray.Length)
//	{
//		if (lArray[l] < rArray[r]) 
//		{
//			res[current] = lArray[l];
//			l++;
//		}
//		else
//		{
//			res[current] = rArray[r];
//			r++;
//		}
//		current++;
//	}
//	var rest = l == lArray.Length ? rArray : lArray;
//	var index = l == lArray.Length ? r : l;
//	while (index < rest.Length)
//	{
//		res[current] = rest[index];
//		index++;
//		current++;
//	}
//	
//	return res;
//}