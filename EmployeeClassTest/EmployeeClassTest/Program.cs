using System;
using System.Collections.Generic;

namespace EmployeeClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEST 1 - DEFAULT CONSTRUCTOR

            Console.WriteLine("TEST #1 - Default Constructor");
            Console.WriteLine();

            Employee objEmployee1 = new Employee();

            objEmployee1.Print();

            Console.WriteLine();
            Console.WriteLine("Employee Count = {0}",
                Employee.Count);

            Console.WriteLine("--------------------------------");

            // TEST 2 - PARAMETERIZED CONSTRUCTOR

            Console.WriteLine("TEST #2 - Parameterized Constructor");
            Console.WriteLine();

            Employee objEmployee2 = new Employee(
                111,
                "Joe",
                "Smith",
                "111-22-3333",
                DateTime.Parse("01/01/1971"),
                "100 Main Street",
                "Apt 20",
                "Brooklyn",
                "NY",
                "11201",
                "USA",
                "718-555-1111",
                "Software Developer",
                "joe@comp1.com"
            );

            objEmployee2.Print();

            Console.WriteLine();
            Console.WriteLine("Employee Count = {0}",
                Employee.Count);

            Console.WriteLine("--------------------------------");

            // TEST 3 - INSTANCE PROPERTIES

            Console.WriteLine("TEST #3 - Instance Properties");

            objEmployee1.EmployeeID = 222;
            objEmployee1.FirstName = "Mary";
            objEmployee1.LastName = "Jones";
            objEmployee1.SSNumber = "444-55-6666";
            objEmployee1.BirthDate =
                DateTime.Parse("05/15/1990");

            objEmployee1.AddressLine1 = "200 Jay Street";
            objEmployee1.AddressLine2 = "Suite 5";
            objEmployee1.City = "New York";
            objEmployee1.State = "NY";
            objEmployee1.ZipCode = "10001";
            objEmployee1.Country = "USA";
            objEmployee1.Phone = "212-555-2222";
            objEmployee1.Email = "mary@comp1.com";
            objEmployee1.JobTitle = "Project Manager";

            Console.WriteLine("EmployeeID = {0}",
                objEmployee1.EmployeeID);

            Console.WriteLine("FirstName = {0}",
                objEmployee1.FirstName);

            Console.WriteLine("LastName = {0}",
                objEmployee1.LastName);

            Console.WriteLine("SSNumber = {0}",
                objEmployee1.SSNumber);

            Console.WriteLine("BirthDate = {0}",
                objEmployee1.BirthDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("AddressLine1 = {0}",
                objEmployee1.AddressLine1);

            Console.WriteLine("AddressLine2 = {0}",
                objEmployee1.AddressLine2);

            Console.WriteLine("City = {0}", objEmployee1.City);
            Console.WriteLine("State = {0}", objEmployee1.State);
            Console.WriteLine("ZipCode = {0}", objEmployee1.ZipCode);
            Console.WriteLine("Country = {0}", objEmployee1.Country);
            Console.WriteLine("Phone = {0}", objEmployee1.Phone);
            Console.WriteLine("Email = {0}", objEmployee1.Email);
            Console.WriteLine("JobTitle = {0}", objEmployee1.JobTitle);

            Console.WriteLine("--------------------------------");

            // TEST 4 - READ-ONLY AGE PROPERTY

            Console.WriteLine("TEST #4 - Read-only Age");

            Console.WriteLine("Employee 1 BirthDate = {0}, Age = {1}",
                objEmployee1.BirthDate.ToString("MM/dd/yyyy"),
                objEmployee1.Age);

            Console.WriteLine("Employee 2 BirthDate = {0}, Age = {1}",
                objEmployee2.BirthDate.ToString("MM/dd/yyyy"),
                objEmployee2.Age);

            Console.WriteLine("--------------------------------");

            // TEST 5 - STATIC COUNT PROPERTY

            Console.WriteLine("TEST #5 - Static Count Property");

            Console.WriteLine("Current Count = {0}", Employee.Count);

            Employee.Count = 50;

            Console.WriteLine("Set Count to 50, Get Count = {0}",
                Employee.Count);

            Employee.Count = 2;

            Console.WriteLine("Reset Count = {0}", Employee.Count);

            Employee objEmployee3 = new Employee();

            Console.WriteLine("Count after third Employee = {0}",
                Employee.Count);

            Console.WriteLine("--------------------------------");

            // TEST 6 - PRINT METHOD

            Console.WriteLine("TEST #6 - Print Method");

            objEmployee1.Print();

            Console.WriteLine("--------------------------------");

            // TEST 7 - DATA ACCESS METHODS

            Console.WriteLine("TEST #7 - Data Access Methods");

            Console.WriteLine("Load returned: {0}",
                objEmployee2.Load(111));

            Console.WriteLine("Insert returned: {0}",
                objEmployee2.Insert());

            Console.WriteLine("Update returned: {0}",
                objEmployee2.Update());

            Console.WriteLine("Delete returned: {0}",
                objEmployee2.Delete(111));

            Console.WriteLine("--------------------------------");

            // TEST 8 - GET ALL EMPLOYEES

            Console.WriteLine("TEST #8 - GetAllEmployees");

            List<Employee> employeeList =
                Employee.GetAllEmployees();

            if (employeeList == null)
            {
                Console.WriteLine("GetAllEmployees returned NULL");
            }
            else
            {
                Console.WriteLine("Records returned: {0}",
                    employeeList.Count);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("ALL TESTS COMPLETED");
        }
    }
}