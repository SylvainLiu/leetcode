<Query Kind="Program" />

void Main()
{
	MinStack minStack = new MinStack() .Dump();
	minStack.Push(-2)				   ;
	minStack.Push(0)				   ;
	minStack.Push(-3)				   ;
	minStack.GetMin()				   .Dump();
  	minStack.Pop()					   ;
	minStack.Top()					   .Dump();
	minStack.GetMin()				   .Dump();
}

public class MinStack
{
	private int m_top;
	private List<int> m_array;
	private LinkedList<int> m_sortedList;
	
	/** initialize your data structure here. */
	public MinStack()
	{
		m_array = new List<int>();
		m_sortedList = new LinkedList<int>();
		m_top = -1;
	}

	public void Push(int x)
	{
		m_array.Add(x);
		m_top++;

		var cur = m_sortedList.First;
		if (cur == null) 
		{
			m_sortedList.AddFirst(new LinkedListNode<int>(x));
			return;
		}
		
		while (cur != null)
		{
			if (cur.Value > x) 
			{
				m_sortedList.AddBefore(cur, new LinkedListNode<int>(x));
				return;
			}
			
			cur = cur.Next;
		}
		m_sortedList.AddLast(new LinkedListNode<int>(x));
	}

	public void Pop()
	{
		if (m_top == -1) return;
		
		var value = m_array[m_top];		
		m_array.RemoveAt(m_top);
		m_top--;
		m_sortedList.Remove(value);
	}

	public int Top()
	{
		if (m_top == -1) 
			throw new Exception();
		
		return m_array[m_top];
	}

	public int GetMin()
	{
		return m_sortedList.First();
	}
}