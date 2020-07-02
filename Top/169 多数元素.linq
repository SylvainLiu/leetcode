<Query Kind="Program" />

void Main()
{
	var res = MajorityElement(new int[]{3, 2 ,3}).Dump();
}

public int MajorityElement(int[] nums) 
{
	return nums.OrderBy(x => x).Skip(nums.Length/2).First();
}

//public int MajorityElement(int[] nums)
//{	
//	var res = new Dictionary<int, int>();
//	var max = 0;
//	var key = 0;
//	
//	for ( var i = 0; i< nums.Length; i++)
//	{
//		if (res.ContainsKey(nums[i])) { res[nums[i]]++; }
//		else { res.Add(nums[i], 1);}
//
//		if (max < res[nums[i]])
//		{
//			max = res[nums[i]];
//			key = nums[i];
//			
//			if (max > Math.Ceiling((double)nums.Length/2)) break;
//		}
//	}
//	
//	return key;
//}
//
//public int MajorityElement(int[] nums)
//{
//	return nums.OrderBy(x => x).Skip(nums.Length/2).First();
//}