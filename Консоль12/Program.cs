using System;

namespace _4_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            //t 11
            Console.WriteLine("matrix");
            Matrix matrix = new Matrix(3, 3);
            matrix.EnterElements();
            matrix.PrintMatrix();
            Console.WriteLine($"Количество элементов в массиве: {matrix.ElementCount}");
            Console.Write("Введите скаляр: "); double scal = Convert.ToDouble(Console.ReadLine());
            matrix.ScalarMultiply = scal;
            matrix.PrintMatrix();
            Console.WriteLine("Сортировка строк по убыванию: ");
            matrix.SortMatrix();
            matrix.PrintMatrix();
            Console.ReadLine();
            //t 12
            Matrix matrix2 = new Matrix(3, 3);
            Console.WriteLine("matrix2");
            matrix2.EnterElements();
            matrix2.PrintMatrix();
            Console.WriteLine("Опрератор -- (matrix):");
            matrix--;
            matrix.PrintMatrix();
            Console.WriteLine("Опрератор ++ (matrix2):");
            matrix2++;
            matrix2.PrintMatrix();
            if (matrix2) Console.WriteLine("Все строки в matrix2 отсортированны в порядке возрастания");
            else Console.WriteLine("Cтроки не отсортированны в порядке возрастания");
            Console.WriteLine("matrix*matrix2:");
            matrix2 = matrix * matrix2;
            matrix2.PrintMatrix();
            double[,] arr = matrix.ToArray();//преобразование к двумерному массиву
            matrix.ToMatrix(arr);//преобразование к ступенчатому массиву
            Console.ReadLine();
        }
    }
}
