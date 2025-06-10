# Basic Salary Calculator System

This project reflects my understanding of Object-Oriented Design (OOD) principles through a simple salary calculation system for different types of employees.

## Key OOD Principles Applied

- **Inheritance**:  
  The `Employee` class is an abstract base that holds common attributes and behaviors shared by all employee types. Subclasses like `Manager` and `SalesAgent` inherit from it, reusing and extending its foundation.

- **Encapsulation**:  
  The internal logic for salary calculations is hidden inside the classes. Users interact only through defined operations, ensuring the functionality works as expected and is controlled by the design, without exposing the complexity.

- **Abstraction**:  
  The `Employee` class defines a consistent interface for all employee types. Users can interact with any employee object the same way (e.g., generating a salary slip), regardless of the specific type, simplifying the design.

- **Polymorphism**:  
  Operations like salary slip generation adapt to each employee type. For example, a `Manager` includes an allowance, while a `SalesAgent` adds a commission—yet both can be handled uniformly as `Employee` objects.


## Design Highlights

- An abstract `Employee` class ensures only specific employee types are created, enforcing the inheritance structure.
- Each subclass tailors its behavior (e.g., adding bonuses or allowances) while keeping a unified interface.
- Internal details, like how overtime or taxes are calculated, stay hidden, showcasing encapsulation.

This design prioritizes modularity and consistency, demonstrating OOD principles in action at my current level of understanding—focusing on _why_ and _when_ these concepts matter, not just how they’re coded.