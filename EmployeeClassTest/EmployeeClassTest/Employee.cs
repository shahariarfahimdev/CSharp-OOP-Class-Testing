using System;
using System.Collections.Generic;

namespace EmployeeClassTest
{
    public class Employee
    {
        // PRIVATE INSTANCE AND STATIC DATA

        private int _EmployeeID;
        private string _FirstName;
        private string _LastName;
        private string _SSNumber;
        private DateTime _BirthDate;
        private int _Age;
        private string _AddressLine1;
        private string _AddressLine2;
        private string _City;
        private string _State;
        private string _ZipCode;
        private string _Country;
        private string _Phone;
        private string _Email;
        private string _JobTitle;

        private static int _Count = 0;

        // PUBLIC PROPERTIES

        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string SSNumber
        {
            get { return _SSNumber; }
            set { _SSNumber = value; }
        }

        public virtual DateTime BirthDate
        {
            get { return _BirthDate; }
            set
            {
                _BirthDate = value;
                _Age = CalculateAge(value);
            }
        }

        public int Age
        {
            get { return _Age; }
        }

        public string AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }

        public static int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        // DEFAULT CONSTRUCTOR

        public Employee()
        {
            _EmployeeID = 0;
            _FirstName = "";
            _LastName = "";
            _SSNumber = "";
            _BirthDate = new DateTime().Date;
            _Age = 0;
            _AddressLine1 = "";
            _AddressLine2 = "";
            _City = "";
            _State = "";
            _ZipCode = "";
            _Country = "";
            _Phone = "";
            _JobTitle = "";
            _Email = "";

            _Count = _Count + 1;
        }

        // PARAMETERIZED CONSTRUCTOR

        public Employee(
            int eID, string fN, string lN,
            string ssN, DateTime bD,
            string add1, string add2,
            string c, string s, string z,
            string co, string p,
            string jT, string e)
        {
            _FirstName = _LastName = _SSNumber =
            _AddressLine1 = _AddressLine2 =
            _City = _State = _ZipCode =
            _Country = _Phone = _Email =
            _JobTitle = "";

            EmployeeID = eID;
            FirstName = fN;
            LastName = lN;
            SSNumber = ssN;
            BirthDate = bD;
            AddressLine1 = add1;
            AddressLine2 = add2;
            City = c;
            State = s;
            ZipCode = z;
            Country = co;
            Phone = p;
            JobTitle = jT;
            Email = e;

            _Count = _Count + 1;
        }

        // DESTRUCTOR

        ~Employee()
        {
        }

        // PUBLIC INSTANCE METHODS

        public void Print()
        {
            Console.WriteLine("Employee information:");
            Console.WriteLine("Employee ID = {0}", _EmployeeID);
            Console.WriteLine("First Name = {0}", _FirstName);
            Console.WriteLine("Last Name = {0}", _LastName);
            Console.WriteLine("Social Security = {0}", _SSNumber);
            Console.WriteLine("Birth Date = {0}",
                _BirthDate.ToString("MM/dd/yyyy"));
            Console.WriteLine("Age = {0}", _Age);
            Console.WriteLine("AddressLine1 = {0}", _AddressLine1);
            Console.WriteLine("AddressLine2 = {0}", _AddressLine2);
            Console.WriteLine("City = {0}", _City);
            Console.WriteLine("State = {0}", _State);
            Console.WriteLine("Zip Code = {0}", _ZipCode);
            Console.WriteLine("Country = {0}", _Country);
            Console.WriteLine("Phone = {0}", _Phone);
            Console.WriteLine("Job Title = {0}", _JobTitle);
            Console.WriteLine("Email = {0}", _Email);
        }

        // PUBLIC DATA ACCESS METHODS

        public bool Load(int key)
        {
            return DALayer_Load(key);
        }

        public bool Insert()
        {
            return DALayer_Insert();
        }

        public bool Update()
        {
            return DALayer_Update();
        }

        public bool Delete(int key)
        {
            return DALayer_Delete(key);
        }

        public static List<Employee> GetAllEmployees()
        {
            return DALayer_GetAllEmployees();
        }

        // PROTECTED DATA ACCESS STUB METHODS

        protected bool DALayer_Load(int key)
        {
            return false;
        }

        protected bool DALayer_Insert()
        {
            return false;
        }

        protected bool DALayer_Update()
        {
            return false;
        }

        protected bool DALayer_Delete(int key)
        {
            return false;
        }

        protected static List<Employee> DALayer_GetAllEmployees()
        {
            return null;
        }

        // PRIVATE HELPER METHOD

        private int CalculateAge(DateTime bDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - bDate.Year;

            if (bDate.Date > today.AddYears(-age))
            {
                age = age - 1;
            }

            return age;
        }
    }
}