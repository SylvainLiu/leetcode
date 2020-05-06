<Query Kind="Program" />

void Main()
{
	LargestRectangleArea(new int[] {1});
}

public int LargestRectangleArea(int[] heights)
{
	if (heights.Length == 0) return 0;

	var stack = new Stack<int>();
	var res = 0;
	for (var i = 0; i < heights.Length; i++)
	{
		while (stack.Any() && heights[stack.Peek()] >= heights[i]) 
		{
			var high = heights[stack.Pop()];
			var length = i - 1 - ( stack.Any() ? stack.Peek() : -1);
			res = Math.Max(high * length, res);
		}
		stack.Push(i);
	}

	while (stack.Any())
	{
		var high = heights[stack.Pop()];
		var length = heights.Length - 1 - (stack.Any() ? stack.Peek() : -1);
		res = Math.Max(high * length, res);
	}

	return res;
}

//public int LargestRectangleArea(int[] heights)
//{
//	var stack = new Stack<int>();
//	stack.Push(-1);
//
//	var max = 0;
//	for (var i = 0; i < heights.Length; i++)
//	{
//		while (stack.Peek() != -1 && heights[stack.Peek()] >= heights[i]) 
//		{
//			max = Math.Max(max, heights[stack.Pop()] * (i - stack.Peek() - 1));
//		}
//		stack.Push(heights[i]);
//	}
//
//	while (stack.Peek() != -1)
//		max = Math.Max(max, heights[stack.Pop()] * (heights.Length - stack.Peek() - 1));
//		
//	return max;
//}