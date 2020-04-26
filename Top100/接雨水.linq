<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int Trap(int[] height)
{
	if (height.Length == 0) return 0;
	
	var stack = new Stack<int>();
	var current = 0;
	var res = 0;
	while (current < height.Length)
	{
		while (stack.Any() && height[stack.Peek()] < height[current])
		{
			var low = height[stack.Pop()];
			if (!stack.Any()) { break; }
			
			var high = Math.Min(height[stack.Peek()], height[current]);
			var distance = current - stack.Peek() - 1;
			res += (high - low) * distance;
		}

		stack.Push(current);
		current++;
	}
	
	return res;
}