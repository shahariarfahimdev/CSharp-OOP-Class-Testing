using System;
using System.Collections.Generic;

namespace CreditCardClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEST 1 - DEFAULT CONSTRUCTOR

            Console.WriteLine("TEST #1 - Default Constructor");

            CreditCard objCard1 = new CreditCard();

            objCard1.Print();

            Console.WriteLine("--------------------------------");

            // TEST 2A - PARAMETERIZED CONSTRUCTOR
            // WITHOUT OPTIONAL PARAMETERS

            Console.WriteLine("TEST #2a - Parameterized Constructor");
            Console.WriteLine("Without optional parameters");

            CreditCard objCard2 = new CreditCard(
                "4111111111111111",
                "Joe Smith",
                1, 2, 3, 4,
                "12/31/2028",
                "100 Main Street",
                "Apt 20",
                "Brooklyn",
                "NY",
                "11201",
                "USA"
            );

            objCard2.Print();

            Console.WriteLine("--------------------------------");

            // TEST 2B - PARAMETERIZED CONSTRUCTOR
            // WITH OPTIONAL PARAMETERS

            Console.WriteLine("TEST #2b - Parameterized Constructor");
            Console.WriteLine("With optional parameters");

            CreditCard objCard3 = new CreditCard(
                "5500000000000004",
                "Mary Jones",
                5, 6, 7, 8,
                "06/30/2029",
                "200 Jay Street",
                "Suite 5",
                "New York",
                "NY",
                "10001",
                "USA",
                10000.00M,
                7500.00M
            );

            objCard3.Print();

            Console.WriteLine("--------------------------------");

            // TEST 3 - INSTANCE PROPERTIES

            Console.WriteLine("TEST #3 - Instance Properties");

            objCard1.CreditCardNumber = "378282246310005";
            objCard1.CreditCardOwnerName = "Ann Lee";

            objCard1.CreditCardProcessingMerchantServiceCompanyCode = 10;
            objCard1.CreditCardProcessingMerchantServiceCompanyName = "Square";

            objCard1.CreditCardNetworkCompanyCode = 20;
            objCard1.CreditCardNetworkCompanyName = "Visa";

            objCard1.CreditCardIssuingBankCode = 30;
            objCard1.CreditCardIssuingBankName = "Chase";

            objCard1.CreditCardCorporateMerchantBankCode = 40;
            objCard1.CreditCardCorporateMerchantBankName = "Citibank";

            objCard1.ExpDate = DateTime.Parse("01/31/2030");

            objCard1.AddressLine1 = "300 Broadway";
            objCard1.AddressLine2 = "Floor 3";
            objCard1.City = "Queens";
            objCard1.StateCode = "NY";
            objCard1.ZipCode = "11101";
            objCard1.Country = "USA";

            objCard1.CreditCardLimit = 5000.00M;
            objCard1.CreditCardAvailableCredit = 4250.50M;

            Console.WriteLine("CreditCardNumber = {0}",
                objCard1.CreditCardNumber);

            Console.WriteLine("CreditCardOwnerName = {0}",
                objCard1.CreditCardOwnerName);

            Console.WriteLine("ProcessingMerchantCompanyCode = {0}",
                objCard1.CreditCardProcessingMerchantServiceCompanyCode);

            Console.WriteLine("ProcessingMerchantCompanyName = {0}",
                objCard1.CreditCardProcessingMerchantServiceCompanyName);

            Console.WriteLine("NetworkCompanyCode = {0}",
                objCard1.CreditCardNetworkCompanyCode);

            Console.WriteLine("NetworkCompanyName = {0}",
                objCard1.CreditCardNetworkCompanyName);

            Console.WriteLine("IssuingBankCode = {0}",
                objCard1.CreditCardIssuingBankCode);

            Console.WriteLine("IssuingBankName = {0}",
                objCard1.CreditCardIssuingBankName);

            Console.WriteLine("CorporateMerchantBankCode = {0}",
                objCard1.CreditCardCorporateMerchantBankCode);

            Console.WriteLine("CorporateMerchantBankName = {0}",
                objCard1.CreditCardCorporateMerchantBankName);

            Console.WriteLine("ExpDate = {0}",
                objCard1.ExpDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("AddressLine1 = {0}", objCard1.AddressLine1);
            Console.WriteLine("AddressLine2 = {0}", objCard1.AddressLine2);
            Console.WriteLine("City = {0}", objCard1.City);
            Console.WriteLine("StateCode = {0}", objCard1.StateCode);
            Console.WriteLine("ZipCode = {0}", objCard1.ZipCode);
            Console.WriteLine("Country = {0}", objCard1.Country);

            Console.WriteLine("CreditCardLimit = {0}",
                objCard1.CreditCardLimit);

            Console.WriteLine("CreditCardAvailableCredit = {0}",
                objCard1.CreditCardAvailableCredit);

            Console.WriteLine("CreditCardActivationStatus = {0}",
                objCard1.CreditCardActivationStatus);

            Console.WriteLine("--------------------------------");

            // TEST 4 - ACTIVATE AND DEACTIVATE

            Console.WriteLine("TEST #4 - Activate and Deactivate");

            Console.WriteLine("Status before Deactivate = {0}",
                objCard1.CreditCardActivationStatus);

            Console.WriteLine("Deactivate returned = {0}",
                objCard1.Deactivate());

            Console.WriteLine("Status after Deactivate = {0}",
                objCard1.CreditCardActivationStatus);

            Console.WriteLine("Activate returned = {0}",
                objCard1.Activate());

            Console.WriteLine("Status after Activate = {0}",
                objCard1.CreditCardActivationStatus);

            Console.WriteLine("--------------------------------");

            // TEST 5 - PRINT METHOD

            Console.WriteLine("TEST #5 - Print Method");

            objCard1.Print();

            Console.WriteLine("--------------------------------");

            // TEST 6 - DATA ACCESS METHODS

            Console.WriteLine("TEST #6 - Data Access Methods");

            Console.WriteLine("Load returned: {0}",
                objCard1.Load(objCard1.CreditCardNumber));

            Console.WriteLine("Insert returned: {0}",
                objCard1.Insert());

            Console.WriteLine("Update returned: {0}",
                objCard1.Update());

            Console.WriteLine("Delete returned: {0}",
                objCard1.Delete(objCard1.CreditCardNumber));

            Console.WriteLine("--------------------------------");

            // TEST 7 - GET ALL CREDIT CARDS

            Console.WriteLine("TEST #7 - GetAllCreditCards");

            List<CreditCard> cardList =
                CreditCard.GetAllCreditCards();

            if (cardList == null)
            {
                Console.WriteLine("GetAllCreditCards returned NULL");
            }
            else
            {
                Console.WriteLine("Records returned: {0}",
                    cardList.Count);
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("ALL TESTS COMPLETED");
        }
    }
}