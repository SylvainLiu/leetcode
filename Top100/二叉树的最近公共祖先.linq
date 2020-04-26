<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
	if (root == null) return null;

	var stack = new Stack<TreeNode>();
	stack.Push(root);
	var parents = new Dictionary<TreeNode, TreeNode>() { { root, null}};

	while (!parents.ContainsKey(p) || !parents.ContainsKey(q))
	{
		var current = stack.Pop();
		if (current.left != null) 
		{
			stack.Push(current.left);
			parents.Add(current.left, current);
		}
		if (current.right != null)
		{
			stack.Push(current.right);
			parents.Add(current.right, current);
		}
	}

	var set = new HashSet<TreeNode>();
	while (p != null) 
	{
		set.Add(p);
		p = parents[p];
	}

	while (!set.Contains(q))
	{
		q = parents[q];
	}
	
	return q;
}

//public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
//{
//	if (root == null) return null;
//	
//	Helper(root, p, q);
//	return res;
//}
//
//public TreeNode res;
//public bool Helper(TreeNode current, TreeNode p, TreeNode q) 
//{
//	if (current == null) return false;
//
//	var left = Helper(current.left, p, q) ? 1 : 0;
//	var right = Helper(current.right, p, q) ? 1 : 0;
//	var mid = (current == p || current == q) ? 1 : 0;
//
//	if (mid + left + right >= 2)
//	{
//		res = current;
//	}
//
//	return (mid + left + right > 0);
//}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}