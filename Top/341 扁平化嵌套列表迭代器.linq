<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public class NestedIterator
{
	private Stack<NestedInteger> stack;
	
	public NestedIterator(IList<NestedInteger> nestedList)
	{
		stack = new Stack<NestedInteger>(nestedList.Reverse());
	}

	public bool HasNext()
	{
		while (stack.Any()) 
		{
			if (stack.Peek().IsInteger()) return true;

			foreach (var item in stack.Pop().GetList().Reverse()) 
			{
				stack.Push(item);
			}
		}
		
		return false;
	}

	public int Next()
	{
		return stack.Pop().GetInteger();
	}
}

public interface NestedInteger
{
    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    bool IsInteger();

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    int GetInteger();

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    IList<NestedInteger> GetList();
}