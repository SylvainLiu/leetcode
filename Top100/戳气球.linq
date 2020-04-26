<Query Kind="Program" />

void Main()
{
	MaxCoins(new int[] {7,9,8,0,7,1,3,5,5,2,3}).Dump();
}

// Define other methods and classes here
public int MaxCoins(int[] nums)
{
	var length = nums.Length;
	length += 2;
	var nums2 = new int[length];
	nums2[0] = 1;
	nums2[length - 1] = 1;
	for (var i = 1; i < length - 1; i++) 
	{
		nums2[i] = nums[i-1];
	}

	var dp = new int[length, length];
	for (var i = 0; i < length - 1; i++) 
	{
		dp[i, i + 1] = 0;
	}

	for (var len = 3; len <= length; len++)
		for (var i = 0; i + len - 1 < length; i++) 
		{
			var j = i + len -1;
			dp[i, j] = int.MinValue;
			for (var k = i + 1; k <= j - 1; k++) 
			{
				dp[i, j] = Math.Max(dp[i,j], dp[i,k] + dp[k,j] + nums2[i]*nums2[k]*nums2[j]);
			}
		}
		
	return dp[0, length-1];
}

//public int MaxCoins(int[] nums)
//{
//	if (nums.Length == 0) return 0;
//
//	var newArray = new int[nums.Length + 2];
//	newArray[0] = 1;
//	newArray[nums.Length + 1] = 1;
//	for (var i = 1; i < nums.Length + 1; i++) 
//	{
//		newArray[i] = nums[i - 1];
//	}
//	
//	var cache = new int[nums.Length + 2, nums.Length + 2];
//	return MaxCoins(newArray, 0, newArray.Length - 1, cache);
//}
//
//public int MaxCoins(int[] nums, int left, int right, int[,] cache)
//{
//	if (right - left <= 1) return 0;
//	if (cache[left, right] != 0) return cache[left, right];
//
//	var max = 0;
//	for (var i = left + 1; i < right; i++) 
//	{
//		var temp = MaxCoins(nums, left, i, cache)
//			+ MaxCoins(nums, i, right, cache) 
//			+ nums[left] * nums[i] * nums[right];
//			
//		max = Math.Max(max, temp);
//	}
//	cache[left, right] = max;
//	return max;
//}

//public int MaxCoins(int[] nums)
//{
//	if (nums.Length == 0) return 0;
//	Nums = nums;
//	
//	var head = new Node(1);
//	var tail = new Node(1);
//	var current = head;
//	Dic = new Dictionary<int, Node>();
//	for (var i = 0; i < nums.Length; i++) 
//	{
//		var temp  = new Node(nums[i]);
//		current.next = temp;
//		temp.Pre = current;
//		current = current.next;
//		Dic.Add(i, temp);
//	}
//	current.next = tail;
//	tail.Pre = current;
//	Dic.Add(-1, head);
//	Dic.Add(nums.Length, tail);
//
//	BackTrack(new bool[nums.Length], 0, 0);
//	
//	return max;
//}
//
//public int max;
//public Dictionary<int, Node> Dic;
//public int[] Nums;
//public void BackTrack(bool[] track, int current, int steps)
//{
//	if (steps == Nums.Length) 
//	{
//		max = Math.Max(max, current);
//		return;
//	}
//
//	for (var i = 0; i < Nums.Length; i++)
//	{
//		if (!track[i]) 
//		{
//			track[i] = true;
//			var pre = Dic[i].Pre;
//			var next = Dic[i].next;
//			var amount = pre.Value * Nums[i] * next.Value;
//			pre.next = next;
//			next.Pre = pre;
//			
//			BackTrack(track, current + amount, steps + 1);
//
//			pre.next = Dic[i];
//			next.Pre = Dic[i];
//			track[i] = false;
//		}
//	}
//}
//
//public class Node 
//{
//	public int Value;
//	public Node Pre;
//	public Node next;
//
//	public Node(int val) 
//	{
//		Value = val;
//	}
//}