<Query Kind="Program" />

void Main()
{
	var root = new TreeNode(1);
	root.left = new TreeNode(2);
	root.right = new TreeNode(3);
	root.right.left = new TreeNode(4);
	root.right.left.left = new TreeNode(5);
	
	MaxDepth(root).Dump();
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public int MaxDepth(TreeNode root)
{
	if (root == null) return 0;

	var stack = new Stack<KeyValuePair<TreeNode, int>>();
	stack.Push(new KeyValuePair<TreeNode, int>(root, 1));

	var depth = 0;
	while (stack.Any()) 
	{
		var node = stack.Pop();

		if (node.Key != null)
		{
			depth = Math.Max(depth, node.Value);
			stack.Push(new KeyValuePair<TreeNode, int>(node.Key.left, node.Value + 1));
			stack.Push(new KeyValuePair<TreeNode, int>(node.Key.right, node.Value + 1));
		}
	}
	
	return depth;
}

//public int MaxDepth(TreeNode root)
//{
//	if (root == null) return 0;
//	
//	if (root.left == null && root.right == null) 
//	{
//		return 1;
//	}
//
//	if (root.left == null) 
//	{
//		return MaxDepth(root.right) + 1;
//	}
//
//	if (root.right == null)
//	{
//		return MaxDepth(root.left) + 1;
//	}
//
//	return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
//}