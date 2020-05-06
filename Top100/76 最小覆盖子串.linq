<Query Kind="Program" />

void Main()
{
}

public int[] MinWindow(string s, string t)
{
		
}

//public string MinWindow(string s, string t)
//{
//	if (string.IsNullOrEmpty(s)) return "";
//
//	var hash = new Dictionary<char, int>();
//	for (var i = 0; i < t.Length; i++)
//	{
//		if (hash.ContainsKey(t[i])) hash[t[i]]++;
//		else hash.Add(t[i], 1);
//	}
//
//	BackTrack(s, hash, -1, 0);
//	if (index == -1) return "";
//
//	return s.Substring(index, length);
//}
//
//public int length = int.MaxValue;
//public int index = -1;
//public void BackTrack(string s, Dictionary<char, int> hash, int start, int current)
//{
//	if (!hash.Any() && (current - start < length))
//	{
//		length = current - start;
//		index = start;
//		return;
//	}
//	if (current >= s.Length)
//	{
//		return;
//	}
//
//	BackTrack(s, hash, start, current + 1);
//
//	if (hash.ContainsKey(s[current]))
//	{
//		hash[s[current]]--;
//		if (hash[s[current]] == 0) hash.Remove(s[current]);
//		if (start == -1) start = current;
//
//		BackTrack(s, hash, start, current + 1);
//
//		if (!hash.ContainsKey(s[current])) hash.Add(s[current], 1);
//		else hash[s[current]]++;
//	}
//}