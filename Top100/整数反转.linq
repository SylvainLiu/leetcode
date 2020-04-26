<Query Kind="Program" />

void Main()
{
	Reverse(-2147483648).Dump();
}

public int Reverse(int x)
{
	var res = 0;
	while (x != 0) 
	{
		var digit = x % 10;
		x = x/10;

		if (res > int.MaxValue/10) return 0;
		if (res < int.MinValue/10) return 0;
		
		res = res * 10 + digit;
	}
	
	return res;
}

//public int Reverse(int x)
//{
//	if (x == 0) return 0;
//	if (x == int.MinValue) return 0;
//	
//	var sign = x < 0 ? -1 : 1;
//	x = Math.Abs(x);
//	long res = 0;
//	var length = x.ToString().Length;
//	var current = length;
//
//	while (current > 0)
//	{
//		var power = (int)Math.Pow(10, current - 1);
//		var digit = x / power;
//		x -= digit * power;
//		res += (long)(digit * Math.Pow(10, length - current));
//		current--;
//	}
//
//	if (res > int.MaxValue) return 0;
//
//	return (int)res * sign;
//}