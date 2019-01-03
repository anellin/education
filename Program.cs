using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //class task #1: вывести на консоль повторяющиеся в массиве цифры (без их повторения на консоли)

            //int[] intArray = new int[] { 2, 3, 3, 2, 0, 0, 4, 2, 3, 4};
            //int[] result = new int[intArray.Length];
            //int count = 0;
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    for (int j = i + 1; j < intArray.Length; j++)
            //    {
            //        if (intArray[i] == intArray[j])
            //        {
            //            for (int k = 0; k < result.Length; k++)
            //            {
            //                if (intArray[j] == result[k] && intArray[j] != 0)
            //                {
            //                    break;
            //                }
            //                else if (intArray[j] != result[k] && result[k] == 0)
            //                {
            //                    result[count] = intArray[j];
            //                    count = count + 1;
            //                    break;
            //                }
            //                else if (intArray[j] == 0)
            //                {
            //                    result[count] = intArray[j];
            //                    count = count + 1;
            //                    break;
            //                }
            //                else continue;
            //            }
            //        }
            //        else continue;
            //    }
            //}
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //Console.ReadKey();


            //class task #2: вывести на консоль количество максимальных повторений числа в массиве

            //int[] intArray1 = new int[] { 2, 3, 3, 4, 3, 1, 8, 8, 3 };
            //int maxCount = 0;
            //int counter = 0;
            //for (int i = 0; i < intArray1.Length; i++)
            //{
            //    for (int j = i + 1; j < intArray1.Length; j++)
            //    {
            //        if (intArray1[i] == intArray1[j])
            //        {
            //            for (int k = 0; k < intArray1.Length; k++)
            //            {
            //                if (intArray1[i] == intArray1[k])
            //                {
            //                    counter = counter + 1;
            //                }
            //                else continue;
            //            }
            //            if (counter > maxCount)
            //            {
            //                maxCount = counter;
            //                counter = 0;
            //            }
            //            else
            //            {
            //                counter = 0;
            //            }
            //        }
            //        else continue;
            //    }
            //}
            //Console.WriteLine(maxCount);


            //home task #1: Начав тренировки, лыжник в первый день пробежал 10 км. Через каждый
            //следующий день(между тренировками один день интервала) он увеличивал пробeг
            //на 10 % от пробега предыдущего дня. Определить в какой день суммарный пробег за
            //все дни превысит 100 км.

            double distance = 10;
            int dayCount = 1;
            while (distance < 100)
            {
                dayCount = dayCount + 2;
                distance = distance * 1.1;
            }

            Console.WriteLine(dayCount);
        }
    }
}
