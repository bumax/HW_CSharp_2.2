using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CSharp_2._2
{
    internal class ArrayProc
    {
        /// <summary>
        /// Получение элемента из 2D массива по индексу
        /// </summary>
        /// <param name="array">Исходный 2D массив</param>
        /// <param name="n">Инедекс элемента в 2D массиве (считаем "змейкой" слева направо и сверху вниз</param>
        /// <returns></returns>
        public static int GetElement(int[,] array, int n)
        {
            int x = n / array.GetLength(0);
            int y = n % array.GetLength(0);
            return array[x, y];
        }
        /// <summary>
        /// Присвеавание нового значения элементу в 2D массиве по индексу
        /// </summary>
        /// <param name="array">Исходный 2D массив</param>
        /// <param name="n">Инедекс элемента в 2D массиве (считаем "змейкой" слева направо и сверху вниз</param>
        /// <param name="val">Новое значение</param>
        public static void SetElement(int[,] array, int n, int val)
        {
            int x = n / array.GetLength(0);
            int y = n % array.GetLength(0);
            array[x, y] = val;
        }
        /// <summary>
        /// Сортировка самым примитивным алгоритмом ICan'tBelieveItCanSort
        /// </summary>
        /// <param name="array">Исходный 2D массив</param>
        public static void ICantBelieveItCanSort(int[,] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int k = 0; k < i - 1; k++)
                {
                    if (GetElement(array,i) < GetElement(array, k))
                    {
                        int tmp = GetElement(array, i);
                        SetElement(array, i, GetElement(array, k));
                        SetElement(array, k, tmp);
                    }
                }
            }
        }
        /// <summary>
        /// Вывод на печать одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public static void Print1d(int[] array)
        {
            Console.WriteLine("[" + string.Join(',',array) + "]");
        }
        /// <summary>
        /// Получение строки из 2D массива
        /// </summary>
        /// <param name="array">Исходный 2D массив</param>
        /// <param name="index">Номер строки</param>
        /// <returns></returns>
        public static int[] GetSubArray(int[,] array, int index)
        {
            int len = array.GetLength(1);
            int[] res = new int[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = array[index, i];
            }
            return res;
        }
        /// <summary>
        /// Печать 2D массива
        /// </summary>
        /// <param name="array"></param>
        public static void Print2d(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Print1d(GetSubArray(array, i));
            }
        }
    }
}
