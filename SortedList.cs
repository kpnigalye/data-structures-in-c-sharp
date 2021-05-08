/*
    The SortedList<TKey, TValue>, and SortedList are collection classes that can store key-value pairs 
    that are sorted by the keys based on the associated IComparer implementation. For example, if the keys are of primitive types, then sorted in ascending order of keys.
    
    
    Sorts elements as soon as they are added
    A key must be unique and cannot be null.
    A value can be null or duplicate.
    
    Both SortedList<TKey,TValue> and SortedDictionary<TKey,TValue> have exactly same methods.
    SortedList<TKey,TValue> uses less memory than SortedDictionary<TKey,TValue>.
    SortedDictionary<TKey,TValue> has faster insertion and removal operations for unsorted data, O(log n) as opposed to O(n) for SortedList<TKey,TValue>.
    Searching takes O(log n) time
*/

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main(string[] args) {
      SortedList<int, string> numberNames = new SortedList<int, string>();

      numberNames.Add(3, "Three");
      numberNames.Add(1, "One");
      numberNames.Add(4, null);
      numberNames.Add(2, "Two");
      numberNames.Add(10, "Ten");

      // if key does not exists then it a new key-value pair will be added to the dictionary
      numberNames[5] = "Five";

      // When a program often has to try keys that turn out not to
      // be in the dictionary, 'TryGetValue' can be a more efficient
      // way to retrieve values.
      string value = "";
      if (numberNames.TryGetValue(11, out value))
      {
          Console.WriteLine("For key = \"11\", value = {0}.", value);
      }
      else
      {
          Console.WriteLine("Key = \"11\" is not found.");
      }

      // ContainsKey can be used to test keys before inserting them.
      if (!numberNames.ContainsKey(12))
      {
          numberNames.Add(12, "Twelve");
          Console.WriteLine("Value added for key = \"12\": {0}",
              numberNames[12]);
      }

      foreach(var item in numberNames) {
        Console.WriteLine($"Key is {item.Key} and value is {item.Value}");
      }
      
      // get only keys from SortedList
      var allKeys = numberNames.Keys;
      foreach(var key in allKeys) {
        Console.WriteLine(key);
      }

      // get only values from SortedList
      var allValues = numberNames.Values;
      foreach(var val in allValues) {
        Console.WriteLine(val);
      }

   Console.WriteLine("Hello");
  }
}
