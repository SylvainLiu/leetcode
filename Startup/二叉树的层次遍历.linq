<Query Kind="Program" />

void Main()
{
	var root = new TreeNode(2);
	root.left = new TreeNode(1);
	root.right = new TreeNode(3);
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}

public IList<IList<int>> LevelOrder(TreeNode root)
{
	if (root == null) return new List<IList<int>>();
	var res = new List<IList<int>>();

	Helpers(root, res, 0);
	
	return res;
}

void Helpers(TreeNode cur, IList < IList<int> > res, int level)
{
	if (res.Count() == level) res.Add(new List<int>());

	res[level].Add(cur.val)

	if (cur.left != null) Helpers(cur.left, res, level + 1);
	if (cur.right != null) Helpers(cur.right, res, level + 1);
}


//public IList<IList<int>> LevelOrder(TreeNode root)
//{
//	if (root == null) return new List<IList<int>>();
//
//	var queue = new Queue<TreeNode>();
//	var res = new List<IList<int>>();
//
//	queue.Enqueue(root);
//
//	while (queue.Any())
//	{
//		var temp = new List<int>();
//
//		var length = queue.Count();
//		for (var i = 0; i < length; i++)
//		{
//			var cur = queue.Dequeue();
//			temp.Add(cur.val);
//
//			if (cur.left != null) queue.Enqueue(cur.left);
//			if (cur.right != null) queue.Enqueue(cur.right);
//		}
//		
//		res.Add(temp);
//	}
//
//	return res;
//}