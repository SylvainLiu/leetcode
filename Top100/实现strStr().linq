<Query Kind="Program" />

void Main()
{
	StrStr("mississippi","issip").Dump();
}

// Define other methods and classes here
public int StrStr(string haystack, string needle)
{
	if (string.IsNullOrEmpty(needle)) return 0;
	if (string.IsNullOrEmpty(haystack)) return -1;

	for (int i = 0, j = 0; i < haystack.Length; i++)
	{		
		if (haystack[i] == needle[j]) 
		{
			j++;

			if (j == needle.Length)
			{
				return i - j + 1;
			}
		}
		else
		{
			i = i - j;
			j = 0;
		}
	}
	
	return -1;
}