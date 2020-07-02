<Query Kind="Program" />

void Main()
{
	Trie trie = new Trie();

	trie.Insert("apple")	;
	trie.Search("apple")	.Dump();
	trie.Search("app")		.Dump();
	trie.StartsWith("app")  .Dump();
	trie.Insert("app")		;
	trie.Search("app")		.Dump();
}

public class Trie
{
	private Node head = new Node('0');

	public Trie() {}

	public void Insert(string word)
	{
		var current = head;
		for (var i = 0; i < word.Length; i++)
		{
			if (current.next[word[i] - 'a'] == null)
			{
				current.next[word[i] - 'a'] = new Node(word[i]);
			}
			current = current.next[word[i] - 'a'];
		}

		current.isEnd = true;
	}

	public bool Search(string word)
	{
		var current = head;
		for (var i = 0; i < word.Length; i++)
		{
			if (current.next[word[i] - 'a'] == null) return false;
			else current = current.next[word[i] - 'a'];
		}
		return current.isEnd;
	}

	public bool StartsWith(string prefix)
	{
		var current = head;
		for (var i = 0; i < prefix.Length; i++)
		{
			if (current.next[prefix[i] - 'a'] == null) return false;
			else current = current.next[prefix[i] - 'a'];
		}
		return true;
	}

	public class Node 
	{
		public char value;
		public bool isEnd;
		public Node[] next = new Node[26];
		public Node(char val)
		{
			value = val;
		}
	}
}