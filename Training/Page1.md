## [Home](../README.md)

## Part 1 - Intro to static
1. `Program.cs` - Create a local list of string with 5 items
2. `MyDatabase.cs` - Practice static
    - Create a static class
    - Create a static field List\<string\>
    - Create a static constructor that will load the list and state ( "The list is loading" )
    - Create a static property called Data with a getter that will return the list.
3. `Program.cs` - Demonstrate displaying the data from our static class


--- 



To get you introduce to working with a database let's practice by having you make a "database" of your own. This isn't an actual database, but the concept is the same. You'll connect to another class that has data, and pull that data into your main program. We'll do this with a static class.

**1. Create a local list of strings in Program.cs:**

First to warm up, create a List of string objects in `Program.cs`, like below.

#### Question 1: What does it mean to create an "instance" of an object?
#### Question 2: What does it mean when we say "Create a local variable"?

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> myLocalList = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"
        };

        // Display or manipulate the local list as needed.
        foreach (string item in myLocalList)
        {
            Console.WriteLine(item);
        }
    }
}
```

---


Now that we have our list of strings let's create a static class, this will prepare you for working with our data once we connect to our Database class.

**2. Create a static class and static members in MyDatabase.cs:**

1. Create a static class named `MyDatabase.cs`. Add the following code.

```csharp
using System;
using System.Collections.Generic;

public static class MyDatabase
{
    private static List<string> data; // Static field

    static MyDatabase()
    {
        Console.WriteLine("The list is loading");
        data = new List<string>
        {
            "Data 1",
            "Data 2",
            "Data 3",
            "Data 4",
            "Data 5"
        };
    }

    public static List<string> Data // Static property
    {
        get { return data; }
    }
}
```

Notice where we use the static keyword. 

#### Question 3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?
#### Question 4: Do you need an instance of an object to call a static method?
#### Question 5: Can you create an instance of a static class?
#### Question 6: Can you manually call a static constructor? When is it called?

---

**3. Demonstrate displaying the data from the static class in Program.cs:**

Now going back to your Program.cs file and delete your list. We are going to access the list we created in our `MyDatabase.cs` class.

```csharp
using System;

class Program
{
    static void Main()
    {
        // Access the static property to get the data
        List<string> dataList = MyDatabase.Data;

        // Display the data from the static class
        foreach (string item in dataList)
        {
            Console.WriteLine(item);
        }
    }
}
```

You should now have displayed the data from your List in MyDatabase. In the real world a Database is a completly seperate system from your code. You will write code that will pull the data from the database, and then transform it and interact with it as you see fit.

#### Question 7: Did you have to create an instance of MyDatabase to access Data? Why?
#### Question 8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?

---

So far so good! You're already getting a feel for working with a database. But data is rarely just strings. It's composed of "Objects" that contain important information related to a particular object. 

Let's get those setup.

## [Page2](Page2.md)