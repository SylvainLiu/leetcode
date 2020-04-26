<Query Kind="Program" />

void Main()
{
	Generate(5).Dump();
}

// Define other methods and classes here
public IList<IList<int>> Generate(int numRows)
{
	var res = new List<IList<int>>();
	if (numRows == 0) return res;

	res.Add(new List<int> { 1 });
	if (numRows == 1) return res;

	var currentRaw = 2;
	while (currentRaw <= numRows) 
	{
		var size = currentRaw;
		var currentList = new List<int>();
		currentList.Add(1);
		for (var i = 1; i < size - 1; i++) 
		{
			currentList.Add(res[currentRaw - 2][i - 1] + res[currentRaw - 2][i]);
		}
		currentList.Add(1);

		res.Add(currentList);
		currentRaw++;
	}
	
	return res;
}