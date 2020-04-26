<Query Kind="Program" />

void Main()
{
	CountAndSay(5).Dump();
}

public string CountAndSay(int n)
{
	var res = "1";
	n--;	
	while (n > 0)
	{		
		res = CountAndSay(res);
		n--;
	}
	
	return res;
}

public string CountAndSay(string pre) 
{
	if (pre.Length == 1) return "11";
	
	var index = 1;
	var count = 1;
	var res = string.Empty;
	while (index < pre.Length)
	{
		if (pre[index] == pre[index - 1]) 
		{
			index++;
			count++;
		}
		else
		{
			res = res + count.ToString() + pre[index-1].ToString();
			count = 1;
			index++;
		}
	}
	
	return res + count.ToString() + pre[index-1].ToString();
}