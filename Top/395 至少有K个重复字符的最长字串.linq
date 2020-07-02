<Query Kind="Program" />

void Main()
{
	LongestSubstring("aabcabb", 3).Dump();
}

public int LongestSubstring(string s, int k)
{
	if (string.IsNullOrEmpty(s)) return 0;
	if (k <= 1) return s.Length;
	if (k > s.Length) return 0;
	
	return Find(s, 0, s.Length - 1, k);
}

public int Find(string s, int start, int end, int tar)
{
	var actual = new int[26];
	for (var i = start; i <= end ; i++) actual[s[i] - 'a']++;
	
	var l = start;
	var r = end;
	while (l < r && actual[s[l] - 'a'] < tar) l++;
	while (l < r && actual[s[r] - 'a'] < tar) r--;
	
	if (r - l + 1 < tar) return 0;

	for (var i = l + 1; i < r; i++)
	{
		if (actual[s[i] - 'a'] < tar) 
		{
			return Math.Max(Find(s, l, i - 1, tar), Find(s, i + 1, r, tar));
		}
	}
	
	return r - l + 1;
}

// Define other methods and classes here
//public int LongestSubstring(string s, int k)
//{
//	if (string.IsNullOrEmpty(s)) return 0;
//	if (k <= 1) return s.Length;
//	if (k > s.Length) return 0;
//
//	var actual = new int[26];
//	var num = 0;
//	for (var i = 0; i < s.Length; i++)
//	{
//		if (actual[s[i] - 'a'] == 0) num++;
//		actual[s[i] - 'a']++;
//	}
//
//	var res = 0;
//	for (var i = 1; i <= num; i++) 
//	{
//		res = Math.Max(Find(actual, i, s, k), res);
//	}
//	return res;
//}
//
//public int Find(int[] actual, int letters, string s, int tar)
//{
//	var left = 0;
//	var right = 0;
//	var window = new int[26];
//	var curWin = 0;
//	var tarWin = 0;
//	
//	var res = 0;
//	while (right < s.Length)
//	{
//		if (window[s[right] - 'a'] == 0) curWin++;
//		window[s[right] - 'a']++;
//		if (window[s[right] - 'a'] == tar) tarWin++;
//		
//		right++;
//		
//		if (curWin == tarWin && tarWin == letters) 
//		{
//			res = Math.Max(res, right - left);
//		}
//		else if (curWin > letters)
//		{
//			while (curWin > letters) 
//			{
//				if (window[s[left] - 'a'] == tar) tarWin--;
//				window[s[left] - 'a']--;
//				if (window[s[left] - 'a'] == 0) curWin--;
//				
//				left++;
//			}
//		}
//	}
//	
//	return res;
//}