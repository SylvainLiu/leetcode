<Query Kind="Program" />

void Main()
{
	IsValidSudoku(new char[][] { new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }, 
								 new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
								 new char[] { '.', '9', '3', '.', '.', '.', '.', '6', '.' },
								 new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' }, new char[] {'4','.','.','8','.','3','.','.','1'},          new char[] {'7','.','.','.','2','.','.','.','6'},
								 new char[] {'.','6','.','.','.','.','2','8','.'},           new char[] {'.','.','.','4','1','9','.','.','5'},          new char[] {'.','.','.','.','8','.','.','7','9'}});
}

public bool IsValidSudoku(char[][] board) 
{
	var record = new int[9];

	for (var i = 0; i < 9; i++)
		for (var j = 0; j < 9; j++)
		{
			var value = board[i][j] - '0';
			
			if (value < 10 && value > 0)
			{
				var blockIndex = (i / 3) * 3 + j / 3;
				
				if ((record[value] >> blockIndex & 1) == 1  || ((record[value] >> (i + 9)) & 1) == 1 || ((record[value] >> (j + 18)) & 1) == 1)
				{
					return false;
				}
				
				var a = (1 << blockIndex);
				var b = (1 << (i + 9));
				var c = (1 << (j + 18));
				
				record[value] += a+b+c;
				
				Convert.ToString(record[value], 2).Dump();
			}
		}
		
	return true;
}

//public bool IsValidSudoku(char[][] board)
//{
//	var seed = Enumerable.Repeat(0, 9);
//	var row = seed.Select(x => new HashSet<char>()).ToArray();
//	var column = seed.Select(x => new HashSet<char>()).ToArray();
//	var block = seed.Select(x => new HashSet<char>()).ToArray();
//
//	for (var i = 0; i < 9; i++)
//		for (var j = 0; j < 9; j++) 
//		{
//			if (board[i][j] == '.') continue;
//
//			if (!row[i].Add(board[i][j])) 
//				return false;
//			if (!column[j].Add(board[i][j])) 
//				return false;
//			
//			var blockIndex = (i/3) * 3  + j/3;
//			if (!block[blockIndex].Add(board[i][j])) 
//				return false;
//		}
//		
//	return true;
//}