using System;
using System.Collections.Generic;
using System.Text;

namespace Modul17.CalculateInterest
{

    /// <summary>
    /// Реализация интерфейса для расчёта зарплатного счёта
    /// </summary>
    public class SalaryCalculateInterest : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            // здесь расчёт для зарплатного
            account.Interest = account.Balance * 0.5;

        }
    }
}
