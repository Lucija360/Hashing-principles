// Comparison to C# Dictionary Method 
//  Java program that creates a HashMap. 
// It adds 3 string keys with 3 integer values to the collection.
// It uses get() and gerOrElse() to access values.

import java.util.HashMap;
import java.util.Map.Entry;

public class Program {
    public static void main(String[] args) {
        
        // New HashMap.
        HashMap<String, Integer> hash = new HashMap<>();
        
        // Add to collection.
        hash.put("diamond", 500);
        hash.put("ruby", 200);
        hash.put("pearl", 100);
        
        // Get values from collection.
        int value1 = hash.get("diamond");
        System.out.println("get DIAMOND: " + value1);
        
        // Try to get a key that does not exist.
        int value2 = hash.getOrDefault("coal", -1);
        System.out.println("get COAL: " + value2);
        
        // Display entire HashMap.
        for (Entry<String, Integer> entry : hash.entrySet()) {
            System.out.println("KEY: " + entry.getKey());
            System.out.println("VALUE: " + entry.getValue());
        }
    }
}

// Output
get DIAMOND: 500
get COAL: -1
KEY: diamond
VALUE: 500
KEY: ruby
VALUE: 200
KEY: pearl
VALUE: 100