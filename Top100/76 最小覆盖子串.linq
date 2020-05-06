<Query Kind="Program" />

void Main()
{
	MinWindow("ask_not_what_your_country_can_do_for_you_ask_what_you_can_do_for_your_country", "ask_country").Dump();
}

public string MinWindow(string s, string t)
{
	if (string.IsNullOrEmpty(s)) return "";

	var need = new int[128];
	var window = new int[128];
	for (var i = 0; i < t.Length; i++) 
	{
		need[t[i]]++;
	}

	var r = 0;
	var l = 0;
	var count = 0;
	var minLength = int.MaxValue;
	var minLeft = -1;
	while (r < s.Length)
	{
		window[s[r]]++;
		if (need[s[r]] > 0 && need[s[r]] >= window[s[r]])
			count++;

		while (count == t.Length)
		{
			if (r - l + 1 < minLength) 
			{
				minLength = r- l + 1;
				minLeft = l;
			}
			if (need[s[l]] > 0 && need[s[l]] >= window[s[l]])
				count--;
				
			window[s[l]]--;
			l++;
		}
		r++;
	}
	
	if (minLeft == -1) return "";
	return s.Substring(minLeft, minLength);
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