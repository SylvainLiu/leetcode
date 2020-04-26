<Query Kind="Program" />

void Main()
{
	SearchMatrix(new int[1, 1] { { -5 } }, -10).Dump();
	SearchMatrix(new int[1, 2] { { -1, 3 } }, 1).Dump();
	SearchMatrix(new int[5, 5] { { 1, 4, 7, 11, 15 }, { 2, 5, 8, 12, 19 }, { 3, 6, 9, 16, 22 }, { 10, 13, 14, 17, 24 }, { 18, 21, 23, 26, 30 } }, 5).Dump();
	SearchMatrix(new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6,7,8,9,10 }, {11,12,13,14,15 }, {16,17,18,19,20}, { 21,22,23,24,25}}, 15).Dump();
}

// Define other methods and classes here
public bool SearchMatrix(int[,] matrix, int target) {
	if (matrix.Length == 0) return false;

	var i = matrix.GetLength(0) - 1;
	var j = 0;
	var current = matrix[i, j];

	while (current != target)
	{
		if (current > target) 
		{
			i--;
			if (i == -1) return false;
		}
		else 
		{
			j++;
			if (j ==  matrix.GetLength(1)) return false;
		}
		current = matrix[i, j];
	}
	
	return true;
}