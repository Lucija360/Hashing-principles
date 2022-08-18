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

 
## Important Questions

hhbhbh

## Sections

Here are all sections of this README.md file

- [Hashing Principles](#hashing-principles)
- [Questions and Answers](#questions-and-answers)
- [Important Questions](#important-questions)


Hopefully this will help newbies to learn the basics of HashMap in Java. 😃
