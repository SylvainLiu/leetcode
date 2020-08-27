<Query Kind="Program" />

void Main()
{
	
}

public TreeNode ConvertBST(TreeNode root)
{
	if (root == null) return null;
	
	var stack = new Stack<TreeNode>();	
	var current = root;
	var sum = 0;
	while (stack.Any() || current != null)
	{
		while (current != null)
		{
			stack.Push(current);
			current = current.right;
		}
		
		current = stack.Pop();
		
		sum += current.val;
		current.val = sum;

		current = current.left;
	}
	
	return root;
}

//private int sum;
//public TreeNode ConvertBST(TreeNode root)
//{
//	if (root == null) return null;
//
//	ConvertBST(root.right);
//	sum += root.val;
//	root.val = sum;
//	ConvertBST(root.left);
//
//	return root;
//}

// Define other methods and classes here
//public TreeNode ConvertBST(TreeNode root)
//{
//	if (root == null) return root;
//
//	ConvertBST(root.right);
//	sum += root.val;
//	root.val = sum;
//	ConvertBST(root.left);
//	return root;
//}
//
//private int sum;

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}