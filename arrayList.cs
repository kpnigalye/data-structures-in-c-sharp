using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    /*  ArrayList is C# implementation of Dynamic Array.
        It can accept any data type.
        Arraylist accepts null and empty strings as well.
        You can access any element of the ArrayList using its index which is same as array.
        Iterating theough an ArrayList also works exactly same as Arrays.
    */
    
    // Define ArrayList
    // ArrayList is a non-generic collection which means it can store any type of data
    ArrayList list1 = new ArrayList();
    
    list1.Add('A');
    list1.Add(12);
    list1.Add("KPN");
    
    // AddRange method is used to add an entire Array, HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.
    string [] strArr = new string [] { "Krishna", "Trupti" };
    list1.AddRange(strArr);
    
    // Remove an item from list
    list1.Remove('A');
    
    // iterate through the list
    foreach(var item in list1) {
      Console.WriteLine(item);
    }
    
    // You can create a new list using object initilizer syntax as well.
    var arlist2 = new ArrayList()
    {
        2, "Steve", " ", true, 4.5, null
    };
    
    arlist2.AddRange(strArr);
    
    // Insert item at specified index
    arlist2.Insert(1, "Second");
    
    // You can add an entire Array or list at a specified index using InsertRange function
    arlist2.InsertRange(2, strArr);
    
    // You can remove items from the ArrayList using following functions.
    arlist2.Remove(null);             // Removes first occurance of null
    arlist2.RemoveAt(4);              // Removes element at index 4
    arlist2.RemoveRange(0, 2);        //Removes two elements starting from 1st item (0 index)
    
    // Check if element is present in the ArrayList
    Console.WriteLine(arlist2.Contains(" "));
    
    // Count number of elements present in the ArrayList
    Console.WriteLine(arlist2.Count);
    
    foreach(var item in arlist2) {
      Console.WriteLine(item);
    }
    
    // Remove all elements of the AraayList
    arlist2.Clear();
  }
}
