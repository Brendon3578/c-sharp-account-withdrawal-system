namespace AccountWithdrawalSystem.Entities.Exceptions
{
    internal class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message) { }
    }
}
