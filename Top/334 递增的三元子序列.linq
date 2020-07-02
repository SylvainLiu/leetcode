<Query Kind="Program" />

void Main()
{
	IncreasingTriplet(new int[] {2,1,5,0,4,6}).Dump();
}

// Define other methods and classes here
public bool IncreasingTriplet(int[] nums)
{
	if (nums == null || nums.Length < 3) return false;

	var list = new List<int>();
	for (var i = 0; i < nums.Length; i++)
	{
		var temp = nums[i];
		var index = list.Count() - 1;
		
		while (index >= 0)
		{
			if (temp > list[index]) break;
			index--;
		}

		if (index == list.Count() - 1) 
		{
			list.Add(temp);
			if (list.Count() == 3) return true;
		}
		else 
		{
			list[index + 1] = temp;
		}
	}

	return false;
}