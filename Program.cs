using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE._firstName = "Muiz";
            PTE._lastName = "Atolagbe";
            PTE._employeeType = "Part Time";
            PTE.printFullName();

            ContractEmployee CTE = new ContractEmployee();
            CTE._firstName = "Andrew";
            CTE._lastName = "Ifedayo";
            CTE._employeeType = "Contract";
            CTE.printFullName();


            //Inheritance allows us to point child(Derived) class object using base class reference variable
            //multiple class inheritance is not possible in C#/.NET
            //but we can inherit multiple 
            //and also we can do multi-level inheritance i.e. Contract Employee can inherit from PArt time employee and Part time employee inherting from the base employee class
            Employee employee = new PartTimeEmployee();

            Parent parent = new Parent();
            Child child = new Child();

            //     Parent refParent = new Child();
            //     //Child refChild = new Parent();

           parent.printParentClassDetails();
           child.printChildClassDetails();
           child.printParentClassDetails();
           //refParent.printChildClassDetails();
            
            //refChild.printClassDetails();
        }
    }
}
