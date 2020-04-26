<Query Kind="Program" />

void Main()
{
	WordBreak("leetcode", new List<string> {"leet", "code"}).Dump();
}

public bool WordBreak(string s, IList<string> wordDict) 
{
	var set = new HashSet<string>(wordDict);
	
	var dp = new bool[s.Length + 1];
	dp[0] = true;

	for (var i = 1; i <= s.Length; i++)
		for (var j = 0; j < i; j++)
		{
			if (dp[j] && set.Contains(s.Substring(j, i - j))) { dp[i] = true; break;}
		}
	return dp[s.Length];
}
   
//public bool WordBreak(string s, IList<string> wordDict)
//{
//	var dic = wordDict.ToLookup(x => x.First(), y => y);
//	var record = new int[s.Length];
//	
//	return WordBreak(s, dic, 0, record);
//}

//public bool WordBreak(string s, ILookup<char, string> wordDict, int i, int[] record)
//{
//	if (i == s.Length) return true;
//	if (i > s.Length) return false;
//	if (record[i] == 1) return false;
//
//	var next = s[i];
//	foreach (var word in wordDict[next])
//	{
//		if (i + word.Length <= s.Length && s.Substring(i, word.Length) == word && WordBreak(s, wordDict, i + word.Length, record))
//		{
//			return true;
//		}
//	}
//	
//	record[i] = 1;
//	return false;
//}