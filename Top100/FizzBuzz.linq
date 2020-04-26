<Query Kind="Program" />

void Main()
{
	FizzBuzz(1).Dump();
	FizzBuzz(15).Dump();
}

// Define other methods and classes here
public IList<string> FizzBuzz(int n)
{
	var res = new List<string>();
	for (var i = 1; i < n + 1; i++ )
	{
		var temp = "";
		if (i % 3 == 0) temp += "Fizz";
		if (i % 5 == 0) temp += "Buzz";
		
		if (i % 3 != 0 && i % 5 != 0) temp = i.ToString();
		res.Add(temp);
	}
	return res;
}