using System;
namespace Lab1.HomeWorks

{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        {
            int min_value = 0;
            int min_value_index = 0;
            int min_positive_value = 0;
            int min_positive_value_index = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    if (min_value == 0)
                    {
                        min_value = temp[i];
                        min_value_index = i;
                    }
                    else if (temp[i] < min_value)
                    {
                        min_value = temp[i];
                        min_value_index = i;
                    }
                }

                if (temp[i] > 0)
                {
                    if (min_positive_value == 0)
                    {
                        min_positive_value = temp[i];
                        min_positive_value_index = i;
                    }
                    else if (temp[i] < min_positive_value)
                    {
                        min_positive_value = temp[i];
                        min_positive_value_index = i;
                    }
                }
            }

            int[] newArray = new int[temp.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (min_value == 0 || min_positive_value == 0)
                {
                    return temp;
                }
                if (i == min_value_index)
                {
                    newArray[i] = min_positive_value;
                }
                else if (i == min_positive_value_index)
                {
                    newArray[i] = min_value;
                }
                else
                {
                    newArray[i] = temp[i];
                }
            }

            return newArray;
        }


        /// <summary>
        /// В массиве целых чисел определить сумму элементов, стоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
            {
                int sum1 = 0;
                for (int i = 0; i<temp.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum1 += temp[i];
                    }
                }
                return sum1;
            }

            /// <summary>
            /// В массиве целых чисел заменить нулями отрицательные элементы.
            /// </summary>
            /// <param name="temp">Исходный массив</param>
            /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
            public static int[] Variant3(int[] temp)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] < 0)
                    {
                        temp[i] = 0;
                    }
                }
                return temp;
            }

            /// <summary>
            /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
            /// </summary>
            /// <param name="temp">Исходный массив</param>
            /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
            public static int[] Variant4(int[] temp)
            {
                for (int i = 0; i < temp.Length-1; i++)
                {
                    if ((temp[i] > 0) & (temp[i + 1] < 0))
                    {
                        temp[i] *= 3;
                    }
                }
                return temp;
            }

            /// <summary>
            /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
            /// </summary>
            /// <param name="temp">Исходный массив</param>
            /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
            public static double Variant5(int[] temp)
            {
                int min_value = temp[0];
                int sum1 = 0;
                
                for (int i = 0; i<temp.Length; i++)
                { 
                    if (min_value > temp[i])
                    {
                        min_value = temp[i];
                    }
                    sum1 += temp[i];
                }
                double aver_value = sum1 / temp.Length;
                return (aver_value - min_value);
        }
        }
    }
    


