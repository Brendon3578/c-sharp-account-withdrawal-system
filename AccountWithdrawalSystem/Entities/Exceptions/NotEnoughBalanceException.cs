namespace AccountWithdrawalSystem.Entities.Exceptions
{
    internal class NotEnoughBalanceException : WithdrawException
    {
        public NotEnoughBalanceException(string message) : base(message) { }
    }
}
