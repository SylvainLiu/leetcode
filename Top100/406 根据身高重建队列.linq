<Query Kind="Program" />

void Main()
{
	var array = new int[6][] { new int[] {7,0}, new int[] {4,4}, new int[] {7,1}, new int[] {5,0}, new int[] {6,1}, new int[] {5,2}};
	ReconstructQueue(array).Dump();
}

public int[][] ReconstructQueue(int[][] people)
{
	if (people.Length <= 1) return people;
	people = people.OrderByDescending(x => x[0] - 0.0001 *x[1]).ToArray();
	
	var res = new List<int[]>();
	var index = 0;
	while (index < people.Length) 
	{
		if (people[index][1] >= res.Count())
			res.Add(people[index]);
		else
			res.Insert(people[index][1], people[index]);
			
		index++;
	}
	
	return res.ToArray();
}

//public int[][] ReconstructQueue(int[][] people)
//{
//	for (var i = 0; i < people.Length; i++)
//		for (var j = i + 1; j < people.Length; j++)
//		{
//			if (people[j][0] > people[i][0] || (people[j][0] == people[i][0] && people[i][1] > people[j][1]))
//			{
//				var temp = people[j];
//				people[j] = people[i];
//				people[i] = temp;
//			}
//		}
//
//	var list = new LinkedList<int[]>();
//	for (var i = 0; i < people.Length; i++)
//	{
//		var current = list.First;
//		for (var j = 0; j < people[i][1]; j++) 
//		{
//			current = current.Next;
//		}
//		if (current == null)
//		{
//			list.AddLast(people[i]);
//			continue;
//		}
//		list.AddBefore(current, people[i]);
//	}
//	
//	return list.ToArray();
//}