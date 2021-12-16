using System;
using NUnit.Framework;

namespace Lab4.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода с обработкой исключений
    /// </summary>
    public static class ClassTest
    {
        public static void MetrodWithException(int temp) 
        {
            switch (temp)
            {
                case 10: throw new Exception();
                case 4: throw new Exception();
                case 99: throw new Exception();

            }
            
           if (temp == 11) Assert.AreEqual(temp, 11);
           else if(temp == 2) Assert.AreEqual(temp, 2);
           else if (temp == 89) Assert.AreEqual(temp, 89);
            



        }
    }
}