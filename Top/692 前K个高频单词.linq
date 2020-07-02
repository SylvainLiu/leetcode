<Query Kind="Program" />

void Main()
{
	TopKFrequent(new string[] {"the", "day", "is", "sunny", "the", "the", "the", "the", "sunny", "is", "is"}, 2);
}

public IList<string> TopKFrequent(string[] words, int k)
{
	if (words == null || words.Length == 0) return new List<string>();
	
	var hash = words.ToLookup(x=>x).ToDictionary(x=>x.Key, x=>x.Count());
	
	return hash.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToList();
}