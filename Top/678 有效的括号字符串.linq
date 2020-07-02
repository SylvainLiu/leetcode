<Query Kind="Program" />

void Main()
{
	CheckValidString("**").Dump();
}

// Define other methods and classes here
public bool CheckValidString(string s)
{
	if (string.IsNullOrEmpty(s)) return false;

	var left = new Stack<int>();
	var star = new Stack<int>();

	for (var i = 0; i < s.Length; i++)
	{
		if (s[i] == ')')
		{
			if (left.Any()) left.Pop();
			else if (star.Any()) star.Pop();
			else return false;
		}
		else if (s[i] == '(') left.Push(i);
		else if (s[i] == '*') star.Push(i);
	}

	while (left.Any() && star.Any())
	{
		var l = left.Pop();
		var st = star.Pop();
		
		if (l > st) return false;
	}
	
	return !left.Any();
}