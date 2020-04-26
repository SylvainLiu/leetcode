<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int LargestRectangleArea(int[] heights)
{
	var stack = new Stack<int>();
	stack.Push(-1);

	var max = 0;
	for (var i = 0; i < heights.Length; i++)
	{
		while (stack.Peek() != -1 && heights[stack.Peek()] >= heights[i]) 
		{
			max = Math.Max(max, heights[stack.Pop()] * (i - stack.Peek() - 1));
		}
		stack.Push(heights[i]);
	}

	while (stack.Peek() != -1)
		max = Math.Max(max, heights[stack.Pop()] * (heights.Length - stack.Peek() - 1));
		
	return max;
}