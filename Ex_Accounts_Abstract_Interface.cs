using System;

namespace Ex_Accounts_Abstract_Interface
{
    public interface IAccount
    {
        string HolderName { get; }
        double Balance { get; }
        double CalculateInterest();
    }

    // Abstract class holds shared state/constructor (not possible in pure interface in old style)
    public abstract class BaseAccount : IAccount
    {
        public string HolderName { get; protected set; }
        public double Balance { get; protected set; }

        protected BaseAccount(string holderName, double balance)
        {
            HolderName = holderName;
            Balance = balance;
        }

        public abstract double CalculateInterest();
    }

    public class SavingsAccount : BaseAccount
    {
        public SavingsAccount(string holderName, double balance) : base(holderName, balance) { }
        public override double CalculateInterest() => Balance * 0.05;
    }

    public class CurrentAccount : BaseAccount
    {
        public CurrentAccount(string holderName, double balance) : base(holderName, balance) { }
        public override double CalculateInterest() => Balance * 0.02;
    }

    class Program
    {
        static void Main()
        {
            IAccount a1 = new SavingsAccount("Omar", 1000);
            IAccount a2 = new CurrentAccount("Lina", 2000);

            Console.WriteLine($"{a1.HolderName} interest = {a1.CalculateInterest()}");
            Console.WriteLine($"{a2.HolderName} interest = {a2.CalculateInterest()}");

            Console.ReadKey();
        }
    }
}

/*
SOLID Links:
- OCP: Add new account types without changing Program.
- LSP: Any account must correctly fulfill the IAccount contract.
- SRP hint: interest calculation belongs to account type; formatting/output can be separated later.
*/
