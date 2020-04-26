<Query Kind="Program" />

//辗转相除法

//递归
string GcdOfStrings1(string str1, string str2)
{
	if (str1 + str2 != str2 + str1) return "";
	
	return str1.Substring(0, Gcd(str1.Length, str2.Length));
}

int Gcd(int a, int b) {
	return b == 0? a : Gcd (b, a%b)
}

//迭代
string GcdOfStrings2(string str1, string str2)
{
	if (str1 + str2 != str2 + str1) return "";
	var a = str1.Length;
	var b = str2.Length;
	while (b != 0)
	{
		var tmp = a;
		a = b;
		b = tmp % b;
	}
	return str1.Substring(0, a);
}