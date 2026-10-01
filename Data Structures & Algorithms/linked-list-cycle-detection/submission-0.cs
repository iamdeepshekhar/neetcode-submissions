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
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> allNodes = new HashSet<ListNode>();
        ListNode current = head;
        while(current != null)
        {
            if(allNodes.Contains(current))
            {
                return true;
            }
            else
            {
                allNodes.Add(current);
            }
            current = current.next;
        }
        return false;
    }
}
