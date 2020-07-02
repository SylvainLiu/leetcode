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

//public class Codec
//{
//	public string serialize(TreeNode root)
//	{
//		if (root == null) return string.Empty;
//		var q = new Queue<TreeNode>();
//		q.Enqueue(root);
//		var res = new StringBuilder();
//		res.Append(root.val + ",");
//		var count = 1;
//		while (q.Any()) 
//		{
//			var next = false;
//			var temp = new StringBuilder();
//			var index = 0;
//			while (index < count) 
//			{
//				var item = q.Dequeue();
//				if (item == null)
//				{
//					q.Enqueue(null);
//					q.Enqueue(null);
//					temp.Append("null,null,");
//				}
//				else
//				{
//					q.Enqueue(item.left);
//					temp.Append(item.left == null? "null," : item.left.val + ",");
//					q.Enqueue(item.right);
//					temp.Append(item.right == null? "null," : item.right.val + ",");
//					
//					next = item.left != null || item.right != null;
//				}
//				index++;
//			}
//			
//			if (!next) break;
//			res.Append(temp.ToString());
//			count <<= 1;
//		}
//		return res.ToString();
//	}
//
//	public TreeNode deserialize(string data) 
//	{
//		if (data == string.Empty) return null;
//		
//		var vals = data.Split(',');
//		var count = 1;
//		var current = 1;
//		var root = new TreeNode(int.Parse(vals[0]));
//		var q = new Queue<TreeNode>();
//		q.Enqueue(root);
//		
//		while (current < vals.Length - 1)
//		{
//			var i = 0;
//			while (i < count) 
//			{
//				var item = q.Dequeue();
//
//				if (item == null)
//					current += 2;
//
//				var left = vals[current++];
//				if (left == "null") item.left = null;
//				else item.left = new TreeNode(int.Parse(left));
//				q.Enqueue(item.left);
//
//				var right = vals[current++];
//				if (right == "null") item.right = null;
//				else item.right = new TreeNode(int.Parse(right));
//				q.Enqueue(item.right);
//				
//				i++;
//			}
//			count <<= 1;
//		}
//		
//		return root;
//	}
//}


//public class Codec
//{
//	private StringBuilder builder = new StringBuilder();
//
//	public string serialize(TreeNode root)
//	{
//		HelpS(root);
//		return builder.ToString();
//	}
//	// Encodes a tree to a single string.
//	private void HelpS(TreeNode root)
//	{
//		if (root == null) 
//		{
//			builder.Append("null,");
//			return;
//		}
//
//		builder.Append(root.val + ",");
//		HelpS(root.left);
//		HelpS(root.right);
//	}
//
//	// Decodes your encoded data to tree.
//	public TreeNode deserialize(string data)
//	{
//		var array = data.Split(',');
//		var index = 0;
//		return HelpD(array, ref index);
//	}
//	
//	private TreeNode HelpD(string[] data, ref int i)
//	{
//		if (data[i] == "null") { i += 1; return null;}
//		
//		var node = new TreeNode(int.Parse(data[i]));
//		i += 1;
//		
//		node.left = HelpD(data, ref i);
//		node.right = HelpD(data, ref i);
//		
//		return node;
//	}
//}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));