<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int EvalRPN(string[] tokens)
{
	if (tokens == null || tokens.Length == 0) return 0;
	
	var stack = new Stack<long>();
	var index = 0;
	while (index < tokens.Length) 
	{
		var cur = tokens[index];
		if (cur == "+" || cur == "*" || cur == "-" || cur == "/")
		{
			var second = stack.Pop();
			var first = stack.Pop();
			switch (cur)
			{
				case "+": stack.Push(first + second); break;
				case "-": stack.Push(first - second); break;
				case "*": stack.Push(first * second); break;
				case "/": stack.Push(first / second); break;
			}
		}
		else
		{
			stack.Push(long.Parse(cur));
		}		
	}
	
	return (int)stack.Pop();
}