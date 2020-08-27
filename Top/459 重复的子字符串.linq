<Query Kind="Program" />

void Main()
{
	RepeatedSubstringPattern("a").Dump();
}

// Define other methods and classes here
public bool RepeatedSubstringPattern(string s)
{
	if (string.IsNullOrEmpty(s)) return false;

	for (var i = 0; i <= s.Length / 2; i++) 
	{
		var len = i + 1;
		if (s.Length % (len) != 0) continue;

		var str = s.Substring(0, len);
		var repeat = false;
		for (var j = len; j < s.Length; j += len) 
		{
			var tmp = s.Substring(j, len);
			
			if (tmp != str) 
			{
				repeat = false;
				break;
			}
			
			repeat = true;
		}
		
		if (repeat) return true;
	}
	
	return false;
}