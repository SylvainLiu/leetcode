<Query Kind="Program" />

void Main()
{
	FractionToDecimal(7, -12).Dump();
}

// Define other methods and classes here
public string FractionToDecimal(int numerator, int denominator)
{
	if (denominator == 0) throw new Exception("");
	if (numerator == 0) return "0";
	
	var sym = "";
	if (numerator > 0 ^ denominator > 0) sym = "-";

	var up = numerator > 0 ? numerator : -(long)numerator;
	var down = denominator > 0 ? denominator : -(long)denominator;
	
	
	var integer = up / down;
	var num = up - integer * down;
	var hash = new Dictionary<long, int>();
	var index = 0;
	var repeatFrom = -1;
	var dec = "";

	while (num > 0) 
	{
		num *= 10;
		if (hash.ContainsKey(num))
		{
			repeatFrom = hash[num];
			break;
		}
		hash.Add(num, index);

		var digit = num / down;
		dec += digit;
		
		num = num - digit * down;
		if (num == 0) break;
		
		index++;
	}

	if (repeatFrom == -1)
	{
		if (dec == "") return sym + integer;
		else return sym + integer + "." + dec;
	}
	return sym + integer + "." + dec.Substring(0, repeatFrom) + "(" + dec.Substring(repeatFrom, dec.Length - repeatFrom) + ")";
}