<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public void SetZeroes(int[][] matrix)
{
	if (matrix == null
		|| matrix.Length == 0
		|| matrix[0] == null
		|| matrix[0].Length == 0) return;

	var firstCol = false;

	for (var i = 0; i < matrix.Length; i++)
	{
		if (matrix[i][0] == 0) firstCol = true;
		for (var j = 1; j < matrix[0].Length; j++)
		{
			if (matrix[i][j] == 0)
			{
				matrix[i][0] = 0;
				matrix[0][j] = 0;
			}
		}
	}


	for (var i = 1; i < matrix.Length; i++)
		for (var j = 1; j < matrix[0].Length; j++)
		{
			if (matrix[0][j] == 0 || matrix[i][0] == 0)
			{
				matrix[i][j] = 0;
			}
		}

	if (matrix[0][0] == 0)
	{
		for (var j = 0; j < matrix[0].Length; j++)
		{
			matrix[0][j] = 0;
		}
	}

	if (firstCol)
	{
		for (var j = 0; j < matrix.Length; j++)
		{
			matrix[j][0] = 0;
		}
	}
}