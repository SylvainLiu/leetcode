<Query Kind="Program" />

void Main()
{
	
}

public IList<int> InorderTraversal(TreeNode root)
{
	var res = new List<int>();
	var stack = new Stack<TreeNode>();
	var current = root;

	while (stack.Any() || current != null)
	{
		while (current != null) 
		{
			stack.Push(current);
			current = current.left;
		}
		
		current = stack.Pop();
		res.Add(current.val);
		current = current.right;
	}
	
	return res;
}

//public IList<int> InorderTraversal(TreeNode root)
//{
//	if (root == null) return res;
//
//	InorderTraversal(root.left);
//	res.Add(root.val);
//	InorderTraversal(root.right);
//
//	return res;
//}
//public List<int> res = new List<int>();

//public IList<int> InorderTraversal(TreeNode root)
//{
//	var res = new List<int>();
//	if (root == null) return res;
//	
//	InOrder(root, res);
//	return res;
//}
//
//public void InOrder(TreeNode node, List<int> res)
//{
//	if (node == null) return;
//	
//	InOrder(node.left, res);
//	res.Add(node.val);
//	InOrder(node.right, res);
//}


// Define other methods and classes here
//public IList<int> InorderTraversal(TreeNode root)
//{
//	if (root == null) return new List<int>();
//	
//	var stack = new Stack<TreeNode>();
//	var res = new List<int>();
//	while (stack.Any() || root != null)
//	{
//		while (root != null) 
//		{
//			stack.Push(root);
//			root = root.left;
//		}
//		
//		root = stack.Pop();
//		res.Add(root.val);
//		root = root.right;
//	}
//	
//	return res;
//}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}