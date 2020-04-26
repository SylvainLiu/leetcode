<Query Kind="Program" />

void Main()
{
	var cache = new LRUCache(2);
	cache.Put(2, 1);
	cache.Put(1, 1);
	cache.Put(2, 3);
	cache.Put(4, 1);
	cache.Get(1).Dump();
	cache.Get(2).Dump();
}

public class LRUCache 
{
	private int m_capacity;
	private Dictionary<int, Node> cache;
	private Node head;
	private Node tail;
	
	public LRUCache(int capacity) 
	{
		m_capacity = capacity;
		head = new Node(-1, -1);
		tail = new Node(-1, -1);
		head.post = tail;
		tail.pre = head;
		cache = new Dictionary<int, Node>();
	}

	public int Get(int key)
	{
		if (!cache.ContainsKey(key)) return -1;
		
		var node = cache[key];
		node.pre.RemoveAfter();
		node.Insert(tail.pre, tail);
		return node.Value;
	}

	public void Put(int key, int value)
	{
		if (cache.ContainsKey(key))
		{
			var node1 = cache[key];
			node1.Value = value;

			node1.pre.RemoveAfter();
			node1.Insert(tail.pre, tail);
			return;
		}
		
		var node = new Node(key, value);
		cache.Add(key, node);
		node.Insert(tail.pre, tail);

		if (cache.Count() > m_capacity) 
		{
			cache.Remove(head.RemoveAfter().Key);
		}
	}
	
	private class Node
	{
		public int Key;
		public int Value;
		public Node pre;
		public Node post;
		public Node(int key, int val) 
		{
			Key = key;
			Value = val;
		}
		public void Insert(Node before, Node after)
		{
			before.post = this;
			after.pre = this;
			pre = before;
			post = after;
		}

		public Node RemoveAfter()
		{
			var temp = this.post;
			var after = this.post.post;
			this.post = after;
			after.pre = this;
			return temp;
		}
	}
}