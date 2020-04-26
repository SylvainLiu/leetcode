<Query Kind="Program" />

void Main()
{
	var root = new TreeNode(1);
	root.left = new TreeNode(2);
	root.right = new TreeNode(3);
//	root.left.left = new TreeNode(4);
//	root.left.right = new TreeNode(3);
//	root.right.left = new TreeNode(3);
//	root.right.right = new TreeNode(4);

	IsSymmetric(root).Dump();
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}

public bool IsSymmetric(TreeNode root)
{
	if (root == null) return true;

	return IsSymmetric(root.left, root.right);
}

public bool IsSymmetric(TreeNode left, TreeNode right) 
{
	if (left == null && right == null) return true;
	if (left == null ^ right == null) return false;

	if (left != null)
	{
		if (left.val != right.val) return false;
	}

	if (left.left == null ^ right.right == null) return false;
	if (left.right == null ^ right.left == null) return false;

	if (!IsSymmetric(left.left, right.right)) return false;
	if (!IsSymmetric(left.right, right.left)) return false;

	return true;
}

//public bool IsSymmetric(TreeNode root)
//{
//	if (root == null) return false;
//
//	var stackLeft = new Stack<TreeNode>();
//	var stackRight = new Stack<TreeNode>();
//
//	stackLeft.Push(root);
//	stackRight.Push(root);
//
//	while (stackLeft.Any()) 
//	{
//		var left = stackLeft.Pop();
//		var right = stackRight.Pop();
//
//		if (left.left == null ^ right.right == null) return false;
//		if (left.right == null ^ right.left == null) return false;
//
//		if (left.left != null)
//		{
//			if (left.left.val != right.right.val) return false;			
//			stackLeft.Push(left.left);
//			stackRight.Push(right.right);
//		}
//
//		if (left.right != null)
//		{
//			if (left.right.val != right.left.val) return false;
//			stackLeft.Push(left.right);
//			stackRight.Push(right.left);
//		}
//	}
//	
//	return true;
//}