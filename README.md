Mortgage Approval System - Façade Design Pattern Implementation
This project demonstrates the use of the Façade Design Pattern to simplify and streamline the mortgage approval process in a banking system. The Façade pattern provides a unified, high-level interface that makes the interaction with complex subsystems more accessible. The goal of this project is to implement the facade that handles communication between different subsystems involved in the mortgage approval process, such as the Bank, Credit, and Loan subsystems.

Overview
In a typical mortgage approval system, there are multiple components responsible for various tasks like checking credit history, verifying bank policies, and calculating loan eligibility. Each of these components can have complex methods and interfaces. The Façade pattern addresses this issue by providing a simplified interface that clients can use, without needing to deal with the complexity of each subsystem.

The Façade Design Pattern
Purpose: The Façade pattern provides a unified interface to a set of interfaces in a subsystem, thus making the subsystem easier to use.
Advantage: Clients interact with a single, simplified interface, instead of dealing with the complexity of multiple subsystems.
Components of the System:
Bank Subsystem: This subsystem contains methods to verify if the customer is eligible for a mortgage based on bank policies.
Credit Subsystem: This subsystem checks the customer's credit score and determines whether they meet the requirements for mortgage approval.
Loan Subsystem: This subsystem calculates the loan amount based on the customer’s eligibility and determines the loan terms.
Façade Interface
The MortgageFacade class provides an interface for clients to interact with the system. It hides the complexity of the subsystems, offering simple methods for:

Checking credit scores
Verifying bank policies
Calculating the loan eligibility
Making the mortgage approval decision
Benefits of Using Façade in this Project:
Simplicity: Clients can easily request mortgage approval without understanding the complexities of underlying systems.
Reduced Coupling: The client interacts only with the facade, not the internal subsystems.
Ease of Maintenance: Changes to individual subsystems are less likely to affect clients using the facade.
Features:
Unified interface for mortgage approval.
Checks customer credit score.
Verifies eligibility with bank policies.
Calculates loan eligibility and final approval.
Clean and easy-to-understand design based on the Façade pattern.
How to Use:
Clone the repository:
bash
Copy code
git clone https://github.com/yourusername/mortgage-approval-facade.git
Navigate to the project directory:
bash
Copy code
cd mortgage-approval-facade
Run the application:
bash
Copy code
java MortgageFacade
You will be prompted to input customer details, such as name, credit score, and loan amount. The system will then process the information and provide a decision regarding mortgage approval.

Technologies Used:
Java (Core)
Object-Oriented Design (OOD)
Façade Design Pattern
Project Structure:
MortgageFacade.java: The Façade class that exposes a simplified interface.
Bank.java: Subsystem class responsible for checking bank eligibility.
Credit.java: Subsystem class that validates the customer's credit score.
Loan.java: Subsystem class that calculates the loan eligibility and terms.
License:
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgements:
The idea and concept of this project are based on the Façade Design Pattern.![Screenshot (193)](https://github.com/user-attachments/assets/711c9515-5c24-471d-858f-acc577e51612)
![Screenshot (194)](https://github.com/user-attachments/assets/18f084dc-96e3-4ba1-b9ff-fd268c47544b)
