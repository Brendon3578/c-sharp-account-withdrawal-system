using AccountWithdrawalSystem.Entities;
using AccountWithdrawalSystem.Entities.Exceptions;
using System.Globalization;

namespace AccountWithdrawalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data:");

            Console.Write("Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(accountNumber, holder, initialBalance, withdrawLimit)s

            Console.Write("How many withdrawals do you want to make? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"\n---- Withdraw [{i + 1}] ----");
                Console.Write("Enter amount for withdraw: ");
                var amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                TryToWithdrawFromAccount(account, amount);
            }

            Console.WriteLine("\n-=-=[ Final Balance ]=-=-");
            Console.WriteLine(account);
            Console.WriteLine("-------------------------");
        }

        static void TryToWithdrawFromAccount(Account account, double value)
        {
            Console.WriteLine($"Value before exchange: {account.Balance:f2}");
            try
            {
                account.Withdraw(value);
            }
            catch (NotEnoughBalanceException e)
            {
                Console.WriteLine($"Balance error: {e.Message}");
            }
            catch (WithdrawException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unknown error: {e.Message}");
            }
            finally
            {
                Console.WriteLine($"Value after exchange: {account.Balance:f2}");

            }
        }
    }
}
