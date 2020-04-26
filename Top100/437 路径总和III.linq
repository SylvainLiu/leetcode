<Query Kind="Program" />

void Main()
{
	var tree = new TreeNode(10);
	tree.left = new TreeNode(5);
	tree.right = new TreeNode(-3);
	tree.right.right = new TreeNode(11);
	tree.left.left = new TreeNode(3);
	tree.left.right = new TreeNode(2);
	tree.left.right.right = new TreeNode(1);
	tree.left.left.left = new TreeNode(3);
	tree.left.left.right = new TreeNode(-2);
	
	PathSum(tree, 8).Dump();
}

public int PathSum(TreeNode root, int sum)
{
	if (root == null) return 0;
	dic = new Dictionary<int, int> { { 0, 1 }};
	
	BackTrack(root, sum, 0);
	return res;
}

public int res;
public Dictionary<int, int> dic;
public void BackTrack(TreeNode node, int sum, int pathSum)
{
	if (node == null) return;

	pathSum += node.val;
	if (dic.ContainsKey(pathSum - sum)) res += dic[pathSum - sum];

	if (dic.ContainsKey(pathSum)) dic[pathSum]++;
	else dic.Add(pathSum, 1);
	
	BackTrack(node.left, sum, pathSum);
	BackTrack(node.right, sum, pathSum);
	
	dic[pathSum]--;
}

//public int PathSum(TreeNode root, int sum)
//{
//	var dic = new Dictionary<int, int> { {0, 1}};
//	return DFS(root, dic, sum, 0);
//}
//
//public int DFS(TreeNode node, Dictionary<int, int> dic, int sum, int pathSum)
//{
//	if (node == null) return 0;
//	pathSum += node.val;
//
//	var res = 0;
//	if (dic.TryGetValue(sum - pathSum, out var temp)) 
//	{
//		res += temp;
//	}
//	
//	if (dic.ContainsKey(pathSum)) dic[pathSum] += 1;
//	else dic.Add(pathSum, 1);
//
//	res += DFS(node.left, dic, sum, pathSum);
//	res += DFS(node.right, dic, sum, pathSum);
//	
//	dic[pathSum] -= 1;
//	return res;
//}

//public int PathSum(TreeNode root, int sum)
//{
//	if (root == null) return 0;		
//	
//	return PathSum(root.left, sum) + PathSum(root.right, sum) + DFS(root, sum);
//}
//
//public int DFS(TreeNode root, int sum)
//{
//	if (root == null) return 0;
//	var count = 0;
//	if (root.val == sum) count += 1;
//
//	count += DFS(root.left, sum - root.val);
//	count += DFS(root.right, sum - root.val);
//
//	return count;
//}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}