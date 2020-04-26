<Query Kind="Program" />

void Main()
{
	LetterCombinations("23").Dump();
}

//public IList<string> LetterCombinations(string digits)
//{
//	if (digits == "") return new List<string>();
//
//	var dic = new string[] {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
//
//	var queue = new Queue<string>();
//	queue.Enqueue("");
//	var index = 0;
//	while (index < digits.Length) 
//	{
//		var limit = queue.Count();
//		for (var i = 0; i < limit; i++)
//		{
//			var item = queue.Dequeue();
//			
//			foreach (var letter in dic[digits[index] - '2'])
//				queue.Enqueue(item + letter);
//		}
//		index++;
//	}
//	
//	return queue.ToList();
//}

public IList<string> LetterCombinations(string digits)
{
	var res = new List<string>();
	if (string.IsNullOrEmpty(digits)) return res;
	
	var dic = new string[] {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
	BackTrack(dic, res, digits, 0, new StringBuilder());
	return res;
}

void BackTrack(string[] dic, List<string> res, string digits, int i, StringBuilder current) 
{
	if (i == digits.Length) { res.Add(current.ToString());	return;}

	var key = dic[digits[i] - '2'];
	for (var j = 0; j < key.Length; j++) 
	{
		BackTrack(dic, res, digits, i + 1, current.Append(key[j]));
		current.Remove(current.Length - 1, 1);
	}
}