<Query Kind="Program" />

void Main()
{
	
}

public int SingleNumber(int[] nums)
{
	var res = 0;
	for (var i = 0; i < nums.Length; i++) 
	{
		res ^= i;
	}
	return res;
}