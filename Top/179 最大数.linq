<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public string LargestNumber(int[] nums)
{
	if (nums == null || nums.Length == 0) return string.Empty;

	var array = new string[nums.Length];
	for (var i = 0; i < nums.Length; i++)
	{
		array[i] = nums[i].ToString();
	}

	var enumerable = array.OrderBy(x => x, Comparer<string>.Create((x, y) => (y + x).CompareTo(x + y)));
	if (enumerable.FirstOrDefault() == "0") return "0";

	var res = "";
	foreach (var item in enumerable)
	{
		res += item;
	}

	return res;
}
