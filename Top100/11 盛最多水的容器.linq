<Query Kind="Program" />

void Main()
{
	
}

public int MaxArea(int[] height)
{
	if (height.Length <= 2) return 0;

	int left = 0, right = height.Length - 1, res = 0;
	while (left < right) 
	{
		res = Math.Max(res, Math.Min(height[left], height[right]) * (right - left));
		if (height[left] < height[right]) left++;
		else right--;
	}
	return res;
}