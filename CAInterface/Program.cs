using System;

namespace CAInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier c1 = new Cashier(new Cash());
            c1.Checkout(99999.99m);

            Cashier c2 = new Cashier(new Mastercard());
            c2.Checkout(99999.99m);

            Cashier c3= new Cashier(new AmericanExpress());
            c3.Checkout(99999.99m);
            Console.ReadKey();
        }
    }
    public class AmericanExpress: IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"AmericanExpress Payment: ${Math.Round(amount, 2):N0}"); //$99,999.99
        }
    }
    class Cashier
    {
        private IPayment _payment; 

        public Cashier(IPayment payment)
        {
            _payment = payment;
        }

        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
  
    interface IPayment
    {
        void Pay(decimal amount);
    }
   class Cash: IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment: ${Math.Round(amount, 2):N0}"); //$99,999.99
        }
   }

    class Debit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Payment: ${Math.Round(amount, 2):N0}"); //$99,999.99
        }
    }

    class Visa : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa Payment: ${Math.Round(amount, 2):N0}"); //$99,999.99
        }
    }

    class Mastercard : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Mastercard Payment: ${Math.Round(amount, 2):N0}"); //$99,999.99
        }
    }
}
