<Query Kind="Program" />

void Main()
{
	var res = TwoSum(new int[] {3, 2, 3}, 6).Dump();
}

public int[] TwoSum(int[] nums, int target)
{
	if (nums.Length == 2) return new int[] {0,1};

	var dic = new Dictionary<int, int>();
	for (var i = 0; i < nums.Length; i++) 
	{
		var diff = target - nums[i];
		if (dic.ContainsKey(diff))
		{
			return new int[] {i, dic[diff]};
		}
		
		if (dic.ContainsKey(nums[i])) continue;
		
		dic.Add(nums[i], i);
	}
	
	throw new Exception();
}

//
//public int[] TwoSum(int[] nums, int target)
//{
//	if (nums.Length == 2) return new int[] {0,1};
//
//	var pos = Enumerable.Range(0, nums.Length).ToDictionary(x=>x, y=>y);
//		
//	for (var i = 0; i < nums.Length; i++)
//		for (var j = i + 1; j < nums.Length; j++) 
//		{
//			if (nums[i] < nums[j]) continue;
//			
//			var temp = nums[i];
//			nums[i] = nums[j];
//			nums[j] = temp;
//			
//			temp = pos[i];
//			pos[i] = pos[j];
//			pos[j] = temp;
//		}
//
//	var res = new int[2];
//	
//	Solve(nums, 0, nums.Length - 1, target, res);
//	
//	res[0] = pos[res[0]];
//	res[1] = pos[res[1]];
//
//	if (res[0] > res[1]) 
//	{
//		var temp = res[0];
//		res[0] = res[1];
//		res[1] = temp;
//	}
//	
//	return res;
//}
//
//bool Solve(int[] nums, int left, int right, int target, int[] res)
//{
//	while (right > left)
//	{
//		if (nums[left] + nums[right] == target)
//		{
//			res[0] = left;
//			res[1] = right;
//			return true;
//		}
//		else if (nums[left] + nums[right] > target)
//		{
//			if(Solve(nums, left, right - 1, target, res))
//				return true;
//		}
//		else 
//		{
//			if(Solve(nums, left + 1, right, target, res))
//				return true;
//		}
//			
//		left++;
//		right--;
//	}
//	
//	return false;
//}