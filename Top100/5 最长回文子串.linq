<Query Kind="Program" />

void Main()
{
	LongestPalindrome("bananas").Dump();
}

public string LongestPalindrome(string s) 
{
	if (string.IsNullOrEmpty(s)) return s;
	if (s.Length == 1) return s;

	var res = new int[2];
	for (var i = 1; i < s.Length; i++)
	{
		var length1 = Palindrome(s, i, i);
		var length2 = Palindrome(s, i - 1, i);
		var length = length1 > length2 ? length1 : length2; ;
		if (length > res[1])
		{
			res[1] = length;
			res[0] = i - res[1] / 2;
		}
	}
	return s.Substring(res[0], res[1]);
}

public int Palindrome(string s, int left, int right)
{
	while (left >= 0 && right < s.Length && s[right] == s[left]) 
	{
		left--;
		right++;
	}
	return right - left - 1;
}

//public string LongestPalindrome(string s) 
//{
//	if (string.IsNullOrEmpty(s)) return s;
//	var dp = new bool[s.Length, s.Length];
//	var res = new int[2];
//	for (var i = 0; i < s.Length; i++)
//		for (var j = 0; j <= i; j++) 
//		{
//			if (s[i] == s[j] && (i - j <= 2 || dp[i - 1, j + 1]))
//			{
//				dp[i, j] = true;
//				if (res[1] < i - j + 1)
//				{
//					res[0] = j;
//					res[1] = i - j + 1;
//				}
//			}				
//		}
//	return s.Substring(res[0], res[1]);
//}