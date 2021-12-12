using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable<ClassTest>
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public int CompareTo(ClassTest c)
        {
            //ClassTest c = obj as ClassTest;
            //if (c != null)

            //    return this.Age.CompareTo(c.Age);
            //else
            //    throw new Exception("Невозможно сравнить два объекта");

            //return this.Age.CompareTo(c.Age);
            if (this.Age > c.Age)
                return 1;
            else if (this.Age < c.Age)
                return -1;
            else
                return 0;


        }
    }
}