<Query Kind="Program" />

void Main()
{
	var root = new TreeNode(2);
	root.left = new TreeNode(1);
	root.right = new TreeNode(3);

	IsValidBST(root).Dump();
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}

public bool IsValidBST(TreeNode root)
{
	var stack = new Stack<Tuple<TreeNode, int?, int?>>();
	stack.Push(new Tuple<TreeNode, int?, int?>(root, null, null));

	while (stack.Any())
	{
		var cur = stack.Pop();
		var node = cur.Item1;
		var low = cur.Item2;
		var up = cur.Item3;

		if (node == null) continue;

		if (up != null && node.val >= up) return false;
		if (low != null && node.val <= low) return false;

		stack.Push(new Tuple<TreeNode, int?, int?>(node.left, low, node.val));
		stack.Push(new Tuple<TreeNode, int?, int?>(node.right, node.val, up));
	}

	return true;
}

//{
//	return IsValidBST(root, null, null);
//}
//
//bool IsValidBST(TreeNode root, int? low, int? up)
//{
//	if (root == null) return true;
//
//	if (low != null && root.val <= low) return false;
//	if (up != null && root.val >= up) return false;
//
//	if (!IsValidBST(root.left, low, root.val)) return false;
//	if (!IsValidBST(root.right, root.val, up)) return false;
//	
//	return true;
//}