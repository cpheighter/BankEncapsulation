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

        public void Deposit(double amount)
        {
             balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
        public double GetBalance()
        {
            return balance;
        }
        /*public static void Receipt(double balance)
        {
            Console.WriteLine("Would you like a receipt? Yes or No?");
            var answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Console.Write($"Your new balance is: {balance}");
              
                Console.WriteLine("Would you like to do anything else?");
            }
            else
            {
                Console.WriteLine("Would you like to do anything else?");
            }
        }*/
    }
}
