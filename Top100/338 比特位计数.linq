<Query Kind="Program" />

void Main()
{
	CountBits(5).Dump();
}

public int[] CountBits(int num)
{
	var res = new int[num + 1];
	res[0] = 0;
	if (num == 0) return res;

	var cur = 1;
	var count = 1;
	while(cur <= num)
	{
		for (var i = 1; i <= count && cur <= num ; i++, cur++) 
		{
			res[cur] = res[cur - count] + 1;
		}
		count <<= 1;
	}
	
	return res;
}

// Define other methods and classes here
//public int[] CountBits(int num)
//{
//	var i = 0;
//	var b = 1;
//	var res = new int[num + 1];
//	res[0] = 0;
//	while (b < num + 1)
//	{
//		while (i < b && (i + b < num + 1))
//		{
//			res[i + b] = res[i] + 1;
//			i++;
//		}
//		
//		i = 0;
//		b <<= 1;
//	}
//	
//	return res;
//}