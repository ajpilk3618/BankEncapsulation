using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;


        public void Withdraw()
        {
            Console.Write("Please enter amount to be withdrawn: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Current Balance: ");
            Console.WriteLine(balance -= amount);
        }

        public void Deposit()
        {
            Console.Write("Please enter amount to be deposited: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Current Balance: ");
            Console.WriteLine(balance += amount);
        }

        public void GetBalance()
        {
            Console.Write("Current Balance: ");
            Console.WriteLine(balance);
        }

        public void SignOut()
        {
            Console.WriteLine("Good Bye!");
        }

    }
}
