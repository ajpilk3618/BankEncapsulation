using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class UserInterface : BankAccount
    {
        public void Start()
        {

            bool loggedIn = true;

            while (loggedIn)
            {
                BankAccount account = new BankAccount();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("A: Withdraw");
                Console.WriteLine("B: Deposit");
                Console.WriteLine("C: Check Balance");
                Console.WriteLine("D: Sign Out");
                var userResponse = Console.ReadLine();

                switch (userResponse)
                {
                    case "A":
                        //Withdraw
                        {
                            Withdraw();
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "B":
                        //Deposit
                        {
                            Deposit();
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "C":
                        //Check Balance
                        {
                            GetBalance();
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "D":
                        //Sign Out
                        {
                            SignOut();
                            loggedIn = false;
                            break;
                        }
                }
            }
        }
    }
}

