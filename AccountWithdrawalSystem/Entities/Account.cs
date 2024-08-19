using AccountWithdrawalSystem.Entities.Exceptions;

namespace AccountWithdrawalSystem.Entities
{
    internal class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(Double amount)
        {
            Balance += amount;
        }

        public void Withdraw(Double amount)
        {
            if (amount > WithdrawLimit)
                throw new WithdrawException("The amount exceeds withdraw limit");
            if (Balance < amount)
                throw new NotEnoughBalanceException("Not enough balance");

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {Number} | Holder: {Holder} | Withdraw Limit ${WithdrawLimit:f2} | Balance ${Balance:f2} ";
        }

    }
}
