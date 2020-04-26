<Query Kind="Program" />

void Main()
{
	var s = new Solution(new int[] { 1, 2, 3, 4, 5, 6 });
	var shuffle = s.Shuffle().Dump();
	var reset = s.Reset().Dump();
}
public class Solution
{
	private int[] m_origin;
	
	public Solution(int[] nums)
	{
		m_origin = nums.Select(x => x).ToArray();
	}

	/** Resets the array to its original configuration and return it. */
	public int[] Reset()
	{
		return m_origin.Select(x => x).ToArray();
	}

	/** Returns a random shuffling of the array. */
	public int[] Shuffle()
	{
		var list = m_origin.ToList();
		var res = new List<int>();
		var random = new Random();
		for (var i = 0; i < m_origin.Length; i++) 
		{
			var index = random.Next(list.Count());
			res.Add(list[index]);
			list.RemoveAt(index);
		}
		
		return res.ToArray();
	}
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
