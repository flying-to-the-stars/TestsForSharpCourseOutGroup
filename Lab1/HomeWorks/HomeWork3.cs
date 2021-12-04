using System;
namespace Lab1.HomeWorks
{
    /// <summary>
    /// Метод калькулятор
    /// Исходные условия: Метод принимает два числа и знак операции.
    /// </summary>
    public class HomeWork3
    {
        /// <summary>
        /// Метод калькулятора
        /// </summary>
        /// <param name="x">Первый операнд</param>
        /// <param name="y">Второй операнд</param>
        /// <param name="mathOperation">Знак операции</param>
        /// <returns>Результат вычисления</returns>
        public static double Calculator(double x, double y, char mathOperation = '+')
        {
            double temp = 0;
           
                switch (mathOperation)
                {
                    case '+': temp = x + y; break;
                    case '-': temp = x - y; break;
                    case '*': temp = x * y; break;
                    
                    case ')': throw new Exception();
                    case '/': if (y == 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        temp = x / y; break;
                    }
               
                }
                return temp;
            

        }
    }
}