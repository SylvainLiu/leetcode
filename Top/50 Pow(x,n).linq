<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public double MyPow(double x, int n) 
{
	if (n == 0) return 1;

	var m = (long)n;
	if (n < 0)
	{
		x = 1 / x;
		m = -m;
	}
	
	var cur = x;
	var res = 1.0;

	while (m > 0)
	{
		if (m % 2 == 1) res *= cur;
		
		cur *= cur;
		m >>= 1;
	}
	
	return res;
}

//public double MyPow(double x, int n)
//{
//	if (n == 0) return 1;
//	
//	if (n < 0)
//		return Power(1/x, -(long)n);
//	
//	return Power(x, n);
//}
//
//public double Power(double x, long n) 
//{
//	if (n == 0) return 1;
//
//	var temp = Power(x, n / 2);	
//	if (n % 2 == 1) return x * temp * temp;	
//	return temp * temp;
//}