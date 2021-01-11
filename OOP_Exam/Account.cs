using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    abstract class Account
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public decimal Balance { get; set; }
        public DateTime InterestDate { get; set; }

        abstract public decimal CalculateInterest();

        public decimal Deposit()
        {
            throw new NotImplementedException();
        }

        public decimal WithDraw()
        {
            throw new NotImplementedException();
        }
    }


    /******************** Current Acoount *************************/
    class CurrentAccount : Account
    {
        public decimal InterestRate = 0.03m;

        public CurrentAccount(string firstname, string surname, decimal balance)
        {
            FirstName = firstname;
            SurName = surname;
            Balance = balance;

        }

        public override decimal CalculateInterest()
        {
            decimal interest = 0;
            interest = Balance * InterestRate;
            return interest;
            InterestDate = DateTime.Now;
        }
    }







    /******************** Savings Acoount *************************/
    class SavingsAccount : Account
    {
        public decimal InterestRate = 0.06m;

        public SavingsAccount(string firstname, string surname, decimal balance)
        {
            FirstName = firstname;
            SurName = surname;
            Balance = balance;

        }

        public override decimal CalculateInterest()
        {
            decimal interest = 0;
            interest = Balance * InterestRate;
            return interest;
            InterestDate = DateTime.Now;
            
        }
    }
}