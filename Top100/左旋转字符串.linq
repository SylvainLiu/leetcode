<Query Kind="Program" />

void Main()
{
	var res = ReverseLeftWords("lrloseumgh", 6).Dump();
}

public string ReverseLeftWords(string s, int n)
{
	if (string.IsNullOrEmpty(s)) return s;
	
	var res1 = s.Substring(n);
	var res2 = s.Substring(0, n);
	
	return res1 + res2;
}