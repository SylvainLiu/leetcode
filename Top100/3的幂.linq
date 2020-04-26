<Query Kind="Program" />

void Main()
{
	
}

public bool IsPowerOfThree(int n)
{
	if (n <= 0) return false;

	var res = Math.Log10(n)/ Math.Log10(3);
	return res- (int)res < double.Epsilon;
}

// Define other methods and classes here
//public bool IsPowerOfThree(int n)
//{
//	while (n != 1)
//	{
//		if (n % 3 == 0) 
//		{
//			n /= 3;
//		}
//		else 
//		{
//			return false;
//		}
//	}
//	
//	return true;
//}