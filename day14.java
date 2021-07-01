import java.io.*;
import java.util.*;

class Node {
	int data;
	Node next;
	Node(int d) {
        data = d;
        next = null;
    }
}

class Solution {

   public static  Node insert(Node head,int data) {
    // This is a "method-only" submission. 
    // You only need to complete this method. 
    Node current = head;
    // Setting up our new node to add
    Node newTail = new Node(data);
    newTail.next = null;
    // if the list isn't empty
    if (current != null) {
        // get to the end of the list and set the current
        // to the last element
       while (current.next != null) {
           // iterating through
            current = current.next;
        }
    } else {
        // otherwise the list is empty and we should just return our new node with the data
        return newTail;
    }
    // then add our new tail onto the end of the list
    current.next = newTail;
    return head;
}
	public static void display(Node head) {
        Node start = head;
        while(start != null) {
            System.out.print(start.data + " ");
            start = start.next;
        }
    }

    public static void main(String args[]) {
        Scanner sc = new Scanner(System.in);
        Node head = null;
        int N = sc.nextInt();

        while(N-- > 0) {
            int ele = sc.nextInt();
            head = insert(head,ele);
        }
        display(head);
        sc.close();
    }
}