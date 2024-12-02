class Employee{
 

 private int _id;
 private string _firstName="";
private string _lastName="";
private string _email="";
private decimal _salary=0;
private char gender = '\0';

private bool _isManager = false;




public Employee(int id, string firstName, string lastName, string email, decimal salary,char gender, bool isManager){
    _id = id;
    _firstName = firstName;
    _lastName = lastName;
    _email = email;
    _salary = salary;
    _isManager = isManager;

}




}