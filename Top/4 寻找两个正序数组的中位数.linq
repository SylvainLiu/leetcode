<Query Kind="Program" />

void Main()
{
}

// Define other methods and classes here
public double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
	//Boundry

	var length = nums1.Length + nums2.Length;
	if (length % 2 == 1) 
	{
		return FindMedianSortedArrays(nums1, 0, nums2, 0, (length + 1) / 2);
	}
	else
	{
		var left = FindMedianSortedArrays(nums1, 0, nums2, 0, length / 2);
		var right = FindMedianSortedArrays(nums1, 0, nums2, 0, length / 2 + 1);
		return (left + right) / 2;
	}
}

public double FindMedianSortedArrays(int[] nums1, int s1, int[] nums2, int s2, int target) 
{
	if (s1 == nums1.Length) 
	{
		return nums2[s2 + target - 1];
	}
	if (s2 == nums2.Length)
	{
		return nums1[s1 + target - 1];
	}
	
	if (target == 1) return Math.Min(nums2[s2], nums1[s1]);

	var mid1 = Math.Min(nums1.Length - 1, s1 + target / 2 - 1);
	var mid2 = Math.Min(nums2.Length - 1, s2 + target / 2 - 1);
	if (nums1[mid1] < nums2[mid2])
	{
		return FindMedianSortedArrays(nums1, mid1 + 1, nums2, s2, target - (mid1 - s1 + 1));
	}
	else
	{
		return FindMedianSortedArrays(nums1, s1, nums2, mid2, target - (mid2 - s2 + 1));
	}
}