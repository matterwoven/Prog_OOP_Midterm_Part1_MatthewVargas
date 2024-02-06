## Creating Objects

### Class
- **Concept**: A class is a blueprint for creating objects (a particular data structure), providing initial values for state (member variables or attributes), and implementations of behavior (member functions or methods). It is a fundamental building block of OOP in C#.
- **Implementation**: 
  ```csharp
  public class Car {
      // Fields, properties, methods, and events go here.
  }
  ```

### Fields
- **Concept**: Fields are variables of any type that are declared directly in a class or struct. Fields hold the data encapsulated by the class or struct.
- **Implementation**:
  ```csharp
  public class Car {
      public string color; // Field
  }
  ```

### Constructors
- **Concept**: Constructors are special methods used to initialize objects of a class. They are called when an instance of a class is created.
- **Implementation**:
  ```csharp
  public class Car {
      public Car() { // Constructor
          // Initialization code
      }
  }
  ```

### Properties
- **Concept**: Properties are a combination of a field and a method. They use accessors (`get` and `set`) to control the access to a class’s internal fields.
- **Implementation**:
  ```csharp
  public class Car {
      private string color; // Private field
      public string Color { // Property
          get { return color; }
          set { color = value; }
      }
  }
  ```

### Method
- **Concept**: Methods define the behavior of a class. They are blocks of code that perform a specific task.
- **Implementation**:
  ```csharp
  public class Car {
      public void Drive() { // Method
          // Driving code
      }
  }
  ```

### Inheriting from objects

### Inheritance
- **Concept**: Inheritance allows a class to use members of another class. This provides a means to create a new class that is a modified version of an existing class.
- **Implementation**:
  ```csharp
  public class Vehicle { // Base class
  }

  public class Car : Vehicle { // Derived class
  }
  ```

### Virtual, Override, and New
- **Concept**:
  - **Virtual**: Allows a method, property, or event to be overridden in a derived class.
  - **Override**: Extends or modifies the abstract or virtual implementation of an inherited method, property, index, or event.
  - **New**: Hides a method, property, or event of the base class, providing a new implementation.
- **Implementation**:
  ```csharp
  public class Vehicle {
      public virtual void Drive() { // Virtual method
      }
  }

  public class Car : Vehicle {
      public override void Drive() { // Override method
          // New implementation
      }
  }
  ```



## Giving access to data
### Access Modifiers
- **Concept**: Access modifiers are keywords used to specify the declared accessibility of a member or a type. This controls the scope of the member's accessibility from other parts of the code.
- **Common Modifiers**: `public`, `private`, `protected`, `internal`, `protected internal`.
- **Implementation**: See examples above.


## Class Modifier

### Static
- **Concept**: Static members belong to the class itself rather than to any specific object created from the class. They are accessed by the class name rather than by instance variables.
- **Implementation**:
  ```csharp
  public class Car {
      public static int NumberOfCars; // Static field
      public static void Drive() { // Static method
          // Code
      }
  }
  ```

  Certainly! In object-oriented programming, particularly in C#, static class fields, constructors, properties, and methods serve different roles and have distinct characteristics:

**Static Class:**
- A static class is a class that cannot be instantiated (you cannot create objects from it).
- It is typically used to provide utility methods, constants, or configuration settings that do not require instance-specific data.
- All members of a static class must be declared as static.

**Static Class Field:**
- A static field is a class-level variable that is shared among all instances of a class (or in the case of a static class, among all code that uses the class).
- It is initialized once, and its value remains the same throughout the program's lifetime.
- Static fields are accessed using the class name (e.g., `ClassName.FieldName`).

**Static Constructor:**
- A static constructor is a special constructor in a class that is called only once when the class is first accessed or when a static member of the class is accessed.
- It is used to initialize static members or perform other one-time setup tasks.
- A class can have only one static constructor, and it is implicitly called by the runtime.

**Static Properties:**
- Static properties are used to expose class-level data or behavior.
- They are accessed using the class name (e.g., `ClassName.PropertyName`) and can be read and written like instance properties.
- Static properties can encapsulate static fields and provide controlled access to them.

**Static Methods:**
- Static methods are methods that belong to a class rather than to an instance of the class.
- They can be called using the class name (e.g., `ClassName.MethodName`).
- Static methods do not have access to instance-specific data but can work with static fields and other static members.
- They are often used for utility functions or for operations that do not require an instance.

Here's an example illustrating these concepts:

```csharp
public static class MathUtils
{
    public static double PI = 3.14159265359; // Static field

    static MathUtils() // Static constructor
    {
        Console.WriteLine("MathUtils class is initialized.");
    }

    public static int Add(int a, int b) // Static method
    {
        return a + b;
    }

    private static int result; // Static field

    public static int Result // Static property
    {
        get { return result; }
        set { result = value; }
    }
}
```

In this example, `MathUtils` is a static class with a static field (`PI`), a static constructor (for initialization), a static method (`Add`), and a static property (`Result`). These elements are accessed using the class name `MathUtils`.

  ### Abstract
- **Concept**: An abstract class cannot be instantiated and is often used as a base class. Abstract members are declared in an abstract class and must be implemented by non-abstract classes that derive from it.
- **Implementation**:
  ```csharp
  public abstract class Vehicle { // Abstract class
      public abstract void Drive(); // Abstract method
  }

  public class Car : Vehicle {
      public override void Drive() {
          // Implementation
      }
  }
  ```

  Certainly! Let's expand on the previous topics by adding the concept of "Type of" in C#, which is important for working with types at runtime.

### Type of
- **Concept**: The `typeof` operator in C# is used to get the `System.Type` object for a type. This is useful for reflection, which involves inspecting the metadata of types at runtime, such as getting the type of a class, interface, or even primitive types. `System.Type` contains information about the type, such as its properties, methods, and fields.
- **Implementation**:
  ```csharp
  Type carType = typeof(Car);
  Console.WriteLine(carType.Name); // Outputs: Car
  ```
  
- **Usage Context**: `typeof` is often used when you need to pass a type as a parameter to methods that perform reflection. For example, it is commonly used with attributes or when dynamically creating instances of types.

### Practical Example Including `typeof`

Here's a practical example incorporating the `typeof` concept along with a class, fields, methods, and properties, to give you a holistic view of how these concepts can be interwoven in C#:

```csharp
using System;

public class Car {
    // Private field
    private string color;

    // Public property
    public string Color {
        get { return color; }
        set { color = value; }
    }

    // Constructor
    public Car(string initialColor) {
        color = initialColor;
    }

    // Method
    public void Drive() {
        Console.WriteLine("The car is driving.");
    }

    // Static method to demonstrate `typeof`
    public static void DisplayTypeInfo() {
        Type carType = typeof(Car);
        Console.WriteLine($"Type Name: {carType.Name}");
        Console.WriteLine($"Namespace: {carType.Namespace}");
        Console.WriteLine($"Assembly: {carType.Assembly.GetName().Name}");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Red");
        Console.WriteLine($"Car Color: {Car.Color}");
        Car.Drive();
        
        // Display type information using `typeof`
        Car.DisplayTypeInfo();
    }
}
```

This example demonstrates creating a `Car` class with a constructor, a method, and a property. Additionally, it showcases how to use the `typeof` operator to obtain and display type information at runtime, emphasizing the dynamic capabilities C# provides for working with types.

Comparing types in C# can be done in various ways, depending on the context and what specifically you're trying to achieve. Below are several common methods for comparing types, each serving different use cases:

### Using `typeof` with `==` Operator

When you want to check if an object is of a specific type, you can use the `typeof` operator along with the `==` operator. This is useful for type comparisons at compile time.

```csharp
if (obj.GetType() == typeof(MyClass)) {
    // The object is of type MyClass
}
```

### Using `is` Operator

The `is` operator is used to check if an object is compatible with a given type. This is a runtime check that considers the actual type of the object, including its base classes and implemented interfaces.

```csharp
if (obj is MyClass) {
    // The object is of type MyClass or derives from MyClass
}
```

### Using `GetType` and `Type.Equals` Method

For a more precise type comparison, especially when dealing with runtime types, you can use the `GetType` method on the object and then call the `Equals` method on the resulting `Type` instance.

```csharp
if (obj.GetType().Equals(typeof(MyClass))) {
    // The object's type is exactly MyClass
}
```

### Using `typeof` with `.IsAssignableFrom()`

When you need to check if a type is assignable from another type (i.e., if an instance of one type can be assigned to a variable of another type), use the `Type.IsAssignableFrom` method. This is useful for checking inheritance or interface implementation relationships.

```csharp
if (typeof(BaseClass).IsAssignableFrom(obj.GetType())) {
    // obj is or derives from BaseClass
}
```

### Example

Here's an example demonstrating these methods to compare types:

```csharp
using System;

public class BaseClass { }
public class DerivedClass : BaseClass { }

class Program {
    static void Main() {
        object derivedObj = new DerivedClass();

        // Using typeof with ==
        if (derivedObj.GetType() == typeof(DerivedClass)) {
            Console.WriteLine("derivedObj is exactly of type DerivedClass");
        }

        // Using is operator
        if (derivedObj is BaseClass) {
            Console.WriteLine("derivedObj is or derives from BaseClass");
        }

        // Using GetType and Type.Equals
        if (derivedObj.GetType().Equals(typeof(DerivedClass))) {
            Console.WriteLine("derivedObj's type is exactly DerivedClass");
        }

        // Using typeof with .IsAssignableFrom()
        if (typeof(BaseClass).IsAssignableFrom(derivedObj.GetType())) {
            Console.WriteLine("derivedObj is or derives from BaseClass (IsAssignableFrom)");
        }
    }
}
```

Each method serves different purposes:
- Use `==` with `typeof` for exact type comparisons.
- Use `is` for type compatibility checks, including derived types and implementations.
- Use `GetType().Equals(typeof(...))` for exact runtime type comparisons.
- Use `IsAssignableFrom` to check if an instance of one type can be used where another type is expected, considering inheritance and interface implementation.