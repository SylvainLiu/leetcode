<Query Kind="Program" />

void Main()
{
	IsNumber(" -54.53061");
}

// Define other methods and classes here
public bool IsNumber(string s)
{
	if (string.IsNullOrEmpty(s))
	{
		return false;
	}
	
	s = s.Trim();
	
	var num = false;
	var e = false;
	var dot = false;
	var index = 0;

	while (index < s.Length)
	{
		if (char.IsDigit(s[index]))
		{
			num = true;
		}
		else if (s[index] == '+' || s[index] == '-')
		{
			if (index != 0 && s[index - 1] != 'E' && s[index - 1] != 'e') return false;
		}
		else if (s[index] == '.')
		{
			if (dot || e) return false;
			dot = true;
		}
		else if (s[index] == 'E' || s[index] == 'e')
		{
			if (!num || e) return false;
			e = true;
			num = false;
		}
		else
		{
			return false;
		}

		index++;
	}

	return num;
}