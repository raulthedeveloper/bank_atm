using System;
namespace Bank_Atm
{
    public class Auth
    {
        private readonly int AccountNumber;
        private readonly int PinNumber;

        public Auth(int pinNumber, int accountNumber)
        {
            AccountNumber = accountNumber;
            PinNumber = pinNumber;
        }

        public bool CheckCredentials()
        {
            // Query database and compares it to input values

            Console.WriteLine("--------- Checking Creditials ----------");
            Console.WriteLine("Your Pin Number is " + PinNumber + "\nYour Account Number is " + AccountNumber);
            // Checks if account number and pin is correct

            if (AccountNumber == 1234 && PinNumber == 4444)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }
    }
}
