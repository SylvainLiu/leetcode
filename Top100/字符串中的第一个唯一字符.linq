<Query Kind="Program" />

void Main()
{
	FirstUniqChar("loveleetcode").Dump();
}

public int FirstUniqChar(string s)
{
	if (s.Length == 0) return -1;
	if (s.Length == 1) return 0;

	var dic = new int[26];
	for (var i = 0; i < s.Length; i++)
	{
		var index = s[i] - 'a';
		dic[index]++;
	}

	for (var i = 0; i < s.Length; i++) 
	{
		var index = s[i] - 'a';
		if(dic[index] == 1) return i;
	}
	
	return -1;
}