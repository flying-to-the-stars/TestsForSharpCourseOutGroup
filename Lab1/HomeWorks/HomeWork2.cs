using System;
using System.Collections;
namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            int max_dlina = 0;
            int min_dlina = temp[0].Length;
            string max_string = "";
            string min_string = temp[0];
            for (int i = 0; i < temp.Length; i++)
            {
                if (max_dlina <= temp[i].Length)
                {
                    max_dlina = temp[i].Length;
                    max_string = temp[i];

                }

                
                


                if (min_dlina >= temp[i].Length)
                {
                    min_dlina = temp[i].Length;
                    min_string = temp[i];
                }
            }
            return (max_string, max_dlina, min_string, min_dlina);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            
            string? stroka1 = null;
            foreach (string stroka in temp)
            {
                bool isNumeric = int.TryParse(stroka, out _);
                if (isNumeric)
                {
                    stroka1 = stroka;
                }
                
            }
            return stroka1;
            
        }
    }
}