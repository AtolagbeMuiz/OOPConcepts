public class ContractEmployee : Employee
{
    public string _employeeType;

    //Method Hiding
    //This "new" keyword helps to hide a method
    public new void printFullName()
    {
        System.Console.WriteLine(_firstName + " " + _lastName + " "+ _employeeType);
    }
}