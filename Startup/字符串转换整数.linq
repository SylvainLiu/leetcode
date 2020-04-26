<Query Kind="Program" />

void Main()
{
	MyAtoi("   2147483646").Dump();
}

// Define other methods and classes here
public int MyAtoi(string str)
{
	var res = 0;
	var index = 0;
	var sign = 1;
	while (index < str.Length)
	{
		if (str[index] == ' ')
		{
			index++;
			continue;
		}

		if (str[index] == '+') 
		{
			index++;
			break;
		}
		
		if (str[index] == '-')
		{
			sign = -1;
			index++;
			break;
		}

		if (char.IsDigit(str[index])) 
		{
			break;
		}
		
		return res;
	}

	while (index < str.Length)
	{
		if (!(char.IsDigit(str[index])))
		{
			return res * sign;
		}

		if (sign == 1)
		{
			if (res < int.MaxValue / 10 || (res == int.MaxValue / 10 && str[index] - '0' <= 7))
			{
				res = res * 10 + (str[index++] - '0');
				continue;
			}
			else 
			{
				return int.MaxValue;
			}
		}
		else if (sign == -1)
		{
			if (res < int.MaxValue / 10 || (res == int.MaxValue / 10 && str[index] - '0' <= 8))
			{
				res = res * 10 + (str[index++] - '0');
				continue;
			}
			else 
			{
				return int.MinValue;
			}
		}
	}
	
	return res * sign;
}