<Query Kind="Program" />

void Main()
{
	Rotate(new int[] {1,2,3,4,5,6}, 4);
}

public void Rotate(int[] nums, int k)
{
	if (nums.Length == 0 || nums.Length == 1) return;
	
	var gcd = Gcd (k % nums.Length, nums.Length);
	var rot = gcd == 1 ? k % nums.Length : 1;
	var round = gcd == 1? 1 : k % nums.Length;
		
	while (round > 0)
	{
		var pre = nums[0];
		var post = nums[0];

		for (var i = rot; i != 0; i = (i + rot) % nums.Length)
		{
			pre = post;
			post = nums[i];
			nums[i] = pre;
		}

		nums[0] = post;

		round--;
	}
}

	int Gcd(int a, int b) 
{
	return b == 0? a: Gcd (b, a%b);
}