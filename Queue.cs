/*
    Queue is a special type of collection that stores elements in FIFO style (First In First Out). 
    C# includes the generic Queue<T> and non-generic Queue collection classes. It is recommended to use the generic Queue<T> collection.
    
    Queue does not support index operations.
    Queue<T> can contain elements of the specified type. It provides compile-time type checking and doesn not perform boxing-unboxing because it is generic.
*/

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main(string[] args) {
    Queue<string> queue = new Queue<string>();

    queue.Enqueue("One");
    queue.Enqueue("Two");
    queue.Enqueue("Three");
    queue.Enqueue("Four");

    // removed first entered item
    queue.Dequeue();    // removes One

    foreach(var item in queue) {
      Console.WriteLine(item);
    }

    Console.WriteLine();

    // return first item in queue without removing it
    Console.WriteLine(queue.Peek());

    // Checks if number is present in Stack or not
    Console.WriteLine(queue.Contains("Three"));
  }
}
