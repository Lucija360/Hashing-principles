// The program below shows how we can add elements to the dictionary.

// We will use the Dictionary collection as hashmap equivalent in C#. 
// It represents a collection of key-value pairs. 
// The key-value pair means that every value has a key. 
// The correct syntax to create a dictionary is as follows.

using System;
using System.Collections.Generic;
public class Program {
   public static void Main() {
  
IDictionary<int, string> flowerNames = new Dictionary<int, string>();
flowerNames.Add(1,"Rose");
flowerNames.Add(2,"Jasmine");
flowerNames.Add(3,"Lili");
 

foreach(KeyValuePair<int, string> kvp in flowerNames)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
   }
}

// Output

//Key: 1, Value: Rose
// Key: 2, Value: Jasmine
// Key: 3, Value: Lili

// multiple methods to perform operations on the created dictionary such as Add(), Clear(), ContainsKey(), ContainsValue(), Equals(), GetType(), Remove()