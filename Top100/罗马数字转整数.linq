<Query Kind="Program" />

void Main()
{
	RomanToInt("IV").Dump();
}

// Define other methods and classes here
public int RomanToInt(string s)
{
	if (string.IsNullOrEmpty(s)) return 0;

	var dic = new Dictionary<char, int>
	{
		{'I', 1},
		{'V', 5},
		{'X', 10},
		{'L', 50},
		{'C', 100},
		{'D', 500},
		{'M', 1000},
	};
	
	var res = 0;
	var i = 0;
	for (i = 0; i < s.Length; i++)
	{
		if (dic[s[i]] < dic[s[i + 1]]) 
		{
			res -= dic[s[i]];
		}
		else 
		{
			res += dic[s[i]];
		}		
	}
	
	return res;
}