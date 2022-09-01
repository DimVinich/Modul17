using Modul17.CalculateInterest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modul17
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ICalculateInterest сalculateInterest, Account account)
        {
            сalculateInterest.CalculateInterest(account);
        }
    }
}
