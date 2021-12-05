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
            string max = temp[0];
            string min = temp[0];
            int lengthMax = temp[0].Length;
            int lengthMin = temp[0].Length;

            for (int i = 0; i < temp.Length; i++)
            {
                if (lengthMax <= temp[i].Length)
                {
                    lengthMax = temp[i].Length;
                    max = temp[i];
                }
                if (lengthMin >= temp[i].Length)
                {
                    lengthMin = temp[i].Length;
                    min = temp[i];
                }
            }
            return (max, lengthMax, min, lengthMin);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            string str = null;
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                foreach (char c in temp[i])
                {
                    if (c > '0' && c < '9')
                    {
                        str = temp[i];
                        return str;
                    }
                    else break;
                }                
            }
            return str;
        }
    }
}