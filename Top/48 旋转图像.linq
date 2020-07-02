<Query Kind="Program" />

void Main()
{
	Rotate(new int[3][] { new int[3] {1, 2, 3}, new int[3] {4, 5 , 6}, new int[3] {7, 8, 9}});
}

public void Rotate(int[][] matrix)
{
	if(matrix.Length == 0 || matrix.Length == 1) return;
	
	var raw = matrix.Length / 2 - 1;
	var column = matrix.Length / 2 - (matrix.Length - 1) % 2;
	for (var i = 0; i <= raw; i++)
		for (var j = 0; j <= column; j++) 
		{
			var temp = matrix[i][j];
			matrix[i][j] = matrix[matrix.Length-j-1][i];
			matrix[matrix.Length-j-1][i] = matrix[matrix.Length-i-1][matrix.Length-j-1];
			matrix[matrix.Length-i-1][matrix.Length-j-1] = matrix[j][matrix.Length-i-1];
			matrix[j][matrix.Length-i-1] = temp;
		}
}

//public void Rotate(int[][] matrix)
//{
//	if(matrix.Length == 0 || matrix.Length == 1) return;
//
//	var boundX = (matrix.Length + 1) / 2;
//	var boundY = matrix.Length / 2;
//	
//	for (var i = 0; i < boundX; i++)
//		for (var j = 0; j < boundY; j++) 
//		{
//			var temp = matrix[i][j];
//			matrix[i][j] = matrix[matrix.Length-j-1][i];
//			matrix[matrix.Length-j-1][i] = matrix[matrix.Length-i-1][matrix.Length-j-1];
//			matrix[matrix.Length-i-1][matrix.Length-j-1] = matrix[j][matrix.Length-i-1];
//			matrix[j][matrix.Length-i-1] = temp;
//		}
//}