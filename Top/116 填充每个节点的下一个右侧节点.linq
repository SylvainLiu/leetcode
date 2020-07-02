<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public Node Connect(Node root)
{
	if (root == null) return null;
	
	var q = new Queue<Node>();
	q.Enqueue(root);
	while (q.Any()) 
	{
		var size = q.Count();
		var current = 0;
		var pre = q.Dequeue();
		q.Enqueue(pre.left);
		q.Enqueue(pre.right);

		while (current < size - 1) 
		{
			var cur = q.Dequeue();
			q.Enqueue(cur.left);
			q.Enqueue(cur.right);
			pre.next = cur;
			pre = pre.next;
			current++;
		}
		
		if (pre.left == null) break;
	}
	
	return root;
}

public class Node
{
	public int val;
	public Node left;
	public Node right;
	public Node next;

	public Node() { }

	public Node(int _val)
	{
		val = _val;
	}

	public Node(int _val, Node _left, Node _right, Node _next)
	{
		val = _val;
		left = _left;
		right = _right;
		next = _next;
	}
}