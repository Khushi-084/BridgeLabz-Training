/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */

 // Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, 
 // and return the reordered list.
 
class Solution {
    public ListNode oddEvenList(ListNode head) {
        if(head==null || head.next==null || head.next.next ==null)
        {
            return head;
        }
        ListNode head2 = head.next;
        ListNode first = head, second = head.next,prev = null;
        while(second!=null && first!=null)
        {
            first.next = second.next;
            prev = first;
            first = first.next;
            if(first!=null)
            {
                second.next = first.next;
                second = second.next;
            }
        }
        if(second==null)
        {
            first.next = head2;
        }
        else  
        {
            prev.next = head2;
        }
        return head;
    }
}