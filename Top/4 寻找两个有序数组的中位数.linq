<Query Kind="Program" />

void Main()
{
}

public double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
	var length = nums1.Length + nums2.Length;
	var left = FindMedianSortedArrays(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, (length + 1) / 2);
	var right = FindMedianSortedArrays(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, (length + 2) / 2);

	return (left + right) / 2;
}

public double FindMedianSortedArrays(int[] nums1, int s1, int e1, int[] nums2, int s2, int e2, int target)
{
	var l1 = e1 - s1 + 1;
	var l2 = e2 - s2 + 1;

	if (l1 == 0) return nums2[s2 + target - 1];
	if (l2 == 0) return nums1[s1 + target - 1];

	if (target == 1) return Math.Min(nums1[s1], nums2[s2]);

	var mid1 = s1 + Math.Min(l1, target / 2) - 1;
	var mid2 = s2 + Math.Min(l2, target / 2) - 1;

	if (nums1[mid1] < nums2[mid2])
	{
		return FindMedianSortedArrays(nums1, mid1 + 1, e1, nums2, s2, e2, target - (mid1 - s1 + 1));
	}
	else
	{
		return FindMedianSortedArrays(nums1, s1, e1, nums2, mid2 + 1, e2, target - (mid2 - s2 + 1));
	}
}