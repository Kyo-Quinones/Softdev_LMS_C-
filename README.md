**CS 26/L Object Oriented Programming**
**2nd Laboratory Exam**

Duration: 1 hour
Environment: C# .NET Framework (WinForms)
Topics: OOP, Inheritance, Abstraction, Interfaces, Dependency Injection, SOLID principles

**GENERAL INSTRUCTIONS**
Download the project from the given repository link.
Analyze the project class structure:
•	Each button on the form corresponds to one problem.
•	Each item is worth 10 points.
•	All outputs must be shown using MessageBox.Show().
•	Follow SOLID principles and proper OOP structure.

**5 PROBLEMS (10 points each)**

**1. Get Employee Full Name**
Goal: Demonstrate inheritance and method overriding.

Requirements:
Create a RegularEmployee instance from form user input.
Call RegularEmployee.GetFullName() from the inherited Person class.

Display the message: “Hello! DelaCruz, Juan”
Trigger : btnItem_click → show MessageBox with the correct full name.


**2. Show Regular Employee Salary**
Goal: Demonstrate polymorphism and abstract method implementation.

Requirements
Create a RegularEmployee instance from form user input.
Implement CalculateSalary() in RegularEmployee.

Display: “Monthly Salary is 50000.00”
Trigger : btnItem2_click → show salary.


**3. Saving to MySQL (via Dependency Injection)**
Goal: Implement DI using the UML structure.

Requirements
Implement IEmployeeRepository and MySqlRepository.
Implement EmployeeManager that receives IEmployeeRepository repo in its constructor.

Display: “Saving To MySQL…”

Create a RegularEmployee instance from form user input.
Use: manager.AddEmployee(employee);
Trigger btnItem3_click → Must show "Saving To MySQL".


**4. Manager Leave Approval**
Goal: Implement interface functionality.

Requirements
Create a Manager class that inherits from RegularEmployee and implements ILeaveApprover.

The method ApproveLeave(), 
must show: ”Leave Approved!”
Trigger : btnItem4_click → call manager.ApproveLeave().


**5. Show Contractual Employee Salary**
Goal: Implement a different salary computation logic.

Requirements
Create a ContractualEmployee instance from form user input
Name: Juan Dela Cruz
HourlyRate: 500
HoursWorked: 8
Implement CalculateSalary() correctly.

Display: “Total Salary is 4000.00”
Trigger : btnItem5_click → show computed salary.
