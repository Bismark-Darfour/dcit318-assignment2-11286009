# DCIT 318 Assignment 2 - Object-Oriented Programming in C#

## Student ID: 11286009

This assignment demonstrates three fundamental aspects of Object-Oriented Programming in C#:

## 1. Inheritance and Method Overriding

**Location:** `InheritanceAndOverriding/`

**Demonstrates:**
- Base class `Animal` with virtual method `MakeSound()`
- Derived classes `Dog` and `Cat` that override `MakeSound()`
- Polymorphism using base class references

**Key Concepts:**
- Virtual methods and method overriding
- Inheritance hierarchy
- Runtime polymorphism

**To Run:**
```bash
cd InheritanceAndOverriding
dotnet run
```

## 2. Abstract Classes and Methods

**Location:** `AbstractClassesAndMethods/`

**Demonstrates:**
- Abstract class `Shape` with abstract method `GetArea()`
- Derived classes `Circle` and `Rectangle` implementing `GetArea()`
- Mathematical calculations for different shapes

**Key Concepts:**
- Abstract classes and methods
- Forced implementation in derived classes
- Polymorphism with abstract base classes

**To Run:**
```bash
cd AbstractClassesAndMethods
dotnet run
```

## 3. Interfaces

**Location:** `Interfaces/`

**Demonstrates:**
- Interface `IMovable` with method `Move()`
- Classes `Car` and `Bicycle` implementing `IMovable`
- Additional interface `IFuelable` for multiple interface implementation

**Key Concepts:**
- Interface definition and implementation
- Multiple interface implementation
- Interface-based polymorphism
- Type checking with interfaces

**To Run:**
```bash
cd Interfaces
dotnet run
```

## Running All Applications

To test all applications, run the following commands from the root directory:

```bash
# Test Application 1
cd InheritanceAndOverriding && dotnet run && cd ..

# Test Application 2
cd AbstractClassesAndMethods && dotnet run && cd ..

# Test Application 3
cd Interfaces && dotnet run && cd ..
```

## Requirements Met

✅ **Inheritance and Method Overriding**
- Base class `Animal` with `MakeSound()` method
- Derived classes `Dog` and `Cat` with overridden methods
- Main method demonstrating polymorphism

✅ **Abstract Classes and Methods**
- Abstract class `Shape` with abstract `GetArea()` method
- `Circle` and `Rectangle` classes implementing area calculations
- Main method displaying calculated areas

✅ **Interfaces**
- `IMovable` interface with `Move()` method
- `Car` and `Bicycle` classes implementing the interface
- Main method demonstrating interface usage

## Additional Features

Each application includes enhanced features beyond the basic requirements:

1. **Inheritance App**: Demonstrates polymorphism with arrays
2. **Abstract Classes App**: Includes properties, constructors, and additional methods
3. **Interfaces App**: Shows multiple interface implementation and type checking

## Development Environment

- **Framework:** .NET 9.0
- **Language:** C# 12.0
- **Platform:** Cross-platform (Windows, macOS, Linux)

## Notes

All applications are console-based and include user-friendly output with clear demonstrations of each OOP concept. The code follows C# best practices and includes comprehensive comments for educational purposes.
