<Query Kind="Program" />

void Main()
{
	SmallestRepunitDivByK(3).Dump();
}

// Define other methods and classes here
public int SmallestRepunitDivByK(int K)
{
	if (K <= 0) return -1;
	
	var length = 1;
	var hash = new HashSet<int>();
	var cur = 1;
	while (true)
	{
		if (cur == K) return length;
		
		if (cur > K)
		{
			cur = cur % K;
			if (!hash.Add(cur)) return -1;
			if (cur == 0) return length;
		}
		
		cur = cur * 10 + 1;
		length++;
	}
}