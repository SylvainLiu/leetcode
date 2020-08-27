<Query Kind="Program" />

void Main()
{
	var res = MajorityElement(new int[]{3, 2 ,3}).Dump();
}

//public int MajorityElement(int[] nums) 
//{
//	return nums.OrderBy(x => x).Skip(nums.Length/2).First();
//}

public int MajorityElement(int[] nums)
{	
	var res = new Dictionary<int, int>();
	
	for ( var i = 0; i< nums.Length; i++)
	{
		if (res.ContainsKey(nums[i])) { res[nums[i]]++; }
		else { res.Add(nums[i], 1);}

		if (res[nums[i]] > nums.Length / 2)
		{
			return nums[i];
		}
	}
	
	throw new Exception("No such element");
}