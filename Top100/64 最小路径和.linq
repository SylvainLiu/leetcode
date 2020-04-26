<Query Kind="Program" />

void Main()
{
	var grid1 = new int[] { 1, 3, 1 };
	var grid2 = new int[] { 1, 5, 1 };
	var grid3 = new int[] { 4, 2, 1 };
	var grid = new int[3][] {grid1, grid2, grid3};
	
	MinPathSum(grid).Dump();
}

public int MinPathSum(int[][] grid) 
{
	var dp = new int[grid[0].Length + 1];
	dp[0] = 0;	
	for (var i = 1; i < grid[0].Length + 1; i++)
	{
		dp[i] = grid[0][i - 1] + dp[i - 1];
	}
	dp[0] = int.MaxValue;
	
	for (var i = 1; i < grid.Length; i++)
		for (var j = 1; j < grid[0].Length + 1; j++)
		{
			dp[j] = Math.Min(dp[j - 1], dp[j]) + grid[i][j - 1];
		}
	
	return dp[grid[0].Length];
}

//public int MinPathSum(int[][] grid)
//{
//	var m = grid.Length;
//	var n = grid.First().Length;
//
//	var dp = new int[m + 1][];
//	dp[0] = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
//	for (var i = 1; i < m + 1; i++) 
//	{
//		dp[i] = new int[n + 1];
//		dp[i][0] = int.MaxValue;
//	}
//	dp[0][1] = 0;
//		
//	for (var i = 0; i < m; i++)
//		for (var j = 0; j < n; j++) 
//		{
//			dp[i + 1][j + 1] = Math.Min(dp[i+1][j], dp[i][j+1]) + grid[i][j];
//		}
//		
//	return dp[m][n];
//}