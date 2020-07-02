<Query Kind="Program" />

void Main()
{
}

// Define other methods and classes here
public string FrequencySort(string s)
{
	if (string.IsNullOrEmpty(s)) return s;

	var hash = s.ToLookup(x => x).ToDictionary(x => x.Key, x => x.Count());

	var array = new string[s.Length + 1];
	foreach (var item in hash)
	{
		var temp = new string(Enumerable.Repeat(item.Key, item.Value).ToArray());
		array[item.Value] += temp;
	}

	var res = "";
	for (var i = hash.Count(); i > 0; i--) 
	{
		res += array[i];
	}
	
	return res;
}