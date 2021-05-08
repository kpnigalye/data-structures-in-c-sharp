/*
  Stack implementation using Linked List
*/

using System;

public class Node {
  public int data;
  public Node next;

  public Node(int data) {
    this.data = data;
  }
}

// (Top)5 -> 4 -> 3 -> 2 -> 1
// LIFO
public class Stack {
  Node top;
  
  public void Push(int data) {
    if(top == null) {
      top = new Node(data);
      return;
    }

    Node newNode = new Node(data);
    newNode.next = top;
    top = newNode;
  } 
  
  // LIFO therefore top should be removed
  public int Pop() {
    if (top == null) return -1;

    int itemToPop = top.data;
    top = top.next;

    return itemToPop;
  } 

  public int Peek() {
    if(top == null) return -1;

    return top.data;
  } 
  
  public bool Contains(int dataToFind) {
    if(top == null) return false;

    Node current = top;
    while(current != null) {
      if(current.data == dataToFind) 
        return true;
      current = current.next;
    }
    return false;
  } 

  public void PrintStack() {
    if(top == null) return;

    Node current = top;
    while(current != null) {
      Console.WriteLine(current.data);
      current = current.next;
    }
  }
}

public class MainClass {
  public static void Main(string[] args) {
    Stack stack = new Stack();
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    stack.Push(4);
    stack.Push(5);

    stack.PrintStack();

    Console.WriteLine($"\nDoes Stack contains 3? {stack.Contains(3)}");
    Console.WriteLine($"\Top of the Stack is {stack.Peek()}");

    Console.WriteLine($"\nLast item removed from the Stack is {stack.Pop()}");

    stack.PrintStack();
  }
}
