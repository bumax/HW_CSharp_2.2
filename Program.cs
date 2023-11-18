namespace HW_CSharp_2._2
{
    internal class Program
    {
        /*Дан двумерный массив.
        732
        496
        185

        Отсортировать данные в нем по возрастанию.
        123
        456
        789

        Вывести результат на печать.

        class Program
        {
            static void Main(string[] args)
            {
                int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            }
        }*/
        private static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            Console.WriteLine("Масссив до сортировки:");
            ArrayProc.Print2d(a);
            ArrayProc.ICantBelieveItCanSort(a);
            Console.WriteLine("Масссив после сортировки:");
            ArrayProc.Print2d(a);
        }
    }
}