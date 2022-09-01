using Modul17.CalculateInterest;
using System;

namespace Modul17
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём два счёта
            Account accountBase = new Account { Type = "Base", Balance = 900.00 };
            Account accountSalary = new Account { Type = "Salary", Balance = 900.00 };

            // расчёт 
            CalcInterest(accountBase);
            CalcInterest(accountSalary);
            

            Console.WriteLine($"Процентная ставка для обычного счёта: {accountBase.Interest} \n");
            Console.WriteLine($"Процентная ставка для зарплатного счёта: {accountSalary.Interest} \n");

            Console.ReadKey();
        }

        static void CalcInterest (Account account)
        {

            switch (account.Type)
            {
                case "Base":
                    Calculator.CalculateInterest(new BaseCalculateInterest(), account);
                    break;

                case "Salary":
                    Calculator.CalculateInterest(new SalaryCalculateInterest(), account);
                    break;
            }
        }
    }

}
