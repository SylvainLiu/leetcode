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
	private Stack<(int, int)> stack;
	public MinStack()
	{
		stack = new Stack<(int, int)>();
	}

	public void Push(int x)
	{
		if (stack.Any())
		{
			var min = stack.Peek().Item2;
			stack.Push((x, x > min ? min : x))
		}
		else 
		{
			stack.Push((x, x));
		}		
	}

	public void Pop()
	{
		if (stack.Any()) stack.Pop();
	}

	public int Top()
	{
		if (stack.Any()) return stack.Peek().Item1;
		throw new Exception();
	}

	public int GetMin()
	{
		if (stack.Any()) return stack.Peek().Item2;
		throw new Exception();
	}
}

//public class MinStack
//{
//	private int m_top;
//	private List<int> m_array;
//	private LinkedList<int> m_sortedList;
//	
//	/** initialize your data structure here. */
//	public MinStack()
//	{
//		m_array = new List<int>();
//		m_sortedList = new LinkedList<int>();
//		m_top = -1;
//	}
//
//	public void Push(int x)
//	{
//		m_array.Add(x);
//		m_top++;
//
//		var cur = m_sortedList.First;
//		if (cur == null) 
//		{
//			m_sortedList.AddFirst(new LinkedListNode<int>(x));
//			return;
//		}
//		
//		while (cur != null)
//		{
//			if (cur.Value > x) 
//			{
//				m_sortedList.AddBefore(cur, new LinkedListNode<int>(x));
//				return;
//			}
//			
//			cur = cur.Next;
//		}
//		m_sortedList.AddLast(new LinkedListNode<int>(x));
//	}
//
//	public void Pop()
//	{
//		if (m_top == -1) return;
//		
//		var value = m_array[m_top];		
//		m_array.RemoveAt(m_top);
//		m_top--;
//		m_sortedList.Remove(value);
//	}
//
//	public int Top()
//	{
//		if (m_top == -1) 
//			throw new Exception();
//		
//		return m_array[m_top];
//	}
//
//	public int GetMin()
//	{
//		return m_sortedList.First();
//	}
//}