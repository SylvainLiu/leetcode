<Query Kind="Program" />

void Main()
{
	WiggleSort(new int[] {3,2,1,1,3,2});
}

public void WiggleSort(int[] nums)
{
	if (nums == null || nums.Length < 2) return;
	
	var order = nums.OrderBy(x => x).ToArray();
	
	var mid = (nums.Length - 1) / 2;
	var left = mid;
	var right = mid + 1;
	for (var i = 0; i < nums.Length; i++)
	{
		if (i % 2 == 0) nums[i] = order[left--];
		else nums[i] = order[right--];
	}
}

// Define other methods and classes here
//public void WiggleSort(int[] nums)
//{
//	if (nums == null || nums.Length < 2) return;
//
//	var mid = (nums.Length - 1) / 2;
//	var index = 0;
//	var begin = 0;
//	var end = nums.Length - 1;
//	while (true)
//	{
//		var temp = nums[end];
//		var pivot = begin;
//		index = begin;
//
//		while (index < end)
//		{
//			if (nums[index] > temp)
//			{
//				index++;
//			}
//			else
//			{
//				var t = nums[index];
//				nums[index++] = nums[pivot];
//				nums[pivot++] = t;
//			}
//		}
//
//		var t1 = nums[end];
//		nums[end] = nums[pivot];
//		nums[pivot] = t1;
//
//		if (pivot > mid)
//		{
//			end = pivot - 1;
//		}
//		else if (pivot < mid)
//		{
//			begin = pivot + 1;
//		}
//		else break;
//	}
//
//	var left = 0;
//	var right = nums.Length - 1;
//	index = 0;
//	while ( index <= right)
//	{
//		if (nums[index] < nums[mid])
//		{
//			var t = nums[index];
//			nums[index++] = nums[left];
//			nums[left++] = t;
//		}
//		else if (nums[index] > nums[mid])
//		{
//			var t = nums[index];
//			nums[index] = nums[right];
//			nums[right--] = t;
//		}
//		else {index++;}
//	}
//
//	var array = nums.ToArray();
//	left = mid;
//	right = array.Length - 1;
//	for (var i = 0; i < array.Length; i++)
//	{
//		if (i % 2 == 0) nums[i] = array[left--];
//		else nums[i] = array[right--];
//	}
//}