using System;
using System.Collections.Generic;

namespace CustomerClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEST 1 - DEFAULT CONSTRUCTOR

            Console.WriteLine("TEST #1 - Default Constructor");

            Customer objCustomer1 = new Customer();

            objCustomer1.Print();

            Console.WriteLine("CustomerID = {0}",
                objCustomer1.CustomerID);

            Console.WriteLine("CustomerType is NULL = {0}",
                objCustomer1.CustomerType == '\0');

            Console.WriteLine("--------------------------------");

            // TEST 2 - PARAMETERIZED CONSTRUCTOR

            Console.WriteLine("TEST #2 - Parameterized Constructor");

            Customer objCustomer2 = new Customer(
                "Joe",
                "Smith",
                "01/01/1971",
                "100 Main Street",
                "Apt 20",
                "Brooklyn",
                "NY",
                "11201",
                "USA",
                "718-555-1111",
                "joe@shop.com",
                "D1234567",
                DateTime.Parse("12/31/2028"),
                "NY"
            );

            objCustomer2.Print();

            Console.WriteLine("CustomerID = {0}",
                objCustomer2.CustomerID);

            Console.WriteLine("CustomerType is NULL = {0}",
                objCustomer2.CustomerType == '\0');

            Console.WriteLine("--------------------------------");

            // TEST 3 - INSTANCE PROPERTIES

            Console.WriteLine("TEST #3 - Instance Properties");

            objCustomer1.CustomerID = 500;
            objCustomer1.FirstName = "Mary";
            objCustomer1.LastName = "Jones";
            objCustomer1.BirthDate =
                DateTime.Parse("05/15/1990");

            objCustomer1.AddressLine1 = "200 Jay Street";
            objCustomer1.AddressLine2 = "Suite 5";
            objCustomer1.City = "New York";
            objCustomer1.State = "NY";
            objCustomer1.ZipCode = "10001";
            objCustomer1.Country = "USA";
            objCustomer1.Phone = "212-555-2222";
            objCustomer1.Email = "mary@shop.com";

            objCustomer1.DriverLicenseNumber = "M7654321";

            objCustomer1.DriverLicenseExpDate =
                DateTime.Parse("06/30/2030");

            objCustomer1.DriverLicenseState = "NJ";
            objCustomer1.CustomerType = 'R';

            Console.WriteLine("CustomerID = {0}",
                objCustomer1.CustomerID);

            Console.WriteLine("FirstName = {0}",
                objCustomer1.FirstName);

            Console.WriteLine("LastName = {0}",
                objCustomer1.LastName);

            Console.WriteLine("BirthDate = {0}",
                objCustomer1.BirthDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("AddressLine1 = {0}",
                objCustomer1.AddressLine1);

            Console.WriteLine("AddressLine2 = {0}",
                objCustomer1.AddressLine2);

            Console.WriteLine("City = {0}", objCustomer1.City);
            Console.WriteLine("State = {0}", objCustomer1.State);
            Console.WriteLine("ZipCode = {0}", objCustomer1.ZipCode);
            Console.WriteLine("Country = {0}", objCustomer1.Country);
            Console.WriteLine("Phone = {0}", objCustomer1.Phone);
            Console.WriteLine("Email = {0}", objCustomer1.Email);

            Console.WriteLine("DriverLicenseNumber = {0}",
                objCustomer1.DriverLicenseNumber);

            Console.WriteLine("DriverLicenseExpDate = {0}",
                objCustomer1.DriverLicenseExpDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("DriverLicenseState = {0}",
                objCustomer1.DriverLicenseState);

            Console.WriteLine("CustomerType = {0}",
                objCustomer1.CustomerType);

            objCustomer1.CustomerType = 'C';

            Console.WriteLine("Changed CustomerType = {0}",
                objCustomer1.CustomerType);

            Console.WriteLine("--------------------------------");

            // TEST 4 - READ-ONLY AGE

            Console.WriteLine("TEST #4 - Read-only Age");

            Console.WriteLine("Customer 1 BirthDate = {0}, Age = {1}",
                objCustomer1.BirthDate.ToString("MM/dd/yyyy"),
                objCustomer1.Age);

            Console.WriteLine("Customer 2 BirthDate = {0}, Age = {1}",
                objCustomer2.BirthDate.ToString("MM/dd/yyyy"),
                objCustomer2.Age);

            Console.WriteLine("--------------------------------");

            // TEST 5 - PRINT METHOD

            Console.WriteLine("TEST #5 - Print Method");

            objCustomer1.Print();

            Console.WriteLine("--------------------------------");

            // TEST 6 - DATA ACCESS METHODS

            Console.WriteLine("TEST #6 - Data Access Methods");

            Console.WriteLine("Load returned: {0}",
                objCustomer1.Load(500));

            Console.WriteLine("LoadByDriverLicenseNumber returned: {0}",
                objCustomer1.LoadByDriverLicenseNumber("M7654321"));

            Console.WriteLine("Insert returned: {0}",
                objCustomer1.Insert());

            Console.WriteLine("Update returned: {0}",
                objCustomer1.Update());

            Console.WriteLine("Delete returned: {0}",
                objCustomer1.Delete(500));

            Console.WriteLine("DeleteByDriverLicenseNumber returned: {0}",
                objCustomer1.DeleteByDriverLicenseNumber("M7654321"));

            Console.WriteLine("--------------------------------");

            // TEST 7 - GET ALL CUSTOMERS

            Console.WriteLine("TEST #7 - GetAllCustomers");

            List<Customer> customerList =
                Customer.GetAllCustomers();

            if (customerList == null)
            {
                Console.WriteLine("GetAllCustomers returned NULL");
            }
            else
            {
                Console.WriteLine("Records returned: {0}",
                    customerList.Count);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("ALL TESTS COMPLETED");
        }
    }
}