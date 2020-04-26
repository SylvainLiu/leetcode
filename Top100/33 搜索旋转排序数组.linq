<Query Kind="Program" />

void Main()
{
	Search(new int[] {3, 1}, 1).Dump();
}

public int Search(int[] nums, int target)
{
	if (nums.Length == 0) return -1;
	return Search(nums, 0, nums.Length - 1, target);
}

public int Search(int[] nums, int left, int right, int target)
{
	if (left == right) return nums[left] == target ? left : -1;

	var mid = left + (right - left) / 2;
	if (nums[left] <= nums[mid]) 
	{
		if (target >= nums[left] && target <= nums[mid])
			return Search(nums, left, mid, target);
		return Search(nums, mid + 1, right, target);
	}

	if (target >= nums[mid + 1] && target <= nums[right])
		return Search(nums, mid + 1, right, target);
	return Search(nums, left, mid, target);
}

//public int Search(int[] nums, int target)
//{
//	if (nums.Length == 0) return -1;	
//	return Search(nums, target, 0, nums.Length - 1);
//}
//
//public int Search(int[] nums, int target, int left, int right)
//{
//	if (left == right) return nums[left] == target ? left : -1;
//	if (left > right) return -1;
//
//	var mid = left + (right - left) / 2;
//	if (nums[mid] == target) return mid;
//
//	if (nums[left] <= nums[mid])
//	{
//		if (nums[left] <= target && nums[mid] > target) return Search(nums, target, left, mid - 1);
//		else return Search(nums, target, mid + 1, right);
//	}
//	else
//	{
//		if (nums[mid] < target && nums[right] >= target) return Search(nums, target, mid + 1, right);
//		else return Search(nums, target, left, mid - 1);
//	}
//}