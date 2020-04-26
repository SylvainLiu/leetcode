<Query Kind="Program" />

void Main()
{
	
}

public void Flatten(TreeNode root)
{
	if (root == null) return;
	var stack = new Stack<TreeNode>();
	
	var cur = root;
	TreeNode pre = null;

	while (stack.Any() || cur != null)
	{
		while (cur != null) 
		{
			stack.Push(cur);
			cur = cur.right;
		}

		cur = stack.Peek();
		if (cur.left == null || cur.left == pre) 
		{
			stack.Pop();
			cur.right = pre;
			cur.left = null;
			pre = cur;
			cur = null;
		}
		else 
		{
			cur = cur.left;
		}
	}
}

//private TreeNode pre = null;
//
//public void flatten(TreeNode root)
//{
//	if (root == null)
//		return;
//	flatten(root.right);
//	flatten(root.left);
//	root.right = pre;
//	root.left = null;
//	pre = root;
//}

//public void Flatten(TreeNode root)
//{
//	Build(root);
//}
//
//public TreeNode Build(TreeNode node) 
//{
//	if (node == null || node.left == null && node.right == null) return node;
//
//	node.left = Build(node.left);
//	node.right = Build(node.right);
//	
//	var pre = node.left;
//	if (pre != null)
//	{
//		while (pre.right != null)
//			pre = pre.right;
//
//		var right = node.right;
//		node.right = node.left;
//		pre.right = right;
//		node.left = null;
//	}
//	
//	return node;
//}

//public void Flatten(TreeNode root)
//{
//	if (root == null) return;
//	var stack = new Stack<TreeNode>();
//	stack.Push(root);
//
//	var pre = new TreeNode(-1);
//	while (stack.Any()) 
//	{
//		pre.left = null;
//		pre.right = stack.Pop();
//		pre = pre.right;
//
//		if (pre.right != null) 
//		{
//			stack.Push(pre.right);
//		}
//		if (pre.left != null)
//		{
//			stack.Push(pre.left);
//		}
//	}
//}

// Define other methods and classes here
//public void Flatten(TreeNode root)
//{
//	if (root == null) return;
//	
//	var res = new List<TreeNode>();
//	dfs(root, res);
//
//	var head = res.First();
//	for (var i = 1; i < res.Count(); i++)
//	{
//		head.left = null;
//		head.right = res[i];
//		head = head.right;
//	}
//}
//
//void dfs(TreeNode node, List<TreeNode> res)
//{
//	if (node == null) return;
//
//	res.Add(node);
//	dfs(node.left, res);
//	dfs(node.right, res);
//}


public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}