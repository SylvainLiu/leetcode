<Query Kind="Program" />

void Main()
{
	FindDuplicate(new int[] {1,3,4,2,2}).Dump();
}

public int FindDuplicate(int[] nums)
{
	if (nums.Length <= 1) return 0;
	
	var slow = 0;
	var fast = nums[0];
	while (slow != fast) 
	{
		slow = nums[slow];
		fast = nums[nums[fast]];
	}

	slow = 0;
	fast = nums[fast];
	while (slow != fast)
	{
		slow = nums[slow];
		fast = nums[fast];
	}
	
	return slow;
}


//public int FindDuplicate(int[] nums)
//{
//	var fast = nums[0];
//	var slow = nums[nums[0]];
//	while (slow != fast)
//	{
//		slow = nums[slow];
//		fast = nums[nums[fast]];
//	}
//
//	fast = nums[0];
//	while (slow != fast) 
//	{
//		slow = nums[slow];
//		fast = nums[fast];
//	}
//	
//	return fast;
//}