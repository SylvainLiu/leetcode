<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public ListNode DeleteDuplicates(ListNode head)
{
	if (head == null || head.next == null) return head;

	while (head != null)
	{
		if (head.next != null && head.val == head.next.val) 
		{
			var temp = head;
			while (head.next != null && head.val == head.next.val) 
			{
				head = head.next;
			}
			head = head.next;
			temp.next = head;
		}
		else 
		{
			head = head.next;
		}
	}
	
	return head;
}