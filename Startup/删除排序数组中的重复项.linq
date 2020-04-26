<Query Kind="Program" />

void Main()
{
	RemoveDuplicates(new int[] {0,0,1,1,1,2,2,3,3,4}).Dump();
}

//public int RemoveDuplicates(int[] nums)
//{
//	if (nums.Length == 0) return 0;
//
//	var length = nums.Length;
//
//	for (var i = 0; i < length; i++)
//	{
//		var count = 0;
//		while (i + count < length && nums[i + count] == nums[i])
//		{
//			count++;
//		}
//		
//		for (var j = i + 1; j + count - 1 < length; j ++)
//		{
//			nums[j] = nums[j + count - 1];
//		}
//		
//		length = length - count + 1;
//	}
//
//	return length;
//}

public int RemoveDuplicates(int[] nums)
{
	if (nums.Length == 0) return 0;

	var i = 0;
	for (var j = 1; j < nums.Length; j++)
	{
		if (nums[i] != nums[j]) 
		{
			i++;
			nums[i] = nums[j];
		}
	}
	return i + 1;
}