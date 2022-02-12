using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace List
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> list = new List<int>() {6, 12, -3, 44, 76, 5, 100 };
            

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }

            PrintCollection(list);
            Console.ReadKey();
        }

        private static void PrintCollection(List<int> list)
        {
            foreach ( int item in list )
            {
                Console.WriteLine(item);
            }
        }
    }

}

//15.Из созданного списка удалить каждый нечетный элемент.