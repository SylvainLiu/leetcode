<Query Kind="Program" />

void Main()
{
	CanFinish(3, new int[2][] { new[] { 0, 1 }, new[] { 1, 0 }}).Dump();
}

public bool CanFinish(int numCourses, int[][] prerequisites) 
{
	var graph = new Dictionary<int, List<int>>();
	foreach (var pre in prerequisites) 
	{
		if (graph.ContainsKey(pre[1])) graph[pre[1]].Add(pre[0]);
		else graph.Add(pre[1], new List<int>{ pre[0] });
	}
	var flag = new int[numCourses];
	
	for (var i = 0; i < numCourses; i++) 
	{
		if (!Search(graph, flag, i)) return false;
	}
	
	return true;
}

public bool Search(Dictionary<int, List<int>> graph, int[] flag, int start)
{
	if (!graph.ContainsKey(start)) { flag[start] = -1; return true; }
	if (flag[start] == 1) return false;
	if (flag[start] == -1) return true;

	flag[start] = 1;
	foreach (var vertex in graph[start]) 
	{
		if (!Search(graph, flag, vertex)) return false;
	}
	flag[start] = -1;
	return true;
}


//public bool CanFinish(int numCourses, int[][] prerequisites)
//{
//	if (numCourses == 0) return true;
//	
//	var indegrees = new int[numCourses];
//	var graph = new Dictionary<int, List<int>>();
//	for (var i = 0; i < prerequisites.Length; i++)
//	{
//		if (!graph.ContainsKey(prerequisites[i][1]))
//		{
//			graph.Add(prerequisites[i][1], new List<int>());
//		}
//		graph[prerequisites[i][1]].Add(prerequisites[i][0]);
//		indegrees[prerequisites[i][0]]++;
//	}
//
//	var queue = new Queue<int>();
//	for (var i = 0; i < numCourses; i++)
//	{
//		if (indegrees[i] == 0) { queue.Enqueue(i);}
//	}
//
//	while (queue.Any()) 
//	{
//		var temp = queue.Dequeue();
//		numCourses--;
//		if(graph.ContainsKey(temp))
//		{
//			foreach (var node in graph[temp])
//				if (--indegrees[node] == 0) { queue.Enqueue(node); }
//		}
//	}
//
//	return numCourses == 0;
//}


//public bool CanFinish(int numCourses, int[][] prerequisites)
//{
//	if (numCourses == 0) return true;
//
//	graph = new Dictionary<int, HashSet<int>>();
//	for (var i = 0; i < prerequisites.Length; i++)
//	{
//		if (!graph.ContainsKey(prerequisites[i][0]))
//		{
//			graph.Add(prerequisites[i][0], new HashSet<int>());
//		}
//		graph[prerequisites[i][0]].Add(prerequisites[i][1]);
//	}
//
//	var visited = new HashSet<int>();
//	foreach(var pair in graph)
//	{
//		if (!BFS(pair.Key, visited, numCourses)) return false;
//	}
//	return true;
//}
//
//public Dictionary<int, HashSet<int>> graph;
//public int max;
//public bool BFS(int a, HashSet<int> visited, int target)
//{
//	if (!graph.ContainsKey(a)) { return true; }
//	if (visited.Contains(a)) { return false; }
//	
//	visited.Add(a);
//	foreach (var b in graph[a])
//	{
//		if (!BFS(b, visited, target)) return false;
//	}
//
//	visited.Remove(a);
//	return true;
//}