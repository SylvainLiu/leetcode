<Query Kind="Program" />

void Main()
{
	
}

public bool IsAnagram(string s, string t)
{
	if (s.Length != t.Length) return false;
	if (s.Length == 1 && s.Length == 0) return true;

	var count = new int[26];
	for (var i = 0; i < s.Length; i++)
	{
		count[s[i] - 'a']++;
		count[t[i] - 'a']--;
	}

	for (var i = 0; i < s.Length; i++)
	{
		if(count[s[i] - 'a'] != 0) return false;
	}
	
	return true;
}