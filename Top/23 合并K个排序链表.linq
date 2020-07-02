<Query Kind="Program" />

void Main()
{
	var node1 = new ListNode(1);
	node1.next = new ListNode(4);
	node1.next.next = new ListNode(5);
	var node2 = new ListNode(1);
	node2.next = new ListNode(3);
	node2.next.next = new ListNode(4);
	var node3 = new ListNode(2);
	node3.next = new ListNode(6);

	var list = new ListNode[] {node1, node2, node3};
	MergeKLists(list).Dump();
}

public ListNode MergeKLists(ListNode[] lists)
{
	if (lists.Length == 0) return null;
	if (lists.Length == 1) return lists[0];
	
	return MergeKLists(lists, 0, lists.Length - 1);
}

public ListNode MergeKLists(ListNode[] lists, int left, int right) 
{
	if (left == right) return lists[left];

	var mid = left + (right - left) / 2;
	var l = MergeKLists(lists, left, mid).Dump();
	var r = MergeKLists(lists, mid + 1, right).Dump();

	var res = new ListNode(-1);
	var current = res;
	while (r != null && l != null)
	{
		if (r.val < l.val) { current.next = r; r = r.next; }
		else { current.next = l; l = l.next; }
		current = current.next;
	}
	current.next = r == null ? l : r;
	return res.next;
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}