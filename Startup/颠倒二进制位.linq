<Query Kind="Program" />

void Main()
{
	reverseBits(43261596).Dump();
}

// Define other methods and classes here
public uint reverseBits(uint n)
{
	var res = (uint)0;

	var index = 31;
	while (n != 0)
	{
		if ((n & 1) == 1) res += (uint)1 << index;
		
		n >>= 1;
		index--;
	}
	
	return res;
}