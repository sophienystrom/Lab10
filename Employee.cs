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
  EmploymentStatus = "active";
}

public Employee(string FS, string LS, int AGE, int ID, int yearlysalary)
{
  FirstName = FS;
  LastName = LS;
  age = AGE;
  id = ID;
  YearlySalary = yearlysalary;
  EmploymentStatus = "active";
}

public void RemoveEmployee()
{
 if (EmploymentStatus == "active")
 {
   EmploymentStatus = "inactive";
   Console.WriteLine("Employee removed");
 }
 else 
 {
   Console.WriteLine("Employee already removed");
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