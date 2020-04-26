<Query Kind="Program" />

void Main()
{
	IsValid("([])").Dump();
}

// Define other methods and classes here
public bool IsValid(string s)
{
	if (string.IsNullOrEmpty(s)) return true;

	var dic = new Dictionary<char, int>
	{
		{'{', 1},
		{'[', 2},
		{'(', 3},
		{')', 4},
		{']', 5},
		{'}', 6}
	};
	
	if (dic[s[0]] > 3) return false;

	var stack = new Stack<char>();
	stack.Push(s[0]);
	
	var index = 1;
	while (index < s.Length)
	{
		if (dic[s[index]] <= 3)
		{
			stack.Push(s[index]);
		}
		else 
		{
			if (dic[stack.Peek()] + dic[s[index]] != 7) {return false;}
			stack.Pop();
		}
		
		index ++;
	}
	
	return true;
}