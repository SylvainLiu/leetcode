<Query Kind="Program" />

void Main()
{
	FindAnagrams("cbaebabacd", "abc").Dump();
}

public IList<int> FindAnagrams(string s, string p)
{
	var res = new List<int>();
	var needs = new int[26];
	var window = new int[26];
	for (var i = 0; i < p.Length; i++) 
	{
		needs[p[i] - 'a']++;
	}
	
	var l = 0;
	var r = 0;
	while (r < s.Length) 
	{
		var curR = s[r] - 'a';
		window[curR]++;
		r++;

		while (window[curR] > needs[curR]) 
		{
			window[s[l] - 'a']--;
			l++;
		}
		
		if (r - l == p.Length) res.Add(l);
	}
	
	return res;
}