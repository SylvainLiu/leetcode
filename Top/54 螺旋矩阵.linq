<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public IList<int> SpiralOrder(int[][] matrix)
{
	var res = new List<int>();
	if (matrix == null || matrix.Length == 0 
	|| matrix[0] == null || matrix[0].Length == 0) return res;

	var raw = matrix.Length;
	var col = matrix[0].Length;
	var min = Math.Min(raw, col);
	var cir = min / 2;

	var index = 0;
	while (index < cir) 
	{
		for (var i = index; i < col - index - 1; i++)
			res.Add(matrix[index][i]);

		for (var i = index; i < raw - index - 1; i++)
			res.Add(matrix[i][col - index - 1]);

		for (var i = col - index - 1; i > index ; i--)
			res.Add(matrix[raw - index - 1][i]);

		for (var i = raw - index - 1; i > index; i--)
			res.Add(matrix[i][index]);

		index++;
	}

	if (min % 2 == 1)
	{
		if (col > raw)
		{
			for (var i = index; i < col - index; i++)
				res.Add(matrix[index][i]);
		}
		else
		{
			for (var i = index; i < raw - index; i++)
				res.Add(matrix[i][col - index - 1]);
		}
	}
	
	return res;
}