<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public void GameOfLife(int[][] board)
{
	if (board == null ||
		board.Length == 0 ||
		board[0] == null ||
		board[0].Length == 0) return;

	for (var i = 0; i < board.Length; i++)
		for (var j = 0; j < board[0].Length; j++)
		{
			var temp = CountAlive(board, i, j);
			if (board[i][j] == 1 && (temp == 3 || temp == 2)) board[i][j] = 3;
			if (board[i][j] == 0 && temp == 3) board[i][j] = 2;
		}

	for (var i = 0; i < board.Length; i++)
		for (var j = 0; j < board[0].Length; j++)
		{
			board[i][j] >>= 1;
		}
}

public int CountAlive(int[][] board, int i, int j) 
{
	var count = 0;
	for (var a = i - 1; a <= i + 1; a++)
		for (var b = j - 1; b <= j + 1; b++)
		{
			if (a >= 0 && a < board.Length && b >= 0 && b < board[0].Length)
			{
				count += board[a][b] & 1;
			}
		}
	
	if ((board[i][j] & 1) == 1) count--;
	return count;
}