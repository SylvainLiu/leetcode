<Query Kind="Program" />

void Main()
{
	DailyTemperatures(new int[] {73,74,75,71,69,72,76,7}).Dump();
}

public int[] DailyTemperatures(int[] T)
{
	var res = new int[T.Length];
	if (T.Length == 0) return res;
	
	var stack = new Stack<int>();
	for (var i = 0; i < T.Length; i++)
	{
		while (stack.Any() && T[i] > T[stack.Peek()])
		{
			res[stack.Peek()] = i - stack.Pop();
		}
		stack.Push(i);
	}
	
	return res;
}