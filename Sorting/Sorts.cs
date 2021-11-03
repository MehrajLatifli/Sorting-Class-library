using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Sorts
    {
        public static void showListNumber(List<int> numberList)
        {
            Console.WriteLine("\n");
            foreach (var item in numberList)
            {
                Console.Write($" {item} ");
            }
        }
        public static void AddList(List<int> numberList, int number)
        {
            numberList.Add(number);
        }

        public static void BubbleSortNumber(List<int> numberList)
        {
            int len = numberList.Count;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    int a = numberList[j];
                    if (a != numberList[len - 1])
                    {
                        int b = numberList[j + 1];
                        if (a > b)
                        {
                            numberList[j] = b;
                            numberList[j + 1] = a;
                        }
                    }
                }
            }
        }




    }
}
