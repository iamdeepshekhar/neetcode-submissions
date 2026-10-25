/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // 1. Create Dummy node and create 2 pointers
        ListNode dummy = new ListNode(0, head);  // by default - 0 value
        ListNode p1 = dummy;
        ListNode p2 = dummy;
        // 2. Move the p2 pointer n spaces from the Dummy node (start with 0 as we want to make the
        // p1 pointer directly pointing the node to be changed)
        for (int i= 0; i < n; i++) {
            p2 = p2.next;
        }
        // 3. Move the 2 pointers 1 node each at a time till p2 reaches the last node which means p2.next = null. There is another way of doing where p2 reaches null => but for that in the previous loop i<= n so that the pointer is present at the correct distance
        while (p2.next != null) {
            p1 = p1.next;
            p2 = p2.next;
        }
        //4. When p1 has reached the node just before the Nth node to be removed, point directly to it's next node
        p1.next = p1.next.next;
        //Return the dummy.next to give the head of the updated LinkedList
        return dummy.next;
    }
}
