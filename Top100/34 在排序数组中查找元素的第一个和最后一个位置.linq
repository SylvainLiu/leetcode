<Query Kind="Program" />

void Main()
{
	SearchRange(new int[] {2, 2}, 3).Dump();
}

public int[] SearchRange(int[] nums, int target)
{
	if (nums.Length == 0) return new int[] { -1, -1};
	
	var left = 0;
	var right = nums.Length - 1;
	while (left < right) 
	{
		var mid = left + (right - left) / 2;
		if (nums[mid] > target) 
		{
			right = mid - 1;
		}
		else if (nums[mid] < target) 
		{
			left = mid + 1;
		}
		else 
		{
			left = mid;
			right = mid;
			break;
		}
	}

	if (nums[left] != target) return new int[] {-1, -1};

	//不是lgN
	while (left >= 0)
	{
		if (nums[left] != target) break;
		left--;
	}
	while (right < nums.Length)
	{
		if (nums[right] != target) break;
		right++;
	}

	return new int[] { ++left, --right};
}


//public int[] SearchRange(int[] nums, int target)
//{
//	if (nums.Length == 0) return new int[] { -1, -1 };
//	SearchRange(nums, target, 0, nums.Length - 1);
//
//	if (min == int.MaxValue)
//	{
//		return new int[] { -1, -1 };
//	}
//	return new int[] { min, max };
//}
//
//public int max = int.MinValue;
//public int min = int.MaxValue;
//
//public void SearchRange(int[] nums, int target, int left, int right)
//{
//	if (left == right)
//	{
//		if (nums[left] == target)
//		{
//			max = Math.Max(max, left);
//			min = Math.Min(min, left);
//		}
//		return;
//	}
//	if (left > right) return;
//
//	var mid = left + (right - left) / 2;
//	SearchRange(nums, target, left, mid);
//	SearchRange(nums, target, mid + 1, right);
//}