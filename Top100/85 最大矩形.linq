<Query Kind="Program" />

void Main()
{
	var matrix = new string[][] { new[] { "1", "0", "1", "0", "0" }, new[] { "1", "0", "1", "1", "1" }, new[] { "1", "1", "1", "1", "1" }, new[] { "1", "0", "0", "1", "0"}};
	MaximalRectangle(matrix);
}

public int MaximalRectangle(char[][] matrix)
{
	if (matrix.Length == 0) return 0;

	var dp = new int[matrix[0].Length];
	var max = 0;

	for (var i = 0; i < matrix.Length; i++)
	{
		for (var j = 0; j < matrix[0].Length; j++)
		{
			dp[j] = matrix[i][j] == '1' ? dp[j] + 1 : 0;
		}
		
		max = Math.Max(max, Help(dp));
	}
	
	return max;
}

public int Help(int[] dp) 
{
	var stack = new Stack<int>();
	stack.Push(-1);
	
	var max = 0;
	for (var i = 0; i < dp.Length; i++)
	{
		while (stack.Peek() != -1 && dp[stack.Peek()] >= dp[i])
			max = Math.Max(max, dp[stack.Pop()] * (i - stack.Peek() - 1));
		stack.Push(i);
	}

	while (stack.Peek() != -1)
		max = Math.Max(max, dp[stack.Pop()] * (dp.Length - stack.Peek() - 1));
		
	return max;
}