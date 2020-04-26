<Query Kind="Program" />

void Main()
{
	var sut = MaxProfit(new int[] {7,1,5,3,6,4}).Dump();
}

public int MaxProfit(int[] prices)
{
	var max = 0;
	for (var i = 1; i < prices.Length; i++)
	{
		if (prices[i - 1] < prices[i]) 
		{
			max += prices[i] - prices[i - 1];
		}
	}
	
	return max;
}