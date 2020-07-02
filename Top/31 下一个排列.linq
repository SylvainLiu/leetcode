<Query Kind="Program" />

void Main()
{
	NextPermutation(new int[] {1,3, 2});
}

public void NextPermutation(int[] nums)
{
	if (nums.Length <= 1) return;

	var i = nums.Length - 2;
	while (i >= 0)
	{
		if (nums[i] < nums[i + 1]) break;
		i--;
	}

	void Swap(int a, int b)
	{
		var temp = nums[a];
		nums[a] = nums[b];
		nums[b] = temp;
	}

	for (var j = nums.Length - 1; j > i; j--)
	{
		if (nums[j] > nums[i]) { Swap(i, j); i++ ; break;}
	}

	var end = nums.Length - 1;
	for (var j = i + 1; j < end; j++)
		Swap(j, end--);
}