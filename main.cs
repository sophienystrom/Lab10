using System;

class MainClass {
  public static void Main (string[] args) {
    
  Employee employee1 = new Employee();
  employee1.Intro();

  Console.WriteLine(" ");

  Employee employee2 = new Employee("Robert", "Downey", 18, 1, 100);
  employee2.Intro();

  Console.WriteLine(" ");

  Employee employee3 = new Employee("John", "Smith", 38, 50089, 50000);
  employee3.Intro();
  employee3.IncreaseSalary(-2);
  employee3.RemoveEmployee();

  Console.WriteLine(" ");
  
  Employee employee4 = new Employee("Maria", "Lambert", 26, 50100, 80000);
  employee4.Intro();
  employee4.IncreaseSalary(7);
  employee4.RemoveEmployee();
  employee4.RemoveEmployee();









    
  }
}