<Query Kind="Program" />

void Main()
{
	LengthOfLongestSubstring("pwwkew").Dump();
}

public int LengthOfLongestSubstring(string s)
{
	if (string.IsNullOrEmpty(s)) return 0;
	
	var record = new HashSet<char>();
	var res = 0;
	var index = 0;
	while (index < s.Length)
	{
		if (record.Add(s[index])) 
		{
			res = Math.Max(res, record.Count());
			index++;
		}
		else
		{
			record.Remove(s[index - record.Count()]);
		}
	}
	
	return res;
}


//public int LengthOfLongestSubstring(string s)
//{
//	if (s == "") return 0;
//
//	var set = new HashSet<char>();
//	var res = 0;
//	
//	int i = 0, j = 0;
//	for (i = 0; i < s.Length; i++)
//	{
//		while (j < s.Length)
//		{
//			var temp = set.Add(s[j]);
//			if (!temp)
//			{
//				res = res > set.Count? res:set.Count;
//				set.Remove(s[i]);
//				break;
//			}
//			j++;
//		}
//
//		if (j == s.Length) 
//		{
//			res = res > set.Count? res:set.Count;
//			break;
//		}
//	}
//	
//	return res;
//}