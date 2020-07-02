<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
{
	if (A.Length == 0) return 0;

	var hash = new Dictionary<int, int>();
	
	for (var i = 0; i < A.Length; i++)
		for (var j = 0; j < B.Length; j++) 
		{
			var sum = A[i] + B[j];
			if (hash.ContainsKey(sum)) 
			{
				hash[sum]++;
			}
			else 
			{
				hash.Add(sum, 1);
			}
		}

	var res = 0;
	for (var i = 0; i < C.Length; i++)
		for (var j = 0; j < D.Length; j++)
		{
			var sum = C[i] + D[j];
			if (hash.ContainsKey(-sum)) 
			{
				res += hash[-sum];
			}
		}
	
	return res;
}