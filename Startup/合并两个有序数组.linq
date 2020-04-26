<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public void Merge(int[] nums1, int m, int[] nums2, int n)
{
	if (n == 0) { return; }

	var index1 = m - 1;
	var index2 = n - 1;
	var cur = m + n - 1;

	while (index1 >= 0 && index2 >= 0)
	{
		if (nums1[index1] >= nums2[index2])
		{
			nums1[cur] = nums1[index1];
			index1--;
			cur--;
		}
		else
		{
			nums1[cur] = nums2[index2];
			index2--;
			cur--;
		}
	}

	if (index1 < 0)
	{
		while (index2 >= 0)
		{
			nums1[cur] = nums2[index2];
			index2--;
			cur--;
		}
	}
	else if (index2 < 0)
	{
		while (index1 >= 0)
		{
			nums1[cur] = nums1[index1];
			index1--;
			cur--;
		}
	}
}