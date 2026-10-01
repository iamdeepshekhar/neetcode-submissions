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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        List<int> allValues = new List<int>();
        ListNode current = list1;  // as I am starting to add the values of list1. No specific order
                                   // as I could have started with list2

        while (list1 != null) {
            allValues.Add(current.val);
            current = current.next;
            list1 = list1.next;
        }
        current = list2; // Adding values of list2 LinkedList
        while (list2 != null) {
            allValues.Add(current.val);
            current = current.next;
            list2 = list2.next;
        }
        if(allValues.Count == 0)
        {
            return null;
        }
        allValues.Sort(); //Sorting the elements of the C# List
        // Create a head
        ListNode head = new ListNode(allValues[0]);
        current = head;
        for (int i = 1; i < allValues.Count; i++) {
            ListNode createNode = new ListNode(allValues[i]);
            current.next = createNode; //Linking the head to first node in the 1st iteration.
            current = createNode; // iterating the current pointer to the newly created element
        }
        return head;
    }
}