<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int FirstBadVersion(int n)
{
	var left = 1;
	var right = n;

	while (left < right)
	{
		var middle = left + (right - left) / 2;
		if (IsBadVersion(middle))
		{
			right = middle;
		}
		else
		{
			left = middle + 1;
		}
	}

	return left;
}

bool IsBadVersion(int version)
{
	return true;	
}
