//In C# Dictionary is used instead of HashMap


// To begin, we have a program in C# that adds 3 string keys with 3 int values to a Dictionary. 
// We get one of the values. Then we try to get a value that does not exist.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Dictionary.
        Dictionary<string, int> hash = new Dictionary<string, int>();
        
        // Add some data.
        hash.Add("diamond", 500);
        hash.Add("ruby", 200);
        hash.Add("pearl", 100);
        
        // Get value that exists.
        int value1 = hash["diamond"];
        Console.WriteLine("get DIAMOND: " + value1);
        
        // Get value that does not exist.
        hash.TryGetValue("coal", out int value2);
        Console.WriteLine("get COAL: " + value2);
        
        // Loop over items in collection.
        foreach (KeyValuePair<string, int> pair in hash)
        {
            Console.WriteLine("KEY: " + pair.Key);
            Console.WriteLine("VALUE: " + pair.Value);
        }
    }
}

// Output :
// get DIAMOND: 500
// get COAL: 0
// KEY: diamond
// VALUE: 500
// KEY: ruby
// VALUE: 200
// KEY: pearl
// VALUE: 100