namespace ATMApp.Services
{
    public static class BankingServices
    {
        // Option 1: Pass-by-value
        public static double GetBalance(double balance)
        {
            return balance;
        }

        // Option 2: ref (Deposit)
        public static bool Deposit(ref double balance, double amount)
        {
            return false; //placeholder return value, replace with actual implementation
        }

        // Option 3: ref + out (Withdraw)
        public static void Withdraw(
            ref double balance,
            double amount,
            out bool isSuccessful)
        {
            isSuccessful = false; //placeholder value, replace with actual implementation
        }
    }
}
