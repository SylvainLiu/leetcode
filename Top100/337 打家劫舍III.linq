<Query Kind="Program" />

void Main()
{
	var tree = new TreeNode(3);
	tree.left = new TreeNode(4);
	tree.left.left = new TreeNode(1);
	tree.left.right = new TreeNode(3);
	tree.right = new TreeNode(5);
	tree.right.right = new TreeNode(1);
	
	Rob(tree).Dump();
}

// Define other methods and classes here
public int Rob(TreeNode root)
{
	if (root == null) return 0;
	return Helper(root, true);
}

public Dictionary<(TreeNode, bool), int> m_record = new Dictionary<(TreeNode, bool), int>();
public int Helper(TreeNode node, bool parent)
{
	if (node == null) return 0;
	if (m_record.ContainsKey((node, parent))) return m_record[(node, parent)];
	
	var fromParent = parent ? node.val + Helper(node.left, false) + Helper(node.right, false) : 0;
	var fromChild = Helper(node.left, true) + Helper(node.right, true);

	var res = Math.Max(fromParent, fromChild);
	m_record.Add((node, parent), res);
	return res;
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}