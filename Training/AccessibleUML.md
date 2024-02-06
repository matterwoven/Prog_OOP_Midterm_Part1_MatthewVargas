### UML Diagram Description

#### Classes and Their Members

- **Product**
  - **Properties:**
    - `Name: string` - Public access.
    - `Price: double` - Public access.
  - **Constructor:**
    - `Product(name: string, price: double)` - Protected access. Initializes a new instance of the Product class with `name` and `price`.
  - **Methods:**
    - `DisplayProductInfo(): void` - Public access. Prints the product's information.

- **Clothing (inherits from Product)**
  - **Properties:**
    - `Size: string` - Public access.
    - `Color: string` - Public access.
  - **Constructor:**
    - `Clothing(name: string, price: double, size: string, color: string)` - Public access. Initializes a new instance of the Clothing class with `name`, `price`, `size`, and `color`.
  - **Methods:**
    - `DisplayProductInfo(): void` - Public access. Overridden to print clothing-specific information including size and color.

- **Electronics (inherits from Product)**
  - **Properties:**
    - `Brand: string` - Public access.
  - **Constructor:**
    - `Electronics(name: string, price: double, brand: string)` - Public access. Initializes a new instance of the Electronics class with `name`, `price`, and `brand`.
  - **Methods:**
    - `DisplayProductInfo(): void` - Public access. Overridden to print electronic product-specific information including the brand.

- **Groceries (inherits from Product)**
  - **Properties:**
    - `ExpiryDate: string` - Public access.
  - **Constructor:**
    - `Groceries(name: string, price: double, expiryDate: string)` - Public access. Initializes a new instance of the Groceries class with `name`, `price`, and `expiryDate`.
  - **Methods:**
    - `DisplayProductInfo(): void` - Public access. Overridden to print groceries-specific information including the expiry date.

#### Relationships

- **Inheritance:**
  - `Clothing`, `Electronics`, and `Groceries` are subclasses of `Product`. This means they inherit `Product`'s properties and methods but also have their own additional members or override inherited methods to provide specific functionality.
