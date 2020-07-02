<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public class RandomizedSet
{
	public Dictionary<int, int> hash;
	public List<int> array;
	
	public RandomizedSet()
	{
		array = new List<int>();		
		hash = new Dictionary<int, int>();
	}

	public bool Insert(int val)
	{
		if (hash.ContainsKey(val)) return false;
		array.Add(val);
		hash.Add(val, array.Count() - 1);
		return true;
	}

	public bool Remove(int val)
	{
		if (!hash.ContainsKey(val)) return false;
		
		var index = hash[val];
		var last = array[array.Count() - 1];
		
		var temp = array[index];
		array[index] = last;
		array[array.Count() - 1] = temp;
		
		hash[last] = index;

		array.RemoveAt(array.Count() - 1);
		hash.Remove(val);
		return true;
	}

	public int GetRandom()
	{
		var random = new Random().Next(array.Count() + 1);
		return array[random];
	}
}