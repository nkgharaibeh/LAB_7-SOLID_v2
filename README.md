# LAB_7-SOLID_v2
# C# OOP Journey: From Encapsulation to Interfaces, SOLID, and Design Patterns

This repository is a learning path for **C# Object-Oriented Programming**.
It connects multiple labs into one coherent story:

**Lab 4 → Lab 5 → Lab 6 → Lab 7**
from **Encapsulation/Properties** to **Inheritance**, **Polymorphism**, **Abstraction**, and finally **Interfaces** —
which naturally prepares us for **SOLID** principles and then **Design Patterns**.

---

## Why this repo exists (Agile / Incremental Learning)

Instead of random examples, we build knowledge in **increments**:

1. **Encapsulation (Properties)**: protect and validate state
2. **Inheritance**: reuse common state/behavior
3. **Polymorphism**: same method call, different behavior at runtime
4. **Abstraction (abstract classes)**: define shared contracts + partial implementation
5. **Interfaces**: pure contracts, multiple inheritance of behavior
6. **SOLID**: design rules that scale OOP to real systems
7. **Design Patterns** (next step): reusable architecture solutions

Each increment explains the previous one and introduces exactly one new idea.

---

## Quick Definitions (Core Concepts)

### 1) Field vs Property (Encapsulation)
- **Field**: raw storage (state)
- **Property**: controlled access (validation, hiding implementation)
- Why we use properties: to enforce rules like `0 <= GPA <= 4` and prevent invalid state.

### 2) Inheritance (Lab 5)
- `Child : Parent` means child **inherits** members of parent.
- Main goals:
  - Code reuse
  - Modeling an **IS-A** relationship

### 3) Polymorphism (Lab 6)
Two main types:

**A) Compile-time polymorphism (Overloading)**
- Same method name, different parameter list
- Compiler chooses which method to call

**B) Run-time polymorphism (Overriding)**
- Same method signature
- `virtual` in base + `override` in derived
- Runtime chooses implementation based on actual object type

### 4) Abstraction (Abstract Classes)
- Abstract class can include:
  - fields + constructors
  - shared implementation
  - abstract methods (must be implemented by children)
- Used when you want both:
  - a contract
  - and shared code/state

### 5) Interfaces (Lab 7) — The "Spirit" of OOP Design
- Interface is a **pure contract** (what to do, not how).
- A class can implement **multiple interfaces**.
- Interfaces are the best bridge from OOP syntax to **software design**.

---

## Interfaces → SOLID (Why Interfaces matter)

Interfaces make SOLID practical.

### SRP — Single Responsibility Principle
**One class = one reason to change.**
Example: `App` should not also implement file logging logic.

### OCP — Open/Closed Principle
**Open for extension, closed for modification.**
Example: Add a new `Triangle : IShape` without changing the loop that processes `List<IShape>`.

### LSP — Liskov Substitution Principle
**A subtype must be usable wherever its base type is expected.**
Example: Any class implementing `IAccount` must behave correctly when used as `IAccount`.

### ISP — Interface Segregation Principle
**Prefer small focused interfaces.**
Example: `IRead` and `IWrite` are better than one huge interface forcing read-only classes to implement `Write()`.

### DIP — Dependency Inversion Principle
**High-level modules depend on abstractions, not concrete implementations.**
Example: `App` depends on `ILogger`, not `ConsoleLogger`.

---

## How this prepares us for Design Patterns

When we master Interfaces + SOLID, patterns become natural:

- **Strategy Pattern**: choose algorithm at runtime (`ILogger`, `InterestCalculator`, `PaymentMethod`)
- **Factory Pattern**: create objects without hard-coding concrete classes
- **Decorator Pattern**: add behavior (logging, caching) without changing existing code
- **Adapter Pattern**: integrate external systems via interface contracts

Interfaces are the entry point to all of these patterns.

---

## Suggested Folder Structure (GitHub-friendly)

- One solution with multiple console projects:
  - `Ex01_MethodOverloading`
  - `Ex02_RuntimePolymorphism`
  - `Ex03_AbstractShapes`
  - `Ex04_IShape_OCP_LSP`
  - `Ex05_IRead_IWrite_ISP`
  - `Ex06_ILogger_DIP`
  - `Ex07_Accounts_Abstract_Interface`

> Tip: Do NOT upload `bin/` or `obj/` folders. Use `.gitignore`.

---

## How to Run
1. Open the `.sln` in Visual Studio
2. Right-click any project → **Set as Startup Project**
3. Run

---

## Student Submission Workflow (GitHub)
1. Create a GitHub account
2. Create a new repository named: `CSharp_Labs_<YourName>`
3. Upload your lab folder
4. Commit changes with clear messages:
   - `Add Lab7 interfaces examples`
   - `Implement BankingSystem assignment`
5. Submit the repository link

---

## Final Message
OOP is not only syntax.
This repo is designed to move from:
**writing classes** → to **designing software**.

Interfaces are not "just another keyword":
they are the foundation for SOLID and for professional design patterns.
