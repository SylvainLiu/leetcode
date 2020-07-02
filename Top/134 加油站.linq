<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int CanCompleteCircuit(int[] gas, int[] cost)
{
	var sum = new int[gas.Length];
	var total = 0;

	for (var i = 0; i < sum.Length; i++)
	{
		sum[i] = gas[i] - cost[i];
		total += sum[i];
	}
		
	if (total < 0) return -1;
	
	var start = 0;
	total = 0;
	for (var i = 0; i < sum.Length; i++)
	{
		total += sum[i];
		if (total < 0) 
		{
			start = i + 1;
			total = 0;
		}
	}
	
	return start;
}