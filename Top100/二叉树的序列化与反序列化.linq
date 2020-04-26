<Query Kind="Program" />

void Main()
{
	var node = new TreeNode(1);
	node.left = new TreeNode(2);
	node.right = new TreeNode(3);
	node.right.left = new TreeNode(4);
	node.right.right = new TreeNode(5);
	
	var test = new Codec();
	test.deserialize(test.serialize(node).Dump()).Dump();
}

// Define other methods and classes here
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Codec
{
	private StringBuilder builder = new StringBuilder();

	public string serialize(TreeNode root)
	{
		HelpS(root);
		return builder.ToString();
	}
	// Encodes a tree to a single string.
	private void HelpS(TreeNode root)
	{
		if (root == null) 
		{
			builder.Append("null,");
			return;
		}

		builder.Append(root.val + ",");
		HelpS(root.left);
		HelpS(root.right);
	}

	// Decodes your encoded data to tree.
	public TreeNode deserialize(string data)
	{
		var array = data.Split(',');
		var index = 0;
		return HelpD(array, ref index);
	}
	
	private TreeNode HelpD(string[] data, ref int i)
	{
		if (data[i] == "null") { i += 1; return null;}
		
		var node = new TreeNode(int.Parse(data[i]));
		i += 1;
		
		node.left = HelpD(data, ref i);
		node.right = HelpD(data, ref i);
		
		return node;
	}
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));