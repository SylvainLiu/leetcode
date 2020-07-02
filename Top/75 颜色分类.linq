<Query Kind="Program" />

void Main()
{
	SortColors(new int[] {2, 0 ,2, 1, 1, 0});
}

public void SortColors(int[] nums)
{
	if (nums.Length <= 1) return;
	
	var left = 0;
	var right = nums.Length - 1;
	var current = 0;
	while (current <= right)
	{
		if (nums[current] == 0) Swap(nums, current++, left++);
		else if (nums[current] == 2) Swap(nums, current, right--);
		else { current++; continue; }
	}
	
	nums.Dump();
}

public void Swap(int[] nums, int i1, int i2) 
{
	if (i1 == i2) return;
	
	var temp = nums[i1];
	nums[i1] = nums[i2];
	nums[i2] = temp;
}
//因为curr左边的值已经扫描过了，所以curr要++继续扫描下一位，而与p2交换的值，curr未扫描，要停下来扫描一下，所以curr不用++。