<Query Kind="Program" />

void Main()
{
	MaxPerformance(6, new int[] { 2, 10, 3, 1, 5, 8 }, new int[] {5,4,3,9,7,2}, 2);
}

// Define other methods and classes here
public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
{
	var ens = new int[speed.Length][];
	for (var i = 0; i < speed.Length; i++)
	{
		var en = new int[2];
		en[0] = efficiency[i];
		en[1] = speed[i];
		ens[i] = en;
	}
	ens = ens.OrderByDescending(x => x[0]).ToArray();

	var hash = new SortedDictionary<int, int>();
	var j = 0;
	long sum = 0;
	long max = 0;
	while (j < ens.Length)
	{
		sum += ens[j][1];
		
		if (hash.ContainsKey(ens[j][1])) hash[ens[j][1]]++;
		else hash.Add(ens[j][1], 1);

		if (j >= k) 
		{
			var key = hash.First().Key;
			if (--hash[key] == 0) hash.Remove(key);
			sum -= key;
		}
		
		max = Math.Max(max, sum * ens[j][0]);

		j++;
	}
	
	return (int) (max % (1000000000 + 7));
}