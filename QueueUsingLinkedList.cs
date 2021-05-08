/*
  Queue implementation using Linked List
*/

using System;

public class Node {
  public int data;
  public Node next;

  public Node(int data) {
    this.data = data;
  }
}

public class Queue {
  Node head, tail;

  public void Enqueue(int data) {
    if (head == null) {
      head = new Node(data);
      tail = head;
      return;
    }

    Node current = head;
    while (current.next != null) {
      current = current.next;
    }
    current.next = new Node(data);
    tail = current.next;
  }

  // FIFO therefore head should be removed
  public int Dequeue() {
    if (head == null) return -1;

    int itemToDequeue = head.data;
    head = head.next;

    return itemToDequeue;
  }

  public int Peek() {
    if (head == null) return -1;

    return head.data;
  }

  public bool Contains(int dataToFind) {
    if (head == null) return false;

    Node current = head;
    while (current != null) {
      if (current.data == dataToFind)
        return true;
      current = current.next;
    }
    return false;
  }

  public void PrintQueue() {
    if (head == null) return;

    Node current = head;
    while (current.next != null) {
      Console.WriteLine(current.data);
      current = current.next;
    }
    Console.WriteLine(current.data);
  }
}

public class MainClass {
  public static void Main(string[] args) {
    Queue queue = new Queue();
    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);
    queue.Enqueue(4);
    queue.Enqueue(5);

    queue.PrintQueue();

    Console.WriteLine($"\nDoes Queue contains 3? {queue.Contains(3)}");
    Console.WriteLine($"\nPeek of the Queue is {queue.Peek()}");

    Console.WriteLine($"\nLast dequeued item of the Queue is {queue.Dequeue()}");

    queue.PrintQueue();
  }
}
