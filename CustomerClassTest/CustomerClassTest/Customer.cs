using System;
using System.Collections.Generic;

namespace CustomerClassTest
{
    public class Customer
    {
        // PRIVATE INSTANCE DATA

        private int _CustomerID;
        private string _FirstName;
        private string _LastName;
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
        private string _DriverLicenseNumber;
        private DateTime _DriverLicenseExpDate;
        private string _DriverLicenseState;
        private char _CustomerType;

        // PUBLIC PROPERTIES

        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
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

        public string DriverLicenseNumber
        {
            get { return _DriverLicenseNumber; }
            set { _DriverLicenseNumber = value; }
        }

        public DateTime DriverLicenseExpDate
        {
            get { return _DriverLicenseExpDate; }
            set { _DriverLicenseExpDate = value; }
        }

        public string DriverLicenseState
        {
            get { return _DriverLicenseState; }
            set { _DriverLicenseState = value; }
        }

        // R = Retail, C = Corporate

        public char CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }

        // DEFAULT CONSTRUCTOR

        public Customer()
        {
            _CustomerID = 0;
            _FirstName = "";
            _LastName = "";
            _BirthDate = new DateTime().Date;
            _Age = 0;
            _AddressLine1 = "";
            _AddressLine2 = "";
            _City = "";
            _State = "";
            _ZipCode = "";
            _Country = "";
            _Phone = "";
            _Email = "";
            _DriverLicenseNumber = "";
            _DriverLicenseExpDate = new DateTime().Date;
            _DriverLicenseState = "";
            _CustomerType = '\0';
        }

        // PARAMETERIZED CONSTRUCTOR

        public Customer(
            string fN, string lN, string bD,
            string add1, string add2,
            string c, string s, string z,
            string co, string p, string e,
            string dLN, DateTime dLE, string dLS)
        {
            _FirstName = _LastName =
            _AddressLine1 = _AddressLine2 =
            _City = _State = _ZipCode =
            _Country = _Phone = _Email =
            _DriverLicenseNumber =
            _DriverLicenseState = "";

            FirstName = fN;
            LastName = lN;
            BirthDate = DateTime.Parse(bD);
            AddressLine1 = add1;
            AddressLine2 = add2;
            City = c;
            State = s;
            ZipCode = z;
            Country = co;
            Phone = p;
            Email = e;
            DriverLicenseNumber = dLN;
            DriverLicenseExpDate = dLE;
            DriverLicenseState = dLS;

            _CustomerID = 0;
            _CustomerType = '\0';
        }

        // DESTRUCTOR

        ~Customer()
        {
        }

        // PUBLIC INSTANCE METHODS

        public void Print()
        {
            Console.WriteLine("Customer information:");
            Console.WriteLine("First Name = {0}", _FirstName);
            Console.WriteLine("Last Name = {0}", _LastName);
            Console.WriteLine("Date of Birth = {0}",
                _BirthDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("Age = {0}", _Age);
            Console.WriteLine("AddressLine1 = {0}", _AddressLine1);
            Console.WriteLine("AddressLine2 = {0}", _AddressLine2);
            Console.WriteLine("City = {0}", _City);
            Console.WriteLine("State = {0}", _State);
            Console.WriteLine("Zip Code = {0}", _ZipCode);
            Console.WriteLine("Country = {0}", _Country);
            Console.WriteLine("Phone = {0}", _Phone);
            Console.WriteLine("Email = {0}", _Email);

            Console.WriteLine("Driver License Number = {0}",
                _DriverLicenseNumber);

            Console.WriteLine("Driver License Exp Date = {0}",
                _DriverLicenseExpDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("Driver License State = {0}",
                _DriverLicenseState);

            Console.WriteLine("Customer Type = {0}", _CustomerType);
        }

        // PUBLIC DATA ACCESS METHODS

        public bool Load(int key)
        {
            return DALayer_Load(key);
        }

        public bool LoadByDriverLicenseNumber(string licenseNum)
        {
            return DALayer_LoadByDriverLicenseNumber(licenseNum);
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

        public bool DeleteByDriverLicenseNumber(string licenseNum)
        {
            return DALayer_DeleteByDriverLicenseNumber(licenseNum);
        }

        public static List<Customer> GetAllCustomers()
        {
            return DALayer_GetAllCustomers();
        }

        // PROTECTED DATA ACCESS STUB METHODS

        protected bool DALayer_Load(int key)
        {
            return false;
        }

        protected bool DALayer_LoadByDriverLicenseNumber(
            string licenseNum)
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

        protected bool DALayer_DeleteByDriverLicenseNumber(
            string licenseNum)
        {
            return false;
        }

        protected static List<Customer> DALayer_GetAllCustomers()
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