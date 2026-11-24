using System;
using System.Collections.Generic;

namespace CreditCardClassTest
{
    public class CreditCard
    {
        // PRIVATE INSTANCE DATA

        private string _CreditCardNumber;
        private string _CreditCardOwnerName;

        private byte _CreditCardProcessingMerchantServiceCompanyCode;
        private string _CreditCardProcessingMerchantServiceCompanyName;

        private byte _CreditCardNetworkCompanyCode;
        private string _CreditCardNetworkCompanyName;

        private byte _CreditCardIssuingBankCode;
        private string _CreditCardIssuingBankName;

        private byte _CreditCardCorporateMerchantBankCode;
        private string _CreditCardCorporateMerchantBankName;

        private DateTime _ExpDate;
        private string _AddressLine1;
        private string _AddressLine2;
        private string _City;
        private string _StateCode;
        private string _ZipCode;
        private string _Country;

        private decimal _CreditCardLimit;
        private decimal _CreditCardAvailableCredit;
        private bool _CreditCardActivationStatus;

        // PUBLIC PROPERTIES

        public string CreditCardNumber
        {
            get { return _CreditCardNumber; }
            set { _CreditCardNumber = value; }
        }

        public string CreditCardOwnerName
        {
            get { return _CreditCardOwnerName; }
            set { _CreditCardOwnerName = value; }
        }

        public byte CreditCardProcessingMerchantServiceCompanyCode
        {
            get { return _CreditCardProcessingMerchantServiceCompanyCode; }
            set { _CreditCardProcessingMerchantServiceCompanyCode = value; }
        }

        public string CreditCardProcessingMerchantServiceCompanyName
        {
            get { return _CreditCardProcessingMerchantServiceCompanyName; }
            set { _CreditCardProcessingMerchantServiceCompanyName = value; }
        }

        public byte CreditCardNetworkCompanyCode
        {
            get { return _CreditCardNetworkCompanyCode; }
            set { _CreditCardNetworkCompanyCode = value; }
        }

        public string CreditCardNetworkCompanyName
        {
            get { return _CreditCardNetworkCompanyName; }
            set { _CreditCardNetworkCompanyName = value; }
        }

        public byte CreditCardIssuingBankCode
        {
            get { return _CreditCardIssuingBankCode; }
            set { _CreditCardIssuingBankCode = value; }
        }

        public string CreditCardIssuingBankName
        {
            get { return _CreditCardIssuingBankName; }
            set { _CreditCardIssuingBankName = value; }
        }

        public byte CreditCardCorporateMerchantBankCode
        {
            get { return _CreditCardCorporateMerchantBankCode; }
            set { _CreditCardCorporateMerchantBankCode = value; }
        }

        public string CreditCardCorporateMerchantBankName
        {
            get { return _CreditCardCorporateMerchantBankName; }
            set { _CreditCardCorporateMerchantBankName = value; }
        }

        public DateTime ExpDate
        {
            get { return _ExpDate; }
            set { _ExpDate = value; }
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

        public string StateCode
        {
            get { return _StateCode; }
            set { _StateCode = value; }
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

        public decimal CreditCardLimit
        {
            get { return _CreditCardLimit; }
            set { _CreditCardLimit = value; }
        }

        public decimal CreditCardAvailableCredit
        {
            get { return _CreditCardAvailableCredit; }
            set { _CreditCardAvailableCredit = value; }
        }

        // READ-ONLY PROPERTY

        public bool CreditCardActivationStatus
        {
            get { return _CreditCardActivationStatus; }
        }

        // DEFAULT CONSTRUCTOR

        public CreditCard()
        {
            _CreditCardNumber = "";
            _CreditCardOwnerName = "";

            _CreditCardProcessingMerchantServiceCompanyCode = 0;
            _CreditCardProcessingMerchantServiceCompanyName = "";

            _CreditCardNetworkCompanyCode = 0;
            _CreditCardNetworkCompanyName = "";

            _CreditCardIssuingBankCode = 0;
            _CreditCardIssuingBankName = "";

            _CreditCardCorporateMerchantBankCode = 0;
            _CreditCardCorporateMerchantBankName = "";

            _ExpDate = new DateTime().Date;

            _AddressLine1 = "";
            _AddressLine2 = "";
            _City = "";
            _StateCode = "";
            _ZipCode = "";
            _Country = "";

            _CreditCardLimit = 3000.0M;
            _CreditCardAvailableCredit = 3000.0M;

            _CreditCardActivationStatus = true;
        }

        // PARAMETERIZED CONSTRUCTOR

        public CreditCard(
            string cCN,
            string cCON,
            byte cCPMSCC,
            byte cCNCC,
            byte cCIBC,
            byte cCCMBC,
            string expD,
            string add1,
            string add2,
            string c,
            string s,
            string z,
            string co,
            decimal cCL = 3000.0M,
            decimal cCAC = 3000.0M) : this()
        {
            CreditCardNumber = cCN;
            CreditCardOwnerName = cCON;

            CreditCardProcessingMerchantServiceCompanyCode = cCPMSCC;
            CreditCardNetworkCompanyCode = cCNCC;
            CreditCardIssuingBankCode = cCIBC;
            CreditCardCorporateMerchantBankCode = cCCMBC;

            ExpDate = DateTime.Parse(expD);

            AddressLine1 = add1;
            AddressLine2 = add2;
            City = c;
            StateCode = s;
            ZipCode = z;
            Country = co;

            CreditCardLimit = cCL;
            CreditCardAvailableCredit = cCAC;
        }

        // DESTRUCTOR

        ~CreditCard()
        {
        }

        // PUBLIC INSTANCE METHODS

        public void Print()
        {
            Console.WriteLine("Credit Card information:");

            Console.WriteLine("Credit Card Number = {0}",
                _CreditCardNumber);

            Console.WriteLine("Credit Card Owner Name = {0}",
                _CreditCardOwnerName);

            Console.WriteLine("Credit Card Processing Merchant Service Company Code = {0}",
                _CreditCardProcessingMerchantServiceCompanyCode);

            Console.WriteLine("Credit Card Processing Merchant Service Company Name = {0}",
                _CreditCardProcessingMerchantServiceCompanyName);

            Console.WriteLine("Credit Card Network Company Code = {0}",
                _CreditCardNetworkCompanyCode);

            Console.WriteLine("Credit Card Network Company Name = {0}",
                _CreditCardNetworkCompanyName);

            Console.WriteLine("Credit Card Issuing Bank Code = {0}",
                _CreditCardIssuingBankCode);

            Console.WriteLine("Credit Card Issuing Bank Name = {0}",
                _CreditCardIssuingBankName);

            Console.WriteLine("Credit Card Corporate Merchant Bank Code = {0}",
                _CreditCardCorporateMerchantBankCode);

            Console.WriteLine("Credit Card Corporate Merchant Bank Name = {0}",
                _CreditCardCorporateMerchantBankName);

            Console.WriteLine("Expiration Date = {0}",
                _ExpDate.ToString("M/d/yyyy"));

            Console.WriteLine("AddressLine1 = {0}", _AddressLine1);
            Console.WriteLine("AddressLine2 = {0}", _AddressLine2);
            Console.WriteLine("City = {0}", _City);
            Console.WriteLine("State Code = {0}", _StateCode);
            Console.WriteLine("Zip Code = {0}", _ZipCode);
            Console.WriteLine("Country = {0}", _Country);

            Console.WriteLine("Credit Card Limit = {0}",
                _CreditCardLimit);

            Console.WriteLine("Credit Card Available Credit = {0}",
                _CreditCardAvailableCredit);

            Console.WriteLine("Credit Card Activation Status = {0}",
                _CreditCardActivationStatus);
        }

        public bool Activate()
        {
            _CreditCardActivationStatus = true;
            return _CreditCardActivationStatus;
        }

        public bool Deactivate()
        {
            _CreditCardActivationStatus = false;
            return _CreditCardActivationStatus;
        }

        // PUBLIC DATA ACCESS METHODS

        public bool Load(string key)
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

        public bool Delete(string key)
        {
            return DALayer_Delete(key);
        }

        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();
        }

        // PROTECTED DATA ACCESS STUB METHODS

        protected bool DALayer_Load(string key)
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

        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            return null;
        }
    }
}