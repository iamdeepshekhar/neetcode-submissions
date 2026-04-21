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
    public ListNode ReverseList(ListNode head) {

        ListNode? currentNode = head;
        ListNode? prevNode = null;
        while(currentNode != null)
        {
            //1. Save the next node in temp
            ListNode? tempNode = currentNode.next;
            //2. Reverse the current node's pointer
            currentNode.next = prevNode;
            //3. Move prev and currentNode one step forward
            prevNode = currentNode;
            currentNode = tempNode;

        }
        return prevNode; //As it has become the head when LinkedList is revered

    }
}
