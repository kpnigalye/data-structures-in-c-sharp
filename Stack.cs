/*
    Stack is a special type of collection that stores elements in LIFO style (Last In First Out). 
    C# includes the generic Stack<T> and non-generic Stack collection classes. It is recommended to use the generic Stack<T> collection.
    
    Stack does not support index operations.
    Stack<T> can contain elements of the specified type. It provides compile-time type checking and doesn not perform boxing-unboxing because it is generic.
*/

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main(string[] args) {
    Stack<string> stack = new Stack<string>();

    stack.Push("One");
    stack.Push("Two");
    stack.Push("Three");
    stack.Push("Four");

    // removed last entered item
    stack.Pop();    // removes 4

    foreach(var item in stack) {
      Console.WriteLine(item);
    }

    Console.WriteLine();

    // You can create a stack from an array too.
    int[] nums = {1,2,3,4};
    Stack<int> intStack = new Stack<int>(nums);
    
    foreach(var item in intStack) {
      Console.WriteLine(item);
    }

    // returns the item on top of stack
    Console.WriteLine($"Number on top of Stack is {intStack.Peek()}");

    // Checks if number is present in Stack or not
    Console.WriteLine(intStack.Contains(3));
  }
}
