### Part 1
[Page1](Training/Page1.md)

#### Q1: What does it mean to create an "instance" of an object?
#### Q2: What does it mean when we say "Create a local variable"?
#### Q3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?
#### Q4: Do you need an instance of an object to call a static method?
#### Q5: Can you create an instance of a static class?
#### Q6: Can you manually call a static constructor? When is it called?
#### Q7: Did you have to create an instance of MyDatabase to access Data? Why?
#### Q8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?

### Part 2
[Page2](Training/Page2.md)

#### Q9: What is encapsulation?
#### Q10: What are the other two, or 3 depending on the source, pillars of object-oriented programming?
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
#### Q12: We made our DisplayProductInfo() method `virtual`. What does virtual do?
#### Q13: Why do you think we made that method virtual ( only wrong answer is a blank answer. Give it a shot. )?
#### Q14: What does dervied mean in the context of inheritance?
#### Q15: Is one class is derived, the class that it derives from is considered the "b___" class. What is it?
#### Q16: When inheriting from a parent class, which class member ( field, constructor, properties, or method ) do you HAVE to create in your child class?
#### Q17: Our constructor has the syntax `public Groceries(string name, double price, string expiryDate) : base(name, price)`. What is this for?
#### Q18: For our DisplayProductInfo() we now used the word `override` instead of `virtual`. Why is that? And what happens if we take the word `virtual` away from the method inside of Product?
#### Q19: Because we inherited from Parent, what class members did we get access to in Groceries?
#### Q20: What access modifier is needed for everything in your project to have access to class members ( there are 2 that would work )?
#### Q21: When each instanced object called `DisplayProductInfo()` the output was different based on the object. Why is that?

## Part 3
[Page3](Training/Page3.md)

#### Q22: What does the abstract keyword do exactly? What does it prevent?
#### Q23: The abstract method no longer has a body, why is that? We also removed the word virtual, how do virtual and abstract relate?
#### Q24: We turned our constructor's accessible type to `protected`. What objects have access to the constructor now that it's `protected`. And since we turned our class `abstract` why doesn't it matter that we can't create a new instance of `Product` in main?
#### Q25: The other classes didn't need to be changed. Specifically, the DisplayProductInfo() didn't need any changing when we swapped our method from virtual to abstract. Why?

## Part 4
[Page4](Training/Page4.md)

#### Q26: We set our set to private. What does private mean? And why might we want to set our set to private for our connection string (take a guess)?

## Part 5
[Page5](Training/Page5.md)

#### Q27: What method is used to get the TYPE of an instance of an object?
#### Q28: What method can we use to check if one type is another?