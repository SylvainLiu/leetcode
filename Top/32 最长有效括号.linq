<Query Kind="Program" />

void Main()
{
	LongestValidParentheses("(()(((()").Dump();
}

public int LongestValidParentheses(string s)
{
	if (string.IsNullOrEmpty(s)) return 0;

	var stack = new Stack<int>();
	stack.Push(-1);

	var index = 0;
	var max = 0;
	while (index < s.Length)
	{
		if (s[index] == '(') 
		{
			stack.Push(index);
		}
		else 
		{
			stack.Pop();
			
			if (!stack.Any()) 
			{
				stack.Push(index);
			}
			else 
			{
				max = Math.Max(max, index - stack.Peek());
			}
		}
		
		index++;
	}
	
	return max;
}