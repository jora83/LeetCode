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
    public ListNode MergeTwoLists(ListNode node1, ListNode node2){
        
        if(node1 == null)
            return node2;
        if(node2 == null) 
            return node1;

        ListNode head = new ListNode(); 

        if (node1.val <= node2.val)
        {
            head = node1;
            node1 = node1.next;
        }
        else
        {
            head = node2;
            node2 = node2.next;
        }

        head.next = MergeTwoLists(node1, node2);

        return head;
    }
}