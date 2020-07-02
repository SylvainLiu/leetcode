<Query Kind="Program" />

void Main()
{
	
}

public int[] FindOrder(int numCourses, int[][] prerequisites)
{
	if (numCourses == 0) return new int[0];

	var graph = new Dictionary<int, List<int>>();
	var indegres = new int[numCourses];
	for (var i = 0; i < prerequisites.Length; i++)
	{
		var pre = prerequisites[i];
		if (graph.ContainsKey(pre[1])) graph[pre[1]].Add(pre[0]);
		else graph.Add(pre[1], new List<int> { pre[0] });
		
		indegres[pre[0]]++;
	}

	var q = new Queue<int>();
	for (var i = 0; i < numCourses; i++) 
	{
		if (indegres[i] == 0) q.Enqueue(i);
	}

	var res = new List<int>();
	while (q.Any()) 
	{
		var cur = q.Dequeue();
		res.Add(cur);
		numCourses--;

		if (!graph.ContainsKey(cur)) continue;

		foreach (var item in graph[cur])
			if (--indegres[item] == 0) q.Enqueue(item);
	}

	if (numCourses == 0) return res.ToArray();
	else return new int[] {};
}

// Define other methods and classes here
//public bool Search(Dictionary<int, List<int>> graph, int start, int[] visited, Stack<int> res)
//{
//	if (visited[start] == -1) return true;
//	if (!graph.ContainsKey(start))
//	{
//		visited[start] = -1;
//		res.Push(start);
//		return true;
//	}
//	if (visited[start] == 1) return false;
//
//	visited[start] = 1;
//	foreach (var vertex in graph[start])
//	{
//		if (!Search(graph, vertex, visited, res)) return false;
//	}
//	res.Push(start);
//	visited[start] = -1;
//	return true;
//}
//
//public int[] FindOrder(int numCourses, int[][] prerequisites)
//{
//	if (numCourses == 0) return new int[0];
//
//	var graph = new Dictionary<int, List<int>>();
//	for (var i = 0; i < prerequisites.Length; i++)
//	{
//		var pre = prerequisites[i];
//		if (graph.ContainsKey(pre[1])) graph[pre[1]].Add(pre[0]);
//		else graph.Add(pre[1], new List<int> { pre[0] });
//	}
//
//	var visited = new int[numCourses];
//	var res = new Stack<int>();
//	for (var i = 0; i < numCourses; i++)
//	{
//		if (!Search(graph, i, visited, res)) return new int[0];
//	}
//
//	return res.ToArray();
//}