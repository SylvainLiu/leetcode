<Query Kind="Program" />

void Main()
{
	CountSubstrings("abc").Dump();
}

public int CountSubstrings(string s)
{
	if (s.Length == 0) return 0;

	var dp = new bool[s.Length, s.Length];
	var res = 0;
	for (var i = 0; i < s.Length; i++)
		for (var j = i; j >= 0; j--)
		{
			if (s[i] == s[j] && (i - j < 2 || dp[i - 1, j + 1]))
			{
				dp[i, j] = true;
				res++;
			}
		}

	return res;
}

//public int CountSubstrings(string s)
//{
//	if(s.Length ==0 ) return 0;
//
//	var count = s.Length;
//	for (var i = 1; i < s.Length; i++)
//	{
//		var j = 1;
//		while (i - j >= 0 && i + j < s.Length) 
//		{
//			if(s[i - j] != s[i + j]) break;
//			count++;
//			j++;
//		}
//		
//		j=0;
//		while (i - j - 1 >= 0 && i + j < s.Length)
//		{
//			if (s[i - j - 1] != s[i + j]) break;
//			count++;
//			j++;
//		}
//	}
//	
//	return count;
//}