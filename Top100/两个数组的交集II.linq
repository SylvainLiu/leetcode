<Query Kind="Program" />

void Main()
{
	Intersect(new int[] {4,9,5}, new int[] {9, 4, 9, 8, 4}).Dump();
}

//public int[] Intersect(int[] nums1, int[] nums2)
//{
//	var dic1 = new Dictionary<int, int>();
//	var res = new List<int>();
//
//	foreach (var num in nums1)
//	{
//		if (dic1.ContainsKey(num)) { dic1[num]++; }
//		else { dic1.Add(num, 1); }
//	}
//	
//	foreach (var num in nums2)
//	{
//		if (!dic1.ContainsKey(num)) continue;
//
//		res.Add(num);
//		dic1[num]--;
//
//		if (dic1[num] == 0) {dic1.Remove(num);}
//	}
//
//	return res.ToArray();
//}

public int[] Intersect(int[] nums1, int[] nums2) 
{
	int i = 0, j = 0;
	var list = new List<int>();
	while(i < nums1.Length && j < nums2.Length)
	{
		if (nums1[i] > nums2[j]) { j++; continue;}
		if (nums1[i] < nums2[j]) { i++; continue;}

		list.Add(nums1[i]);
		i++;
		j++;
	}
	return list.ToArray();
}