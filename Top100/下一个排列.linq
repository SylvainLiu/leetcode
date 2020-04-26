<Query Kind="Program" />

void Main()
{
	NextPermutation(new int[] {1,5,1});
}

// Define other methods and classes here
public void NextPermutation(int[] nums)
{
	if (nums.Length == 0 || nums.Length == 1) return;

	var i = 0;
	for (i = nums.Length - 1; i >= 1; i--)
	{
		if (nums[i - 1] < nums[i]) 
		{
			i--;
			break;
		}
	}

	if (nums[i] < nums[i + 1]) 
	{
		var current = nums.Length - 1;
		while (nums[current] <= nums[i]) 
		{
			current--;
		}
		
		var temp = nums[i];
		nums[i] = nums[current];
		nums[current] = temp;
		
		i++;
	}

	var end = nums.Length - 1;
	while (i < end)
	{
		var temp = nums[i];
		nums[i] = nums[end];
		nums[end] = temp;
		
		i++;
		end--;
	}
		
	return;
}