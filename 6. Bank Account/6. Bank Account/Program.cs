using System;

namespace _6._Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create accounts
            Account account1 = new Account("Ted Murphy", 72354, 102.56);
            Account account2 = new Account("Jane Smith", 69713, 40.00);
            Account account3 = new Account("Edward Demsey", 93757, 750.32);

            // Step 2: Deposit
            account1.Deposit(25.85);
            account2.Deposit(500.00);

            // Step 3: WithDraw
            account2.WithDraw(430.75, 1.50);

            // Step 4: Interest
            account3.AddInterest();

            // Step 5: Print the information 
            Console.WriteLine("|Account Number|User's Name         |    Balance   |");
            account1.InformationToString();
            account2.InformationToString();
            account3.InformationToString();
            Console.WriteLine("----------------------------------------------------");

            // Step 6: Transfer
            account1.Transfer(account2, 100.00);

            // Step 7: Print again
            Console.WriteLine("|Account Number|User's Name         |    Balance   |");
            account1.InformationToString();
            account2.InformationToString();

        }
    }
}
