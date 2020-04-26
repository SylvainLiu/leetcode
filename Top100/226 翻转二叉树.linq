<Query Kind="Program" />

void Main()
{
	
}

public TreeNode InvertTree(TreeNode root)
{
	if (root == null) return null;
	
	var stack = new Stack<TreeNode>();
	stack.Push(root);
	while (stack.Any())
	{
		var temp = stack.Pop();
		var left = temp.left;
		temp.left = temp.right;
		temp.right = left;

		if (temp.left != null) stack.Push(temp.left);
		if (temp.right != null) stack.Push(temp.right);
	}
	
	return root;
}

//public TreeNode InvertTree(TreeNode root)
//{
//	if (root == null) return null;
//	
//	var left = root.left;
//	root.left = InvertTree(root.right);
//	root.right = InvertTree(left);
//	
//	return root;
//}

//public TreeNode InvertTree(TreeNode root)
//
//{
//	if(root == null) return null;
//	
//	var left = root.left;
//	var right = root.right;
//	
//	root.right = InvertTree(left);
//	root.left = InvertTree(right);
//	
//	return root;
//}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}