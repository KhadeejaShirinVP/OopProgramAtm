using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHolder
    {
        // data fields
       
        public string cardNumber;
        int pin;
        string firstName;
        string lastName;
        double balance;

        //constructor
        public CardHolder(string cardNumber, int pin, string firstName, string lastName, double balance)
        {
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        //properties
        public string GetNum()
        {
            return cardNumber;
        }
        public int GetPin()
        {
            return pin;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public double GetBalance()
        {
            return balance;
        }


        public void SetNum(string newCardNumber)
        {
            cardNumber = newCardNumber;
        }

        public void SetPin(int newPin)
        {
            pin = newPin;
        }

        public void SetFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void SetLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void SetBalance(double newBalance)
        {
            balance = newBalance;
        }

        public void PrintOptions()
        {
            Console.WriteLine("please choose your Option");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. withdraw");
            Console.WriteLine("3. Balance Enquiry");
            Console.WriteLine("4. Exit");
        }
        public void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much ₹ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.SetBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine("Thank you. Your New Blanace is: " + currentUser.GetBalance());
        }

        public void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("how much ₹ would you like to Withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            // checking for user has enough money
            if (currentUser.GetBalance() < withdrawal)
            {
                Console.WriteLine("insufficient Balance");
            }
            else
            {
                currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
                Console.WriteLine("Thnak you for your Transaction..\nHave a good Day");
            }
        }

        public void Balance(CardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.GetBalance());
        }

    }
}

