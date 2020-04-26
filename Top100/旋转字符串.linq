<Query Kind="Program" />

void Main()
{
	ReverseString(new char[] {'h','e','l','l','o'});
}

public void ReverseString(char[] s)
{
	if (s.Length == 0 || s.Length == 1) return;	
	
	var left = 0;
	var right = s.Length -1;

	while (left <= right)
	{
		var temp = s[left];
		s[left] = s[right];
		s[right] = temp;
		
		left++;
		right--;
	}
	
	s.Dump();
}