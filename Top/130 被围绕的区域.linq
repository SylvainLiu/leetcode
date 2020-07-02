<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public void Solve(char[][] board)
{
	if (board == null || board.Length == 0 || board[0] == null || board[0].Length == 0) return;

	var row = board.Length;
	var col = board[0].Length;

	var q = new Queue<(int, int)>();
	for (var i = 0; i < row; i++)
	{
		if (board[i][0] == 'O') q.Enqueue((i, 0));
		if (board[i][col - 1] == 'O') q.Enqueue((i, col - 1));
	}
	for (var i = 0; i < col; i++)
	{
		if (board[0][i] == 'O') q.Enqueue((0, i));
		if (board[row - 1][i] == 'O') q.Enqueue((row - 1, i));
	}

	var visited = new HashSet<(int, int)>();
	while (q.Any())
	{
		var size = q.Count();
		var index = 0;
		while (index < size)
		{
			var temp = q.Dequeue();
			Mark(q, temp, visited, board);
			index++;
		}
	}

	for (var i = 0; i < row; i++)
		for (var j = 0; j < col; j++)
		{
			if (board[i][j] == '#') board[i][j] = 'O';
			else board[i][j] = 'X';
		}
}

public void Mark(Queue<(int, int)> q, (int, int) cur, HashSet<(int, int)> visited, char[][] board)
{
	var x = cur.Item1;
	var y = cur.Item2;
	if (!(x >= 0 && x < board.Length && y >= 0 && y < board[0].Length)) return;

	if (board[x][y] != 'O') return;
	if (visited.Contains(cur)) return;

	visited.Add(cur);
	board[x][y] = '#';
	q.Enqueue((x + 1, y));
	q.Enqueue((x - 1, y));
	q.Enqueue((x, y + 1));
	q.Enqueue((x, y - 1));
}