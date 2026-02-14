using ATMApp.Services;

namespace ATMApp.View
{
    public static class BankingView
    {
        public static void Run()
        {
            Console.WriteLine("=== Simple ATM System ===");
            Console.WriteLine("1: Check Balance");
            Console.WriteLine("2: Deposit Money");
            Console.WriteLine("3: Withdraw Money");
            Console.WriteLine("4: Print Mini Statement");
            Console.WriteLine("5: Exit");
        }

        public static double GetAmountInput(string action)
        {
            double amount;
            Console.WriteLine($"Enter amount to {action}:");
            while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
            }
            return amount; 
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowBalance(double balance)
        {
            Console.WriteLine($"Current Balance: ₱{balance:F2}");
        }

        public static void PrintMiniStatement(double balance, double lastTransactionAmount)
        {
            Console.WriteLine("--- Mini Statement ---");
            Console.WriteLine($"Current Balance: ₱{balance:F2}");
            Console.WriteLine($"Last Transaction Amount: ₱{lastTransactionAmount:F2}");
        }

        public static void ShowTransactionResult(bool isSuccessful, string action)
        {
            if (isSuccessful)
            {
                Console.WriteLine($"{action} successful.");
            }
            else
            {
                Console.WriteLine($"{action} failed. Please try again.");
            }
        }
    }
}
