/*  The Hashtable is a loosely typed non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection. 
    It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally 
    and then matches the hash code of the specified key at the time of accessing values.
    
    Keys must be unique and cannot be null.
    Values can be null or duplicate.
    Values can be accessed by passing associated key in the indexer e.g. myHashtable[key]
  
    Hashtable is thread safe.
    Hashtable returns null if we try to find a key which does not exist.
    Data retrieval is slower than dictionary because of boxing-unboxing.
  
    Insert, Delete and Search all operations are constant time.
*/

using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    Hashtable numberNames = new Hashtable();
    
    // Adding a key/value using the Add() method
    numberNames.Add(1, "One"); 
    numberNames.Add(2, "Two");
    numberNames.Add(3, "Three");
    numberNames.Add(4, "Four");

    // Remove using key
    numberNames.Remove(2);

    foreach(DictionaryEntry item in numberNames) {
      Console.WriteLine($"Key is {item.Key} and value is {item.Value}");
    }
    
    // Initialize HashTable using object initializer
    var cities = new Hashtable(){
      {"UK", "London, Manchester, Birmingham"},
      {"USA", "Chicago, New York, Washington"},
      {"India", "Mumbai, New Delhi, Pune"}
    };
    
    // check if key exists using 'ContainsKey' before removing it
    if(cities.ContainsKey("UK")){ 
      cities.Remove("UK");
    }

    // iterate thorugh HashTable
    foreach(DictionaryEntry city in cities) {
      Console.WriteLine($"Country is {city.Key} and States are {city.Value}");
    }
    
    Console.WriteLine("Hello");
  }
}



