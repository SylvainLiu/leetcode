<Query Kind="Program" />

void Main()
{
	
}

public int DiameterOfBinaryTree(TreeNode root)
{
	if (root == null) return 0;
	Depth(root);
	return diameter;	
}
public int diameter;
public int Depth(TreeNode node)
{
	if (node == null) return 0;
	
	var l = Depth(node.left);
	var r = Depth(node.right);
	diameter = Math.Max(diameter, l + r + 1);
	return 1 + Math.Max(l, r);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}