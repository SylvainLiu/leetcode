<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int KthSmallest(TreeNode root, int k)
{
	if (root == null)
		throw new Exception();
	if (k == 0)
		throw new Exception();
	
	var node = root;
	var stack = new Stack<TreeNode>();

	while (node != null || stack.Any())
	{
		while (node != null) 
		{
			stack.Push(node);
			node = node.left;
		}
		
		node = stack.Pop();
		k--;
		
		if (k == 0) 
		{
			return node.val;	
		}
				
		node = node.right;
	}
	
	return -1;
}

public class TreeNode
{
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}
 }
