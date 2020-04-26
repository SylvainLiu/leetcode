<Query Kind="Program" />

void Main()
{
	IsPalindrome("A man, a plan, a canal: Panama").Dump();
}

public bool IsPalindrome(string s)
{
	if (s == null) return false;
	if (s == "" || s.Length == 1) return true;

	var left = 0;
	var right = s.Length - 1;

	while (left <= right)
	{
		if (!char.IsLetterOrDigit(s[left]))
		{
			left++;
			continue;
		}

		if (!char.IsLetterOrDigit(s[right]))
		{
			right--;
			continue;
		}

		var l = char.ToLower(s[left]);
		var r = char.ToLower(s[right]);
		
		if (l != r) return false;
		
		left++;
		right--;
	}
	
	return true;
}