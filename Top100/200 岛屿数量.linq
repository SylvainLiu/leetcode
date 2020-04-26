<Query Kind="Program" />

void Main()
{
	var sut = new char[4][] { new[] { '1', '1', '1', '1', '0' }, 
							  new[] { '1', '1', '0', '1', '0' }, 
							  new[] { '1', '1', '0', '0', '0' }, 
							  new[] { '0', '0', '0', '0', '0'}};
	NumIslands(sut).Dump();
}

public int NumIslands(char[][] grid)
{
	if (grid.Length == 0) return 0;
	set = new int[grid.Length * grid[0].Length + 1];
	set[0] = -2;
	for (var i = 0; i < grid.Length; i++)
		for (var j = 0; j < grid[0].Length; j++)
		{
			if (grid[i][j] == '0')
			{
				set[i * grid[0].Length + j + 1] = -2;
				continue;
			}

			if (i < grid.Length - 1 && grid[i + 1][j] == '1')
				Union(i * grid[0].Length + j + 1, (i + 1) * grid[0].Length + j + 1);
			if (j < grid[0].Length - 1 && grid[i][j + 1] == '1')
				Union(i * grid[0].Length + j + 1, i * grid[0].Length + j + 2);
		}

	var count = 0;
	for (int i = 0; i < set.Length; ++i)
	{
		if (set[i] == 0) count++;
	}
	return count;
}

public int[] set;
public void Union(int x, int y)
{
	var xP = FindParent(x);
	var yP = FindParent(y);

	if (xP != yP)
		set[xP] = yP;
}
public int FindParent(int x)
{
	while (set[x] != 0)
	{
		x = set[x];
	}
	return x;
}

//public int NumIslands(char[][] grid)
//{
//	if (grid.Length == 0) return 0;
//	
//	var res = 0;
//	for (var i = 0; i < grid.Length; i++)
//		for (var j = 0; j < grid[0].Length; j++)
//		{
//			if (grid[i][j] == '1') 
//			{
//				res++;
//				Mark(grid, i, j)
//			}
//		}
//	return res;
//}
//
//public void Mark(char[][] grid, int i, int j) 
//{
//	if(grid[i][j] == '0') return;
//	grid[i][j] = '0';
//	if (i > 0) Mark(grid, i - 1, j);
//	if (j > 0) Mark(grid, i, j - 1);
//	if (i < grid.Length - 1) Mark(grid, i + 1, j);
//	if (j < grid[0].Length - 1) Mark(grid, i, j + 1);
//}