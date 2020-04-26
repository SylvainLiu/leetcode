<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public ListNode MergeKLists(ListNode[] lists)
{
	if (lists.Length == 0) return null;
	if (lists.Length == 1) return lists[0];
	
	return MergeKLists(lists, 0, lists.Length - 1);
}

public ListNode MergeKLists(ListNode[] lists, int left, int right)
{
	if (left == right) return lists[left];
	
	else 
	{
		var mid = left + (right - left) / 2;
		var leftList = MergeKLists(lists, left, mid);
		var rightList = MergeKLists(lists, mid + 1, right);
		return Merge2List(leftList, rightList);
	}

	ListNode Merge2List(ListNode l, ListNode r) 
	{
		var head = new ListNode(-1);
		var current = head;

		while (l != null || r != null)
		{
			var valL = l == null ? l.val : int.MaxValue;
			var valR = r == null ? r.val : int.MaxValue;

			if (valL <= valR) 
			{
				current.next = l;
				l = l == null ? null : l.next;
			}
			else
			{
				current.next = r;
				r = r == null ? null : r.next;
			}
		}
		
		return head.next;
	}
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

