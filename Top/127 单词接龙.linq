<Query Kind="Program" />

void Main()
{
	LadderLength("a", "c", new List<string> {"a", "b", "c"}).Dump();
}

// Define other methods and classes here
public int LadderLength(string beginWord, string endWord, IList<string> wordList)
{
	if (!wordList.Contains(endWord)) return 0;
	var hash = new Dictionary<string, List<string>>();

	for (var i = 0; i < wordList.Count(); i++)
	{
		for (var j = 0; j < wordList[i].Length; j++)
		{
			var temp = wordList[i].Substring(0, j) + '*' + wordList[i].Substring(j + 1, wordList[i].Length - j - 1);
			if (hash.ContainsKey(temp)) hash[temp].Add(wordList[i]);
			else hash.Add(temp, new List<string> { wordList[i] });
		}
	}

	var visited1 = new Dictionary<string, int>();
	var visited2 = new Dictionary<string, int>();
	visited1.Add(beginWord, 1);
	visited2.Add(endWord, 1);
	var q1 = new Queue<(string, int)>();
	var q2 = new Queue<(string, int)>();
	q1.Enqueue((beginWord, 1));
	q2.Enqueue((endWord, 1));

	while (q1.Any() && q2.Any()) 
	{
		var ans = Search(hash, q1, visited1, visited2);
		if (ans != -1) 
		{
			return ans;
		}

		ans = Search(hash, q2, visited2, visited1);
		if (ans != -1)
		{
			return ans;
		}
	}

	return 0;
}

public int Search(Dictionary<string, List<string>> hash, Queue<(string, int)> q, Dictionary<string, int> visited1, Dictionary<string, int> visited2)
{
	var item = q.Dequeue();
	var word = item.Item1;
	var level = item.Item2;

	for (var i = 0; i < word.Length; i++)
	{
		var temp = word.Substring(0, i) + '*' + word.Substring(i + 1, word.Length - i - 1);
		if (!hash.ContainsKey(temp)) continue;

		for (var j = 0; j < hash[temp].Count(); j++)
		{
			var candidate = hash[temp][j];

			if (visited2.ContainsKey(candidate)) return level + visited2[candidate];
			if (visited1.ContainsKey(candidate)) continue;

			visited1.Add(candidate, level + 1);
			q.Enqueue((candidate, level + 1));
		}
	}
	
	return -1;
}