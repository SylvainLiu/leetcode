<Query Kind="Program" />

void Main()
{
	KthSmallest(new int[][] { new int[] {1 , 2}, new int[] {1 , 3} }, 3);
}

// Define other methods and classes here
public int KthSmallest(int[][] matrix, int k)
{
	var min = matrix[0][0];
	var max = matrix[matrix.Length - 1][matrix[0].Length - 1];
	
	var left = min;
	var right = max;
	while (left < right)
	{
		var mid = left + (right - left) / 2;
		var count = Find(matrix, mid, k);
		if (count > k)
		{
			right = mid;
		}
		else if (count < k)
		{
			left = mid + 1;
		}
		else return mid;
	}
	
	return left;
}

public int Find(int[][] matrix, int mid, int k) 
{
	var i = matrix.Length - 1;
	var j = 0;
	var count = 0;
	while (i >= 0 && j < matrix[0].Length)
	{
		if (matrix[i][j] <= mid) 
		{
			count += i + 1;
			j++;
		}
		else 
		{
			i--;
		}
		if (count > k) return count;
	}
	return count;
}