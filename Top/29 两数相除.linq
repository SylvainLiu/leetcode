<Query Kind="Program" />

void Main()
{
	var a = int.MinValue;
	var b = -a;
	Divide(int.MinValue, 2);
}

// Define other methods and classes here
public int Divide(int dividend, int divisor)
{
	if (divisor == 0)
		throw new Exception("divisor cannot be 0");

	if (dividend == 0) return 0;
	if (divisor == 1) return dividend;
	if (divisor == -1)
	{
		if (dividend == int.MinValue) return int.MaxValue;
		else return -dividend;
	}

	var sign = 1;
	if (dividend > 0 ^ divisor > 0) sign = -1;
	var dividendL = dividend < 0 ? -(long)dividend : dividend;
	var divisorL = divisor < 0 ? -(long)divisor : divisor;

	var res = 0;
	var factor = 1;

	while (factor > 0)
	{
		if (dividendL >= factor * divisorL)
		{
			dividendL -= factor * divisorL;
			res += factor;
			factor *= 2;

			if (dividendL == 0) break;
		}
		else
		{
			factor /= 2;
		}
	}

	return res * sign;
}