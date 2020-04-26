<Query Kind="Program" />

void Main()
{
	PlusOne(new int[] {9,9}).Dump();
}

public int[] PlusOne(int[] digits)
{
	if (digits[0] == 0)
	{
		digits[0] = 1;
		return digits;
	}

	var index = digits.Length - 1;
	while (index >= 0)
	{
		if (digits[index] != 9) 
		{
			digits[index--]++;
			break;
		}
		
		digits[index--] = 0;
	}

	if (digits[0] == 0)
	{
		var res = new int[digits.Length + 1];
		res[0] = 1;
		return res;
	}
	
	return digits;
}

//public int[] PlusOne(int[] digits)
//{
//	if (digits[0] == 0) 
//	{
//		digits[0] = 1;
//		return digits;
//	}
//
//	var index = digits.Length - 1;
//	long res = 0; 
//	for (var i = 0; i < digits.Length; i++) 
//	{
//		res += (long)Math.Pow(10, index--) * digits[i];
//	}
//	
//	res += 1;
//	
//	return res.ToString().Select(x => int.Parse(x.ToString())).ToArray();
//}