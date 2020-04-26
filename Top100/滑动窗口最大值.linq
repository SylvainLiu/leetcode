<Query Kind="Program" />

void Main()
{
	MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7}, 3).Dump();
}

public int[] MaxSlidingWindow(int[] nums, int k)
{
	if (nums.Length == 0) return new int[] { };
	var head = new Node(int.MaxValue);
	var tail = new Node(int.MinValue);
	head.next = tail;
	tail.pre = head;

	void AddEnd(int number)
	{
		var temp = new Node(number);
		var end = tail.pre;
		end.next = temp;
		tail.pre = temp;

		temp.pre = end;
		temp.next = tail;
	}

	void RemoveEnd()
	{
		var end = tail.pre.pre;
		end.next = tail;
		tail.pre = end;
	}

	void RemoveHead()
	{
		var start = head.next.next;
		head.next = start;
		start.pre = head;
	}

	var res = new int[nums.Length - k + 1];

	var i = 0;
	while (i < k)
	{
		while (nums[i] > tail.pre.val) RemoveEnd();
		AddEnd(nums[i]);
		i++;
	}

	res[0] = head.next.val;
	for (i = 1; i < nums.Length - k + 1; i++)
	{
		while (nums[i + k - 1] > tail.pre.val) RemoveEnd();
		AddEnd(nums[i + k - 1]);
		if (head.next.val == nums[i - 1]) RemoveHead();
		
		res[i] = head.next.val;
	}
	
	return res;
}

public class Node
{
	public Node pre;
	public Node next;
	public int val;

	public Node(int v) 
	{
		val = v;
	}
}

// Define other methods and classes here
//public int[] MaxSlidingWindow(int[] nums, int k)
//{
//	if (nums.Length == 0) return new int[] {};
//
//	var dic = new SortedDictionary<int, int>();
//	var index = 0;
//	while (index < k) 
//	{
//		if (dic.ContainsKey(nums[index])) dic[nums[index]]++;
//		else dic.Add(nums[index], 1);
//		index++;
//	}
//	
//	var res = new int[nums.Length - k + 1];
//	res[0] = dic.Last().Key;
//	for (var i = 1; i < nums.Length - k + 1; i++)
//	{
//		if (dic[nums[i - 1]] == 1) dic.Remove(nums[i - 1]);
//		else dic[nums[i - 1]]--;
//		
//		if (dic.ContainsKey(nums[i + k - 1])) dic[nums[i + k - 1]]++;
//		else dic.Add(nums[i + k - 1], 1);
//		
//		res[i] = dic.Last().Key;
//	}
//	
//	return res;
//}