<Query Kind="Program" />

void Main()
{
	LongestCommonPrefix(new string[] {"aa", "a"}).Dump();
}

public string LongestCommonPrefix(string[] strs)
{
	if (strs.Length == 0) return string.Empty;
	
	var index = 1;
	var res = strs[0];
	while (index < strs.Length) 
	{
		if (string.IsNullOrEmpty(res)) return res;
		
		var value = strs[index];
		var i = 0;
		while (i < value.Length && i < res.Length)
		{
			if (value[i] == res[i]) 
			{
				i++;
				continue;
			}
			
			break;
		}
		
		res = res.Substring(0, i);
		index++;
	}
	
	return res;
}