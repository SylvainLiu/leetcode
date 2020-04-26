<Query Kind="Program" />

void Main()
{
	GroupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"}).Dump();
}


public IList<IList<string>> GroupAnagrams(string[] strs)
{
	var res = new Dictionary<string, IList<string>>();
	if (strs.Length == 0) return res.Values.ToList();

	for (var i = 0; i < strs.Length; i++) 
	{
		var xori = Xor(strs[i]);
		if (res.ContainsKey(xori)) res[xori].Add(strs[i]);
		else res.Add(xori, new List<string> {strs[i]});
	}
	
	return res.Values.ToList();
}

public string Xor(string str)
{
	var xor = new char[26];
	for (var i = 0; i < str.Length; i++)
		xor[str[i] - 'a']++;

	return new string(xor);
}