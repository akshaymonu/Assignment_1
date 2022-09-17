using System;

namespace Assignment_5
{
    abstract class Account
    {
        
        public double Balance { get;  set; } 
        public void Credit(double amount) => Balance += amount;

        public void Debit(double amount)
        {
            if (Balance < amount)
            {
                throw new Exception("Insufficient funds!!!");
            }
            Balance -= amount;
        }

        public abstract void CalculateInterest();

    }

    class SBAccount : Account
    {
        
        public override void CalculateInterest()//override for implementing abstract methods...
        {
            double principle = Balance;

            double rate = 0.065;
            Console.WriteLine("Enter the principle amount", principle);
            principle = int.Parse(Console.ReadLine());
            double term = 1;
            var interest = principle * rate * term;
            Credit(interest);
        }
    }
    class AbstractClassExample
    {
        static void Main(string[] args)
        {
            Account acc = new SBAccount();
            
            acc.CalculateInterest();
            Console.WriteLine("The Current balance: " + acc.Balance);
        }
    }
}
