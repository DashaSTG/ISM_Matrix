using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLibrary;

namespace task_console
{
    class console
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть рядкiв: ");
            int lines = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiлькiсть стовпчикiв: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[lines, columns];

            Random random = new Random();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Library solver = new Library();

            var maxModNumber = solver.Task1(matrix);
            Console.WriteLine($"Максимальне за модулем число = {maxModNumber}");

            var matrix2 = solver.Task2(matrix);
            Console.WriteLine($"Транспонована матриця: ");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }

                Console.WriteLine();
            }

            var sumTask3 = solver.Task3(matrix);
            Console.WriteLine($"Сума додатнiх елементiв масиву = {sumTask3}");


            var linesWithoutZero = solver.Task4(matrix);
            Console.WriteLine($"Кiлькiсть рядкiв без нуля = {linesWithoutZero}");


            var columnsWithZero = solver.Task5(matrix);
            Console.WriteLine($"Кiлькiсть стовпчикiв з нулем = {columnsWithZero}");


            var lineIndex = solver.Task6(matrix);
            if (lineIndex == -1)
            {
                Console.WriteLine("Не iснує");
            }
            Console.WriteLine($"Номер рядка з найдовшою серiєю однакових елементiв {lineIndex}");


            if (lines == columns)
            {
                var mainDiagonalSum = solver.Task7(matrix);
                Console.WriteLine($"Сума елементiв головної дiагоналi матрицi = {mainDiagonalSum}");
            }


            if (lines == columns)
            {
                var additionalDiagonalSum = solver.Task8(matrix);
                Console.WriteLine($"Сума елементiв побiчної дiагоналi матрицi = {additionalDiagonalSum}");
            }


            var sumTask9 = solver.Task9(matrix);
            Console.WriteLine($"Сума елементiв, якi розташованi на позицiях з парною сумою iндексiв = {sumTask9}");
        }
    }
}
