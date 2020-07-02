<Query Kind="Program" />

void Main()
{
	Calculate("3+2*2").Dump();
}

public int Calculate(string s)
{
	var stack = new Stack<int>();
	var lastOp = '+';
	
	for (var i = 0; i < s.Length; i++) 
	{
		if (s[i] == ' ') continue;

		if (char.IsDigit(s[i]))
		{
			var num = 0;
			while (i < s.Length && char.IsDigit(s[i])) 
			{
				num = num * 10 + s[i++] - '0';
			}
			i--;

			if (lastOp == '+') stack.Push(num);
			else if (lastOp == '-') stack.Push(-num);
			else if (lastOp == '*') stack.Push(stack.Pop() * num);
			else if (lastOp == '+') stack.Push(stack.Pop() / num);
		}
		else 
		{
			lastOp = s[i];
		}
	}

	var res = 0;
	while (stack.Any()) 
	{
		res += stack.Pop();
	}
	
	return res;
}

// Define other methods and classes here
//public int Calculate(string s)
//{
//	var op = '+';
//	var num = 0;
//	var res = 0;
//	var cur = 0;
//	for (var i = 0; i < s.Length; i++)
//	{
//		if (char.IsDigit(s[i]))
//		{
//			num = 10 * num + s[i] - '0';
//		}
//		if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/' || i == s.Length - 1)
//		{
//			switch (op)
//			{
//				case '+': cur += num; break;
//				case '-': cur -= num; break;
//				case '*': cur *= num; break;
//				case '/': cur /= num; break;
//			}
//			if (s[i] == '+' || s[i] == '-' || i == s.Length - 1) 
//			{
//				res += cur;
//				cur = 0;
//			}
//			op = s[i];
//			num = 0;
//		}
//	}
//	
//	return res;
//}