<Query Kind="Program" />

void Main()
{	
	HammingDistance(1, 4).Dump();
}

public int HammingDistance(int x, int y)
{
	if (x < 0 || y < 0) return 0;

	var res = 0;
	var xor = x ^ y;
	while (xor != 0) 
	{
		if ((xor & 1) == 1) res++;
		xor >>= 1;
	}
	
	return res;
}

// Define other methods and classes here
//public int HammingDistance(int x, int y)
//{
//	if (x < 0 || y < 0) return 0;
//
//	var distance = 0;
//	var xor = x ^ y;
//	while (xor != 0)
//	{
//		if ((xor & 1) == 1) 
//		{
//			distance++;
//		}
//		
//		xor >>= 1;
//	}
//	
//	return distance;
//}