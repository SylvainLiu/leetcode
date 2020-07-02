<Query Kind="Program" />

void Main()
{
	Partition("aab").Dump();
}

// Define other methods and classes here
public IList<IList<string>> Partition(string s)
{
	var res = new List<IList<string>>();
	
	if (string.IsNullOrEmpty(s)) return res;

	var dp = new bool[s.Length, s.Length];
	
	for (var i = 0; i < s.Length; i++)
	{
		dp[i, i] = true;
		
		for (var j = 0; j < i; j++)
		{
			if (s[i] == s[j] && (i - j < 2 || dp[i - 1, j + 1])) 
			{
				dp[i, j] = true;
			}
		}
	}
	
	BrackTrack(s, dp, new List<string>(), 0, res);
	return res;
}

public void BrackTrack(string s, bool[,] dp, List<string> current, int index, List<IList<string>> res) 
{
	if (index == s.Length) 
	{
		res.Add(current.ToList());
		return;
	}

	for (var i = index; i < s.Length; i++)
	{
		if (dp[i, index]) 
		{
			current.Add(s.Substring(index, i - index + 1));
			BrackTrack(s, dp, current, i + 1, res);
			current.RemoveAt(current.Count() - 1);
		}
	}
}