<Query Kind="Program" />

void Main()
{
	RemoveInvalidParentheses(")()(").Dump();
}

public IList<string> RemoveInvalidParentheses(string s)
{
	if (string.IsNullOrEmpty(s)) return new List<string> {""};
	
	var set = new HashSet<string>();
	var leftDelete = 0;
	var rightDelete = 0;
	for (var i = 0; i < s.Length; i++) 
	{
		if (s[i] == '(') leftDelete++;
		else if (s[i] == ')') 
		{
			if (leftDelete > 0) leftDelete--;
			else rightDelete++;
		}
	}
	
	var index = 0;
	var leftCount = 0;
	DFS(s, index, leftCount, leftDelete, rightDelete, set, "");
	
	return set.ToList();
}

public void DFS(string s, int index, int leftCount, int leftDelete, int rightDelete, HashSet<string> set, string sb) 
{
	if (index == s.Length)
	{
		if (leftCount == 0 && leftDelete == 0 && rightDelete == 0) set.Add(sb);
		return;		
	}

	if (s[index] == '(')
	{
		if (leftDelete > 0)
			DFS(s, index + 1, leftCount, leftDelete - 1, rightDelete, set, sb);
        DFS(s, index + 1, leftCount + 1, leftDelete, rightDelete, set, sb + '(');
	
	}
	else if (s[index] == ')')
	{
		if (rightDelete > 0)
			DFS(s, index + 1, leftCount, leftDelete, rightDelete - 1, set, sb);
		
	    if (leftCount > 0)
			DFS(s, index + 1, leftCount - 1, leftDelete, rightDelete, set, sb + ')');
	}
	else 
	{
		DFS(s, index + 1, leftCount, leftDelete, rightDelete, set, sb + s[index]);
	}
}