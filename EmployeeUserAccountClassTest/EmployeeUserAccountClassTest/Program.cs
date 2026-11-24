using System;
using System.Collections.Generic;

namespace EmployeeUserAccountClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEST 1 - DEFAULT FACTORY METHOD

            Console.WriteLine("TEST #1 - Default Factory Method");

            EmployeeUserAccount objAccount1 =
                EmployeeUserAccount.GetInstance();

            Console.WriteLine("UserAccountID = {0}",
                objAccount1.UserAccountID);

            Console.WriteLine("Username = {0}",
                objAccount1.Username);

            Console.WriteLine("Password = {0}",
                objAccount1.Password);

            Console.WriteLine("Email = {0}",
                objAccount1.Email);

            Console.WriteLine("--------------------------------");

            // TEST 2 - PARAMETERIZED FACTORY METHOD

            Console.WriteLine("TEST #2 - Parameterized Factory Method");

            EmployeeUserAccount objAccount2 =
                EmployeeUserAccount.GetInstance(
                    "joe", "111", "joe@comp1.com");

            Console.WriteLine("UserAccountID = {0}",
                objAccount2.UserAccountID);

            Console.WriteLine("Username = {0}",
                objAccount2.Username);

            Console.WriteLine("Password = {0}",
                objAccount2.Password);

            Console.WriteLine("Email = {0}",
                objAccount2.Email);

            Console.WriteLine("Unique GUIDs = {0}",
                objAccount1.UserAccountID !=
                objAccount2.UserAccountID);

            Console.WriteLine("--------------------------------");

            // TEST 3 - INSTANCE PROPERTIES

            Console.WriteLine("TEST #3 - Instance Properties");

            objAccount1.Username = "mary";
            objAccount1.Password = "222";
            objAccount1.Email = "mary@comp1.com";

            Console.WriteLine("Username = {0}",
                objAccount1.Username);

            Console.WriteLine("Password = {0}",
                objAccount1.Password);

            Console.WriteLine("Email = {0}",
                objAccount1.Email);

            Console.WriteLine("UserAccountID = {0}",
                objAccount1.UserAccountID);

            Console.WriteLine("--------------------------------");

            // TEST 4 - AUTHENTICATE METHOD

            Console.WriteLine("TEST #4 - Authenticate Method");

            Console.WriteLine("Correct username and password: {0}",
                objAccount2.Authenticate("joe", "111"));

            Console.WriteLine("Wrong password: {0}",
                objAccount2.Authenticate("joe", "999"));

            Console.WriteLine("Wrong username: {0}",
                objAccount2.Authenticate("bob", "111"));

            Console.WriteLine("Both incorrect: {0}",
                objAccount2.Authenticate("bob", "999"));

            Console.WriteLine("--------------------------------");

            // TEST 5 - DATA ACCESS METHODS

            Console.WriteLine("TEST #5 - Data Access Methods");

            string id = objAccount2.UserAccountID;

            Console.WriteLine("Load returned: {0}",
                objAccount2.Load(id));

            Console.WriteLine("LoadByUsername returned: {0}",
                objAccount2.LoadByUsername("joe"));

            Console.WriteLine("Insert returned: {0}",
                objAccount2.Insert());

            Console.WriteLine("Update returned: {0}",
                objAccount2.Update());

            Console.WriteLine("Delete returned: {0}",
                objAccount2.Delete(id));

            Console.WriteLine("DeleteByUsername returned: {0}",
                objAccount2.DeleteByUsername("joe"));

            Console.WriteLine("--------------------------------");

            // TEST 6 - GET ALL EMPLOYEE USER ACCOUNTS

            Console.WriteLine("TEST #6 - GetAllEmployeeUserAccounts");

            List<EmployeeUserAccount> accountList =
                EmployeeUserAccount.GetAllEmployeeUserAccounts();

            if (accountList == null)
            {
                Console.WriteLine(
                    "GetAllEmployeeUserAccounts returned NULL");
            }
            else
            {
                Console.WriteLine("Records returned: {0}",
                    accountList.Count);
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("ALL TESTS COMPLETED");
        }
    }
}