<Query Kind="Program" />

void Main()
{
	
}

public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
{
	if (t1 == null && t2 == null) return null;
	if (t1 == null ^ t2 == null) return t1 == null ? t2 : t1;

	var stack = new Stack<(TreeNode, TreeNode)>();
	stack.Push((t1, t2));
	while (stack.Any())
	{
		var temp = stack.Pop();
		t1.val += t2.val;

		if (temp.Item1.left == null ^ temp.Item2.left == null)
		{
			temp.Item1.left = temp.Item1.left == null 
				? temp.Item2.left : temp.Item1.left;
		}
		else if (temp.Item1.left != null && temp.Item2.left != null)
		{
			stack.Push((temp.Item1.left, temp.Item2.left));
		}

		if (temp.Item1.right == null ^ temp.Item2.right == null)
		{
			temp.Item1.right = temp.Item1.right == null
				? temp.Item2.right : temp.Item1.right;
		}
		else if (temp.Item1.right != null && temp.Item2.right != null)
		{
			stack.Push((temp.Item1.right, temp.Item2.right));
		}
	}
	
	return t1;
}

// Define other methods and classes here
//public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
//{
//	if (t1== null && t2 == null) return null;
//	if (t1 == null ^ t2 == null) return t1 == null ? t1 : t2;
//
//	var node = new TreeNode(t1.val + t2.val);
//	node.left = MergeTrees(t1.left, t2.left);
//	node.right = MergeTrees(t1.right, t2.right);
//	
//	return node;
//}
//
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}