<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
{
	var res = new List<IList<int>>();
	if (root == null) return res;
	
	var q = new List<TreeNode>();
	q.Add(root);
	var toRight = true;
	
	while (q.Any()) 
	{
		var tempq = new List<TreeNode>();
		var temp = new int[q.Count()];
		
		for (var i = 0; i < q.Count(); i++)
		{
			if (q[i].left != null) tempq.Add(q[i].left);
			if (q[i].right != null) tempq.Add(q[i].right);

			if (toRight) temp[i] = q[i].val;
			else temp[q.Count() - i - 1] = q[i].val;
		}
		
		toRight = !toRight;
		res.Add(temp);
		q = tempq;
	}
	
	return res;
}