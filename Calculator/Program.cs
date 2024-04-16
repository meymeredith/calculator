using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Записываем выражение, которое ввел пользователь
            // в переменную expression
            string expression = readUserExpression();

            // Создаем объект класса Calculator
            Calculator calculator = new Calculator();
            // Вычисляем выражение
            int result = calculator.Calculate(expression);

            Console.WriteLine(result);
        }

        /// <summary>
        /// Читаем пользовательский ввод
        /// </summary>
        /// <returns></returns>
        private static string readUserExpression()
        {
            Console.Write("Введите ваше выражение: ");
            string myOps = Console.ReadLine();
            Console.WriteLine("Ваше выражение: " + myOps);

            return myOps;
        }
    }

    public class Calculator
    {

        /// <summary>
        /// Метод, вычисляющий выражение на основе строки <br/>
        /// Это единственный открытый метод, на вход которого подается
        /// выражение в виде строки, а на выходе ожидается результат
        /// вычисления
        /// </summary>
        /// <param name="str">строка</param>
        public int Calculate(string str)
        {
            int[] numbers = getNumbers(str);
            char[] operations = getOperations(str);

            return calculate(numbers, operations);
        }

        private int calculate(int[] numbers, char[] operations)
        {
            return 0;
        }

        private int[] getNumbers(string str)
        {
            return
            [
                2,
                4,
                1,
            ];
        }

        private char[] getOperations(string str)
        {
            return
            [
                '+',
                '-'
            ];
        }
    }
}