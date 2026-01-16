- First build the project using `dotnet build` and then execute the command `dotnet run`.

- Inheritance is prone to "Fragile Base Class Problem" where changes in base class can inadvertently break the functionality of derived classes. It creates tight coupling between base and derived classes. It also limits extensibility as modifications in base class can become increasingly risky and costly over time.

- For mitigating these issues, developers can use SOLID - Open/Closed Principle (OCP) and Dependency Inversion Principle (DIP), as well as prefer Composition over Inheritance.