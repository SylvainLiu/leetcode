<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public bool Exist(char[][] board, string word)
{
	if (string.IsNullOrEmpty(word)) return false;
	
	var raw = board.Length;
	var column = board[0].Length;
	var record = new bool[raw, column];
	for (int i = 0; i < raw; i++)
		for (int j = 0; j < column; j++)
		{
			if (Exist(board, word, i, j, 0, record))
			{
				return true;
			}
		}
	
	return false;
}

public int[][] direction = new int[4][] { new []{-1, 0},new []{1, 0}, new []{0, 1}, new []{0, -1}};
public bool Exist(char[][] board, string word, int i, int j, int current, bool[,] record)
{
	if (current == word.Length - 1) 
	{
		return word[current] == board[i][j];
	}

	if (word[current] == board[i][j]) 
	{
		record[i,j] = true;
		for (var k = 0; k < 4; k++)
		{
			var x = i + direction[k][0];
			var y = j + direction[k][1];

			if (x >= 0 && x < board.Length && y > 0 && y < board[0].Length)
			{
				if ((!record[x,y]) && Exist(board, word, x, y, current+1, record)) 
				{
					return true;
				}
			}
		}
		record[i,j] = false;
	}

	return false;
}