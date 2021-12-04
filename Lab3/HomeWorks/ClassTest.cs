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
        public int CompareTo(ClassTest? other)
        {
            if (this.Age < other.Age) return -1;
            else if (this.Age > other.Age) return 1;
            else return 0;
        }
        //public int CompareTo(ClassTest other)
        //{
        //    return this.Age.CompareTo(other.Age);
        //}
    }
}