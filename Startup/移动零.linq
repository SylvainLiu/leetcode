<Query Kind="Program" />

void Main()
{
	var sut = new int[] {0,1,0,3,12};
	MoveZeroes(sut);
	sut.Dump();
}

public void MoveZeroes(int[] nums)
{
	if (nums.Length == 0) return;

	var index = 0;
	for (var i = 0; i < nums.Length; i++)
	{
		if (nums[i] != 0)
		{
			if (index != i)
			{
				nums[index] = nums[i];
				nums[i] = 0;
			}
			index++;
		}
	}
}

//public void MoveZeroes(int[] nums) 
//{
//	if(nums.Length == 0) return;
//
//	var move = 0;
//	for (var i = 0; i < nums.Length; i++)
//	{
//		if (nums[i] == 0) 
//		{
//			move++;
//			continue;
//		}
//		
//		nums[i-move] = nums[i];
//	}
//
//	while (move > 0)
//	{
//		nums[nums.Length - move] = 0;
//		move--;
//	}
//}

//不好的解法
//public void MoveZeroes(int[] nums)
//{
//	if(nums.Length == 0) return;
//	
//	var move = 0;
//	for (var i = 0; i < nums.Length; i++)
//	{
//		if (nums[i] != 0) continue;
//
//		var index = i;
//		while (index < nums.Length && nums[index] == 0) 
//		{
//			index++;
//			move++;
//		}
//
//		while (index < nums.Length && nums[index] != 0) 
//		{
//			index ++;	
//		}
//		
//		MoveLeft(nums, i, index - 1, move);
//		
//		i = index - 1;
//	}
//}
//
//void MoveLeft(int[] nums, int begin, int end, int shift) 
//{
//	var gcd = Gcd(end - begin + 1, shift);
//	var round = gcd == 1 ? shift: gcd;
//	var step = gcd == 1? 1 : gcd;
//
//	while (round > 0)
//	{
//		var pre = 0;
//		var current = nums[end - round + 1];
//		
//		for (var i = end - round + 1; i >= begin + step; i -= step) 
//		{	
//			pre = current;
//			current = nums[i - step];
//			nums[i - step] = nums[i];
//		}
//		
//		nums[end - round + 1] = 0;
//		
//		round--;
//	}
//}
//
//int Gcd(int a, int b) 
//{
//	return b == 0 ?	a: Gcd(b, a%b);
//}