<Query Kind="Program" />

void Main()
{
	var root = new TreeNode(1);
	root.left = new TreeNode(-2);
	root.right = new TreeNode(3);
	MaxPathSum(root).Dump();
}

public int MaxPathSum(TreeNode root)
{
	MaxDepth(root);
	return sum;
}

public int sum = int.MinValue;
public int MaxDepth(TreeNode root)
{
	if (root == null) return 0;

	var left = Math.Max( MaxDepth(root.left), 0 );
	var right = Math.Max( MaxDepth(root.right), 0);
	
	sum = Math.Max(root.val + left + right, sum);
	return root.val + Math.Max(left, right);
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}