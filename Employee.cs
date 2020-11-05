using System;

class Employee 
{

private string FirstName;
private string LastName;
private int age;
private int YearlySalary;
private int SalaryPercent;
private int id;
private string EmploymentStatus;

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
  else if (EmploymentStatus == "active")
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

public void IncreaseSalary(int salarypercent)
{
 SalaryPercent = salarypercent;

 if (SalaryPercent >= 0)
 {
 YearlySalary = ((YearlySalary * (SalaryPercent/100)) + YearlySalary);
 Console.WriteLine("Yearly Salary updated to " + YearlySalary);
 }
 else 
 {
   Console.WriteLine("Invalid input. Yearly salary not updated.");
 }
}

















}