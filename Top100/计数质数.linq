<Query Kind="Program" />

void Main()
{
	CountPrimes(10).Dump();
}

// Define other methods and classes here
public int CountPrimes(int n)
{
	if (n <= 2) return 0;

	var array = new Byte[n];
	var count = 0;
	for (var i = 2; i < n; i++)
	{
		if (array[i] == 0) 
		{
			count++;
			for (var j = i + i; j < n; j += i) 
			{
				array[j] = 1;
			}
		}
	}
	
	return count;
}