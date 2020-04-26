<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int MaximalSquare(char[][] matrix)
{
	if (matrix.Length ==  0) return 0;
	var dp = new int[matrix[0].Length + 1];
	var max = 0;
	var pre = 0;
	for (var i = 1; i < matrix.Length + 1; i++)
		for (var j = 1; j < matrix[0].Length + 1; j++)
		{
			var temp = dp[j];
			if (matrix[i - 1][j - 1] == '0') dp[j] = 0;
			else 
			{
				dp[j] = Math.Min(Math.Min(dp[j], dp[j - 1]), pre) + 1;
				max = Math.Max(dp[j], max);
			}
			pre = temp;
		}
		
	return max * max;
}