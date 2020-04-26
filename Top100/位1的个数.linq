<Query Kind="Program" />

void Main()
{
	HammingWeight(1);
}

public int HammingWeight(uint n)
{
	var count = 0;
	while (n != 0)
	{
		if ( (n & 1) == 1) 
		{
			count++;
		}
		n >>= 1;
	}
	return count;
}


// Define other methods and classes here
//public int HammingWeight(uint n)
//{
//	var bits = Convert.ToString(n, 2);
//
//	var index = 0;
//	var count = 0;
//	while (index < bits.Length)
//	{
//		if (bits[index] == '1') 
//		{
//			count ++;
//		}
//		index ++;
//	}
//	
//	return count;
//}