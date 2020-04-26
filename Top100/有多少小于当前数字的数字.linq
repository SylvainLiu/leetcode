<Query Kind="Program" />

void Main()
{
	var test = SmallerNumbersThanCurrent(new int[] {37,64,63,2,41,78,51,36,2,20,25,41,72,100,17,43,54,27,34,86,12,48,70,44,87,68,62,98,68,30,8,92,5,10});
}

//public int[] SmallerNumbersThanCurrent(int[] nums)
//{
//	var pos = Enumerable.Range(0, nums.Length).ToArray();
//	
//	for (var i = 0 ; i < nums.Length ; i++)
//	{
//		for (var j = i+1; j < nums.Length; j++)
//		{
//			if ( nums[j] > nums[i]) continue;
//			
//			var temp = nums[i];
//			nums[i] = nums[j];
//			nums[j] = temp;
//			
//			var temp2 = pos[i];
//			pos[i] = pos[j];
//			pos[j] = temp2;
//		}
//	}
//
//	var res = Enumerable.Range(0, nums.Length).ToArray();
//	for (var i = 0; i < pos.Length; i++) 
//	{
//		if (i > 0 && nums[i-1] == nums[i]){
//			res[pos[i]] = res[pos[i-1]];
//			continue;
//		}
//		
//		res[pos[i]] = i;
//	}
//	
//	return res;
//}

public int[] SmallerNumbersThanCurrent(int[] nums)
{
	if (nums.Length == 0) return nums;

	var cnt = Enumerable.Repeat(0, 101).ToArray();
	var res = Enumerable.Repeat(0, nums.Length).ToArray();
	for (var i = 0; i < nums.Length; i++)
	{
		cnt[nums[i]]++;
	}

	for (var i = 1; i < cnt.Length; i++)
	{
		cnt[i] += cnt[i - 1];
	}

	for (var i = 0; i < nums.Length; i++)
	{
		if (nums[i] != 0)
		{
			res[i] = cnt[nums[i] - 1];
		}
	}

	return res;
}