using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //void PrintOptions()
            //{
            //    Console.WriteLine("please choose your Option");
            //    Console.WriteLine("1. Deposit");
            //    Console.WriteLine("2. withdraw");
            //    Console.WriteLine("3. Balance Enquiry");
            //    Console.WriteLine("4. Exit");
            //}
            //void Deposit(CardHolder currentUser)
            //{ 
            //    Console.WriteLine("How much ₹ would you like to deposit? ");
            //    double deposit = Double.Parse(Console.ReadLine());
            //    currentUser.SetBalance(currentUser.GetBalance() + deposit);
            //    Console.WriteLine("Thank you. Your New Blanace is: " + currentUser.GetBalance());
            //}

            //void Withdraw(CardHolder currentUser)
            //{
            //    Console.WriteLine("how much ₹ would you like to Withdraw: ");
            //    double withdrawal = Double.Parse(Console.ReadLine());
            //    // checking for user has enough money
            //    if (currentUser.GetBalance() < withdrawal)
            //    {
            //        Console.WriteLine("insufficient Balance");
            //    }
            //    else
            //    {
            //        currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
            //        Console.WriteLine("Thnak you for your Transaction..\nHave a good Day");
            //    }
            //}

            //void Balance(CardHolder currentUser)
            //{
            //    Console.WriteLine("Current Balance: " + currentUser.GetBalance());
            //}


            List<CardHolder> CardHolders = new List<CardHolder>();
            CardHolders.Add(new CardHolder("2346543897065438", 3452, "Ram", "Surj", 567489));
            CardHolders.Add(new CardHolder("3467889065476432", 5678, "Aman", "Mohmed", 7654390));
            CardHolders.Add(new CardHolder("4509876543245890", 6709, "Sona", "Sin", 348876));
            CardHolders.Add(new CardHolder("2345612980765486", 4502, "Sharmila", "sun", 54389));
            CardHolders.Add(new CardHolder("1289765432098765", 6589, "Binoy", "Roy", 5678320));

            Console.WriteLine("Welcome to ATM");
            Console.WriteLine("Please insert your Depit Card");
            string debitCardNumber = "";
            CardHolder currentUser;
            while (true)
            {
                try
                {
                    debitCardNumber = Console.ReadLine();
                    currentUser = CardHolders.FirstOrDefault(a => a.cardNumber == debitCardNumber);
                    if (currentUser != null)
                        break;
                    else { Console.WriteLine("card can't recognized. \nPlease Try again."); }
                }
                catch
                {
                    Console.WriteLine("card can't recognized. \nPlease Try again.");
                }

            }
            Console.WriteLine("Please Enter your PIN: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.GetPin() == userPin)
                        break;
                    else { Console.WriteLine("Incorrect PIN. \nPlease Try again."); }
                }
                catch
                {
                    Console.WriteLine("Incorrect PIN. \nPlease Try again.");
                }
            }

            Console.WriteLine("Welcome" + currentUser.GetFirstName() + currentUser.GetLastName());
            int option = 0;
            do
            {
                currentUser.PrintOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
                if (option == 1)
                    currentUser.Deposit(currentUser);
                else if (option == 2)
                    currentUser.Withdraw(currentUser);
                else if (option == 3)
                    currentUser.Balance(currentUser);
                else if (option == 4)
                    break;
                else { option = 0; }
            }
            while (option != 4);
            Console.WriteLine("Thank You..!Have a nice Day");

        }
    }
}
