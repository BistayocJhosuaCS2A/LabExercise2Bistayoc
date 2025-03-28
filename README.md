# LabExercise2Bistayoc

## Overview
This is a simple C# console application that demonstrates **inheritance** and **encapsulation** using a `Shoes` class as the base class and a `SportsShoes` class as a derived class.

## Class Structure
- **Shoes (Base Class)**
  - Private fields: `brand`, `size`, `priceRange`
  - Public methods: `DisplayDetails()`, getters and setters
  - Constructor to initialize brand, size, and price range

- **SportsShoes (Derived Class)**
  - Inherits from `Shoes`
  - Adds a new field: `sportType`
  - Overrides `DisplayDetails()`
  - Adds a new method: `ShowSportType()`
 
  - ## Concepts Demonstrated
**Encapsulation**: Private fields with public getters and setters.  
**Inheritance**: `SportsShoes` inherits from `Shoes`.  
**Method Overriding**: `SportsShoes` overrides `DisplayDetails()`.
