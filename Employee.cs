using System;

class Employee 
{

private string FirstName;
private string LastName;
private int age;
private int YearlySalary;
private double SalaryPercent;
private int id;
private string EmploymentStatus;
private double UpdatedSalary;

public Employee()
{
  FirstName = "unknown";
  LastName = "unknown";
  id = 0;
  age = 0;
  YearlySalary = 0;
  EmploymentStatus = "not applicable";
}

public Employee(string FS, string LS, int AGE, int ID, int yearlysalary)
{
  FirstName = FS;
  LastName = LS;
  age = AGE;
  id = ID;
  YearlySalary = yearlysalary;
}

public void RemoveEmployee()
{
  EmploymentStatus = "inactive";
  Console.WriteLine("Employee removed successfully");

  if (EmploymentStatus == "inactive")
  {
    Console.WriteLine("Employee already inactive");
  }
  else 
  {
    EmploymentStatus = "inactive";
    Console.WriteLine("Employee removed");
  }
}

public void Intro()
{
  Console.WriteLine("First name: " + FirstName);
  Console.WriteLine("Last name: " + LastName);
  Console.WriteLine("Employee ID: " + id);
  Console.WriteLine("Age: " + age);
  Console.WriteLine("Yearly Salary: " + YearlySalary);
}

public void IncreaseSalary(double sp)
{
 SalaryPercent = sp/100;

 if (SalaryPercent >= 0)
 {
 UpdatedSalary = ((YearlySalary * SalaryPercent) + YearlySalary);
 Console.WriteLine("Yearly Salary updated to " + UpdatedSalary);
 }
 else 
 {
   Console.WriteLine("Invalid input. Yearly salary not updated.");
 }
}

















}