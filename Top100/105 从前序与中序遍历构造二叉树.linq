<Query Kind="Program" />

void Main()
{
	BuildTree(new int[] {3,9,20,15,7}, new int[] {9,3,15,20,7}).Dump();
}

public TreeNode BuildTree(int[] preorder, int[] inorder)
{
	if (preorder.Length != inorder.Length) return null;
	if (preorder.Length == 0) return null;
	 
	return BuildTree(preorder, inorder, 0, preorder.Length - 1, 0, preorder.Length - 1);
}

public TreeNode BuildTree(int[] preorder, int[] inorder, int preL, int preR, int inL, int inR) 
{
	if (preL == preR) return new TreeNode(preorder[preL]);
	if (preL > preR || inL > inR) return null;

	var inRoot = inL;
	for (var i = inL; i <= inR; i++)
	{
		if (preorder[preL] == inorder[i]) { inRoot = i; break; }
	}
	var leftLength = inRoot - inL;
	var rightLength = inR - inRoot;
	 
	var leftNode = leftLength == 0 ? null : BuildTree(preorder, inorder, preL + 1, preL + leftLength, inL, inL + leftLength - 1);
	var rightNode = rightLength == 0 ? null: BuildTree(preorder, inorder, preL + leftLength + 1, preR, inRoot + 1, inR);

	return new TreeNode(preorder[preL]) {left = leftNode, right = rightNode}; 
}

//public TreeNode BuildTree(int[] preorder, int[] inorder)
//{
//	if (preorder.Length != preorder.Length) return null;
//	var length = inorder.Count();
//	if (length == 0) return null;
//	if (length == 1) return new TreeNode(preorder.First());
//
//	var leftIn = new List<int>();
//	var i = 0;
//	for (i = 0; i < length; i++)
//	{
//		if (inorder[i] == preorder[0])
//		{
//			break;
//		}
//		leftIn.Add(inorder[i]);
//	}
//
//	var rightIn = inorder.Skip(i + 1);
//	var leftPre = preorder.Skip(1).Take(i);
//	var rightPre = preorder.Skip(i + 1);
//	var node = new TreeNode(preorder.First());
//	node.left = BuildTree(leftPre.ToArray(), leftIn.ToArray());
//	node.right = BuildTree(rightPre.ToArray(), rightIn.ToArray());
//
//	return node;
//}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}