/** Name: Lynsy Marie R. Soronio
*
* ===Simple ATM System===
*/

namespace ATMApp.Services
{
    public static class BankingServices
    {
        private static double balance = 1000.00;
        private static double lastTransactionAmount = 0;

        // Option 1: Pass-by-value - Get Balance
        public static double GetBalance()
        {
            return balance; // Return the current balance
        }

        // Option 2: ref - (Deposit)
        public static bool Deposit(ref double balance, double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            balance += amount; 
            lastTransactionAmount = amount; 
            return true; 
        }

        // Option 3: ref + out - (Withdraw)
        public static void Withdraw(ref double balance, double amount, out bool isSuccessful)
        {
            isSuccessful = false;

            if (amount <= 0)
            {
                return; // Exit the method if invalid amount
            }

            if (balance >= amount)
            {
                
                balance -= amount; 
                lastTransactionAmount = -amount;
                isSuccessful = true;
            }
            else
            {
                isSuccessful = false; 
            }
        }

        // Option 4: Pass-by-value - Print Mini Statement
        public static (double, double) GetMiniStatement()
        {
            return (balance, lastTransactionAmount);
        }
    }
}
