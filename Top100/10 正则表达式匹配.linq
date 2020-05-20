<Query Kind="Program" />

void Main()
{
}

public bool IsMatch(string s, string e)
{
	if (string.IsNullOrEmpty(e)) return true;
	if (string.IsNullOrEmpty(s) && e != "*") return false;

	var dp = new bool[s.Length, e.Length];
	for (var i = 1; i < s.Length; i++)
		for (var j = 1; j < e.Length; j++)
		{
			if (char.IsLetter(e[j]))
			{
				dp[i][j]
			}
			else if (e[i] == '.')
			{

			}
			else
			{
				
			}
		}

	return true;
}
