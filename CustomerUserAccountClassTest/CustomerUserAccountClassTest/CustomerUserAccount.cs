using System;
using System.Collections.Generic;

namespace CustomerUserAccountClassTest
{
    public class CustomerUserAccount
    {
        // PRIVATE INSTANCE DATA

        private string _UserAccountID;
        private string _Username;
        private string _Password;
        private string _Email;

        // PUBLIC PROPERTIES

        public string UserAccountID
        {
            get { return _UserAccountID; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        // PRIVATE DEFAULT CONSTRUCTOR

        private CustomerUserAccount()
        {
            _Username = "";
            _Password = "";
            _Email = "";

            _UserAccountID = "";
        }

        // PRIVATE PARAMETERIZED CONSTRUCTOR

        private CustomerUserAccount(
            string username,
            string password,
            string email)
        {
            _Username = username;
            _Password = password;
            _Email = email;

            _UserAccountID = "";
        }

        // DESTRUCTOR

        ~CustomerUserAccount()
        {
        }

        // PUBLIC STATIC FACTORY METHODS

        public static CustomerUserAccount GetInstance()
        {
            CustomerUserAccount objAccount =
                new CustomerUserAccount();

            return objAccount;
        }

        public static CustomerUserAccount GetInstance(
            string username,
            string password,
            string email)
        {
            CustomerUserAccount objAccount =
                new CustomerUserAccount(
                    username, password, email);

            return objAccount;
        }

        // PUBLIC INSTANCE METHODS

        public bool Authenticate(
            string username,
            string password)
        {
            if (_Username == username &&
                _Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // PUBLIC DATA ACCESS METHODS

        public bool Load(string key)
        {
            return DALayer_Load(key);
        }

        public bool LoadByUsername(string username)
        {
            return DALayer_LoadByUsername(username);
        }

        public bool Insert()
        {
            return DALayer_Insert();
        }

        public bool Update()
        {
            return DALayer_Update();
        }

        public bool Delete(string key)
        {
            return DALayer_Delete(key);
        }

        public bool DeleteByUsername(string username)
        {
            return DALayer_DeleteByUsername(username);
        }

        public static List<CustomerUserAccount>
            GetAllCustomerUserAccounts()
        {
            return DALayer_GetAllCustomerUserAccounts();
        }

        // PROTECTED DATA ACCESS STUB METHODS

        protected bool DALayer_Load(string key)
        {
            return false;
        }

        protected bool DALayer_LoadByUsername(string username)
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

        protected bool DALayer_Delete(string key)
        {
            return false;
        }

        protected bool DALayer_DeleteByUsername(string username)
        {
            return false;
        }

        protected static List<CustomerUserAccount>
            DALayer_GetAllCustomerUserAccounts()
        {
            return null;
        }
    }
}