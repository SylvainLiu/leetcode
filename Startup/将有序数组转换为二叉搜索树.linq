<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public TreeNode SortedArrayToBST(int[] nums)
{
	if (nums.Length == 0) return null;

	var queue = new Queue<Record>();
	var res = new TreeNode(0);
	queue.Enqueue(new Record(res, 0, nums.Length - 1));

	while (queue.Any())
	{
		var length = queue.Count();
		for (var i = 0; i < length; i++)
		{
			var cur = queue.Dequeue();
			var middle = (cur.Left + cur.Right) / 2;

			cur.Node.val = nums[middle];
			if (cur.Left > middle - 1) { cur.Node.left = null; }
			else { cur.Node.left = new TreeNode(0); queue.Enqueue(new Record(cur.Node.left, cur.Left, middle - 1)); }

			if (cur.Right < middle + 1) { cur.Node.right = null; }
			else { cur.Node.right = new TreeNode(0); queue.Enqueue(new Record(cur.Node.right, middle + 1, cur.Right)); }
		}
	}

	return res;
}

public class Record
{
	public TreeNode Node;
	public int Left;
	public int Right;

	public Record(TreeNode node, int left, int right) 
	{
		Node = node;
		Left = left;
		Right = right;
	}
}

//public TreeNode SortedArrayToBST(int[] nums)
//{
//	return Helpers(nums, 0 , nums.Length);
//}
//
//TreeNode Helpers(int[] nums, int left, int right) 
//{
//	if(left>right) return null;
//	
//	var middle = (left + right)/2;
//	var node = new TreeNode(nums[middle]);
//	node.left = Helpers(nums, left, middle - 1);
//	node.right = Helpers(nums, middle + 1, right);
//	
//	return node;
//}


public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}
