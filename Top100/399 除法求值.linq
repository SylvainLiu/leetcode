<Query Kind="Program" />

void Main()
{
	var eq = new List<IList<string>>();
	eq.Add(new List<string> {"a", "b"});
	eq.Add(new List<string> { "b", "c" });
	var vals = new double[] { 2, 3 };
	var queries = new List<IList<string>>();
	queries.Add(new List<string> { "a", "c" });
	queries.Add(new List<string> { "b", "a" });
	queries.Add(new List<string> { "a", "e" });
	queries.Add(new List<string> { "a", "a" });
	queries.Add(new List<string> { "x", "x" });

	CalcEquation(eq, vals, queries).Dump();
}

public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) 
{
	var res = new double[queries.Count()];
	graph = new Dictionary<string, Dictionary<string, double>>();
	for (var i = 0; i < equations.Count(); i++) 
	{
		var equation = equations[i];
		if (graph.ContainsKey(equation[0])) graph[equation[0]].Add(equation[1], values[i]);
		else graph.Add(equation[0], new Dictionary<string, double>() { { equation[1], values[i] } });

		if (graph.ContainsKey(equation[1])) graph[equation[1]].Add(equation[0], 1/values[i]);
		else graph.Add(equation[1], new Dictionary<string, double>() { { equation[0], 1/values[i] } });
	}

	for (var i = 0; i < queries.Count(); i++) 
	{
		res[i] = Search(queries[i][0], queries[i][1], new HashSet<string>());
	}
	
	return res;
}

public Dictionary<string, Dictionary<string, double>> graph;
public double Search(string current, string target, HashSet<string> record) 
{
	if (!graph.ContainsKey(current)) return -1;
	if (graph[current].ContainsKey(target)) return graph[current][target];

	record.Add(current);
	foreach (var vertex in graph[current]) 
	{
		if (record.Contains(vertex.Key)) continue;
		
		var res = Search(vertex.Key, target, record);
		if (res + 1 > double.Epsilon) return res * vertex.Value;
	}
	
	return -1;
}