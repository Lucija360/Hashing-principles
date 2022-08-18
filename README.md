# Hashing-principles
HashMap explained in simple form

Here you can see and read on how i explained HashMap in Java in depth, also touched on subject of "HashMap" in C#.
I provided some code exaples above cotaining both c# and java.

## Questions and Answers

#### Can you store multiple keys with the same value in a hashmap?
- No, multiple keys with the same value can’t be stored in a hashmap.
- When you try to insert a new key that is already present in the hashmap then overriding will happen and the old key will be replaced with the new key and a new value. 
#### How to specify different methods of creating a hashmap in java along with implementation.

Different methods of creating a hashmap are:

1) Constructing a hashmap with default capacity

- Syntax: 

```HashMap<String, Integer> InterviewBIt_map1 = new HashMap<String, Integer>();```

2) Constructing a hashmap with a defined capacity i.e 50 in my example

- Syntax:

```HashMap<String, Integer> InterviewBIt_map2 = new HashMap<String, Integer>(50);```

3) Specifying lead factor along with the capacity

- Syntax:

 ```HashMap<String, Integer> InterviewBIt_map3= new HashMap<String, Integer>(50, 0.5f);```
 
 #### Does hashmap allow you to store null values?
 
 - Yes, We can store as many null values in a hashmap as we want but only one null key can be stored not more than that.
 ```
import java.util.*;  
import java.io.*;
public class interviewBit {   
        public static void main(String[] args)   
        {   
            HashMap hmap=new HashMap();   
            hmap.put(1,"Program to store null value");   
            hmap.put(null,"InterviewBit");   
            System.out.println(hmap);   
        }   
    }
  ```
 #### Output:
 
 ```{null=InterviewBit, 1=Program to store null value}```
 
 #### In which order mappings are stored in HashMap?

- Random order because HashMap doesn't provide any ordering guarantee for keys, values, or entries. When you iterate over a HashMap, you may get a different order every time you iterate over it.


## Important Questions

#### What happens if you try to store a duplicate key in the HashMap?

- If you try to store a duplicate key in the HashMap, it overrides the old value with the new value. When storing a key that's already present in the HashMap, the HashMap size stays the same and doesn't throw error or exception. This is why all keys return Set instead of Collection when you call the keySet() method on HashMap since Set doesn't allow for duplicates.

#### What's the difference between HashMap and ConcurrentHashMap in Java?

- One of the biggest differences between HashMap and ConcurrentHashMap is that ConcurrentHashMap is thread-safe, whereas HashMap isn't. ConcurrentHashMap also doesn't allow keys to contain null values and HashMap can contain one null key.

#### What factors would you use to measure the performance of HashMap?

- To measure the performance of HashMap, I would look at the load factor and capacity. Load factor lets me know how full the hash table can get before its capacity automatically increases. The hash table gets rehashed when the number of entries exceeds the load factor allowing the hash table to have approximately twice the number of buckets. Capacity lets me know the number of buckets in the hash table.


#### Can you sort HashMap in Java?

- No, you cannot sort a HashMap because, unlike List, it is not an ordered collection. Albeit, you can sort contents of HashMap by keys, values, or by entries by sorting and then storing the result into an ordered map like LinkedHashMap or a sorted map e.g., TreeMap.




#### What is a collision in HashMap? How can you resolve these?

- A collision in HashMap is when two distinct keys generate the same hashCode() value. When multiple collisions often result from a bad hashCode() algorithm. These can lead to a poor performance of the HashMap. To eliminate collisions, I would apply the chaining strategy, which chains items together, similar to a linked list.


#### Can you store a duplicate key in HashMap?

- No, you cannot insert duplicate keys in HashMap, it doesn't allow duplicate keys. If you try to insert an existing key with the new or same value, then it will override the old value, but the size of HashMap will not change i.e., it will remain the same. This is one of the reasons when you get all keys from the HashMap by calling keySet(). It returns a Set, not a Collection because Set doesn't allow duplicates.


## Sections

Here are all sections of this README.md file

- [Hashing Principles](#hashing-principles)
- [Questions and Answers](#questions-and-answers)
- [Important Questions](#important-questions)


Hopefully this will help newbies to learn the basics of HashMap in Java. 😃
