<Query Kind="Program" />

void Main()
{
	GenerateParenthesis(3).Dump();
}

public IList<string> GenerateParenthesis(int n)
{
	var res = new List<string>();
	if (n == 0) return res;
	
	var queue = new Queue<(string, int, int)>();
	queue.Enqueue(("", n, n));

	while (queue.Any()) 
	{
		var temp = queue.Dequeue();
		if (temp.Item2 > temp.Item3) continue;
		if (temp.Item2 + temp.Item3 == 0) res.Add(temp.Item1);

		if (temp.Item2 > 0) 
		{
			var item1 = (temp.Item1 + "(", temp.Item2 - 1, temp.Item3);
			queue.Enqueue(item1);
		}

		var item2 = (temp.Item1 + ")", temp.Item2, temp.Item3 - 1);
		queue.Enqueue(item2);
	}
	
	return res;
}

//public IList<string> GenerateParenthesis(int n)
//{
//	var res = new List<string>();
//	if (n == 0) return res;
//	BT(n,n,res,new StringBuilder());
//	return res;
//}
//
//public void BT(int left, int right, List<string> res, StringBuilder cur) 
//{
//	if (left > right) return;
//	if (left + right == 0) { res.Add(cur.ToString()); return; }
//	
//	if (left > 0) 
//	{
//		BT(left - 1, right, res, cur.Append('('));
//		cur.Remove(cur.Length - 1, 1);
//	}
//
//	BT(left, right - 1, res, cur.Append(')'));
//	cur.Remove(cur.Length - 1, 1);
//}

// Define other methods and classes here
//public IList<string> GenerateParenthesis(int n)
//{
//	if (n <= 0) return new List<string>();
//	
//	var res = new List<string>();
//	var current = "";
//	BackTrack(res, current, 0, 0, n);
//	return res;
//}
//
//public void BackTrack(IList<string> res, string current, int left, int right, int limit)
//{
//	if (left == limit)
//	{
//		while (limit - right > 0)
//		{
//			current += ")";
//			right ++;
//		}
//		res.Add(current);
//		return;
//	}
//
//	BackTrack(res, current + "(", left + 1, right, limit);
//	if(right < left) BackTrack(res, current + ")", left, right + 1, limit);
//}