/*
  The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.

  Order of items is not guaranteed.
  Implements IDictionary<TKey, TValue> interface.
  Keys must be unique and cannot be null.
  Values can be null or duplicate.
  Values can be accessed by passing the key in the indexer e.g. myDictionary[key]
  Elements are stored as KeyValuePair<TKey, TValue> objects.
  
  Insert, Delete and Serach all are constant time operations.
  Dictionary throws an exception if we try to find a key which does not exist.
  Data retrieval is faster than Hashtable.
  
  Dictionary faster than a Hashtable because 
  1. There is no boxing and unboxing like HashTable.
  2. The primary structural difference between them is that Dictionary relies on chaining (maintaining a list of items for each hash table bucket) 
  to resolve collisions whereas Hashtable uses rehashing for collision resolution (when a collision occurs, tries another hash function to map the key to a bucket).
  
  According MSDN Article, The Dictionary<TKey, TValue> class has the same functionality as the Hashtable class. 
  A Dictionary<TKey, TValue> of a specific type (other than Object) has better performance than a Hashtable for value types because 
  the elements of Hashtable are of type Object and, therefore, boxing and unboxing typically occur if storing or retrieving a value type".
*/

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main(string[] args) {
    Dictionary<int, string> dict = new Dictionary<int, string>();

    // Add key-value pair
    dict.Add(1, "One");
    dict.Add(2, "Two");
    dict.Add(3, "three");
    dict.Add(4, "Four");

    Console.WriteLine($"Value of key 1 is {dict[1]}");

    // Checks if key is present
    // if yes, then removes the key-value pair using Remove method
    if(dict.ContainsKey(1)) {
      dict.Remove(1);
    }
    
    // check if dictionary has value
    Console.WriteLine(dict.ContainsValue("Two"));
    
    // update value using key
    if(dict.ContainsKey(3)) {
      dict[3] = "Three";
    }

    //use TryGetValue() to get a value of unknown key
    string result;

    if(dict.TryGetValue(4, out result))
    {
        Console.WriteLine(result);
    }

    // item will be of type 'KeyValuePair<int, string>'
    foreach(var item in dict) {
      Console.WriteLine($"Key is {item.Key} and value is {item.Value}");
    }
    
    // Find number of items in the dictionary
    Console.WriteLine(dict.Count);
    
    // removes all items
    dict.Clear();
    

    Console.WriteLine("Hello");
  }
}
