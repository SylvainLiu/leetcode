<Query Kind="Program" />

void Main()
{
	DecodeString("3[a]2[b4[F]c]").Dump();
}

public string DecodeString(string s)
{
	if (string.IsNullOrEmpty(s)) return string.Empty;
	
	var stack = new Stack<(int, string)>();
	var res = "";

	var current = 0;
	var times = 0;
	var words = "";
	while (current < s.Length) 
	{
		if (char.IsDigit(s[current])) times = 10 * times + s[current] - '0';
		else if (s[current] == '[') { stack.Push((times, words)); times = 0; words = ""; }
		else if (char.IsLetter(s[current])) words += s[current];
		else
		{
			var temp = "";
			var x = stack.Peek().Item1;
			while (x > 0)
			{
				temp += words;
				x--;
			}
			words = stack.Pop().Item2 + temp;
			if (!stack.Any()) { res += words; words = ""; }
		}
		current++;
	}
	
	return res + words;
}

//public string DecodeString(string s)
//{
//	if (string.IsNullOrEmpty(s)) return string.Empty;
//
//	var repeat = 0;
//	var result = "";
//	var stackR = new Stack<(int, string)>();
//	
//	for (var i = 0; i < s.Length; i++)
//	{
//		if (char.IsDigit(s[i])) 
//		{
//			repeat = repeat * 10 + s[i] - '0';
//		}
//		else if (char.IsLetter(s[i]))
//		{
//			result += s[i];
//		}
//		else if (s[i] == '[')
//		{
//			stackR.Push((repeat, result));
//			repeat = 0;
//			result = "";
//		}
//		else if (s[i] == ']')
//		{
//			var item = stackR.Pop();
//			result = item.Item2 + string.Concat(Enumerable.Repeat(result, item.Item1));
//		}
//	}
//	
//	return result;
//}