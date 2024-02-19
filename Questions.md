### Part 1
[Page1](Training/Page1.md)

#### Q1: What does it mean to create an "instance" of an object?
It means to make one or many objects according to an outline, say you wanted a million variations of the class "Coat", this would use instances

#### Q2: What does it mean when we say "Create a local variable"?
Create an independent variable, this means no other code communicates back and forth with it outside of the code

#### Q3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?
It makes it so that all of those members are accessible by other static modifiers across your code

#### Q4: Do you need an instance of an object to call a static method?
No

#### Q5: Can you create an instance of a static class?
No

#### Q6: Can you manually call a static constructor? When is it called?
No, it is called when the code starts up I believe

#### Q7: Did you have to create an instance of MyDatabase to access Data? Why?
No, because the Database had a return to view the information on the list

#### Q8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?
Because it's originating from the Database I think, this is because the list loads before everything and it's usual to write something along the line of "loading" or "fetching" when setting information 


### Part 2
[Page2](Training/Page2.md)

#### Q9: What is encapsulation?
"encapsulating" data such as variables and methods into a class

#### Q10: What are the other two, or 3 depending on the source, pillars of object-oriented programming?
inheritance and polymorphism,
i: Classes that inherit types from their parents
p: Classes that redefine themselves based on context

#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
Empty

#### Q12: We made our DisplayProductInfo() method `virtual`. What does virtual do?
It allows the original class to be influenced by its children

#### Q13: Why do you think we made that method virtual ( only wrong answer is a blank answer. Give it a shot. )?
To allow versatile manipulation of the DisplayProductInfo based on the situation?

#### Q14: What does dervied mean in the context of inheritance?
Classes or groups of classses that can be derived from a subject or singular object

#### Q15: If one class is derived, the class that it derives from is considered the "b___" class. What is it?
base

#### Q16: When inheriting from a parent class, which class member ( field, constructor, properties, or method ) do you HAVE to create in your child class?
field

#### Q17: Our constructor has the syntax `public Groceries(string name, double price, string expiryDate) : base(name, price)`. What is this for?
This is to indicate what types are inherited by grocery's from the parent

#### Q18: For our DisplayProductInfo() we now used the word `override` instead of `virtual`. Why is that? And what happens if we take the word `virtual` away from the method inside of Product?
In order to override the parent class' returning an inproperly formatted message. Because in the case of Product, virtual is needed to let override do it's thing and reformat the returned text

#### Q19: Because we inherited from Parent, what class members did we get access to in Groceries?
(Unsure about the question) Name and Price originated from the parent class, but we gained access to expiration date in the new class due to the new type

#### Q20: What access modifier is needed for everything in your project to have access to class members ( there are 2 that would work )?
internal and public (but I typically use static for organization, I know it's not one though)

#### Q21: When each instanced object called `DisplayProductInfo()` the output was different based on the object. Why is that?
Because of the virtual operator combined with override, this overrode the parent class return value and resulted in the different output

#### (new) Q22: What were we able to store from our child classes in a list of Product?
A set of types bound together by the constructor

#### (new) Q23: We were able to use method DisplayproductInfo() on every object, even though each object was directly a product. Why is that?
Because they were made by a constructor and are now their own object, holding information accessible by DisplayproductInfo();

#### (new) Q24: If I tried to access the Expirty Date field of a product, waht would happen? Why would it happen?
Nothing as long as it isn't a grocery class, this is because anything that isn't groceries, a child of product, doesn't hold expiration date


## Part 3
[Page3](Training/Page3.md)

#### Q22: What does the abstract keyword do exactly? What does it prevent?
It makes it so that calling DisplayProductInfo(); doesn't require an override I believe, this prevents the need to make a bunch of variations and overcomplications to displaying info on different classes

#### Q23: The abstract method no longer has a body, why is that? We also removed the word virtual, how do virtual and abstract relate?
That is because abstract methods don't contain bodies otherwise their purpose is ignored, virtual and abstract are similar as they both enable or are meant to be used by other classes

#### Q24: We turned our constructor's accessible type to `protected`. What objects have access to the constructor now that it's `protected`. And since we turned our class `abstract` why doesn't it matter that we can't create a new instance of `Product` in main?
Children of the Person class are able to access it. Since Product by itself isn't useful enough the instances of it are worth more as they can accurately depict the information far better than a general parent

#### Q25: The other classes didn't need to be changed. Specifically, the DisplayProductInfo() didn't need any changing when we swapped our method from virtual to abstract. Why?
DisplayProductInfo(); is the name of all the descriptions now, only changing depending on what is being referenced, this means that the only needed changes are from the children


## Part 4
[Page4](Training/Page4.md)

#### Q26: We set our set to private. What does private mean? And why might we want to set our set to private for our connection string (take a guess)?
I think that is because of security reasons 


## Part 5
[Page5](Training/Page5.md)

#### Q27: What method is used to get the TYPE of an instance of an object?
GetType()

#### Q28: What method can we use to check if one type is another?
is
