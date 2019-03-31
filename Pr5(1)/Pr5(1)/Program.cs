using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr5_1_
{
    interface ISort//IStrategy
    {
        void Algorithm(int[] array);
    }

    class Bubble : ISort//ConcreteStrategy1
    {
        public void Algorithm(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int c;
                        c = array[i];
                        array[i] = array[j];
                        array[j] = c;
                    }
                }
            }
        }
    }

    class Shella : ISort//ConcreteStrategy2
    {
        public void Algorithm(int[] array)
        {
            for (int i = array.Length / 2; i >= 1; i /= 2)
            {
                for (int j = i; j < array.Length; j++)
                {
                    for (int t = j; t >= i && array[t - i] > array[t]; t -= i)
                    {
                        int c;
                        c = array[t];
                        array[t] = array[t-i];
                        array[t-i] = c;
                    }
                }
            }
        }
    }

    class Gnome: ISort//ConcreteStrategy3
    {
        public void Algorithm(int[] array)
        {
            int i = 1;
            while (i < array.Length)
            {
                if (i == 0 || array[i - 1] <= array[i])
                    i++;
                else
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i--;
                }
            }
        }
    }

    class Array//Context
    {
        public int[] array;
        public ISort sort { private get; set; }
        public Array(int[] array, ISort mov)
        {
            this.array = array;
            sort = mov;
        }
        public void Sort()
        {
           sort.Algorithm(array);
        }
        public void Show()
        {
            foreach (int arr in array)
            {
                Write(arr+" ");
            }
            WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Write("Count: ");
            count = Convert.ToInt32(ReadLine());
            int[] array = new int[count];
            Random rand = new Random();
            for(int i=0; i<count; i++)
            {
                array[i] = rand.Next(0,15);
            }
            Array arr = new Array(array, new Bubble());//Context
            WriteLine("Bubble: ");
            arr.Show();
            arr.Sort();
            arr.Show();
            WriteLine();

            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(0, 15);
            }
            WriteLine("Shella:");
            arr.sort = new Shella();
            arr.array = array;
            arr.Show();
            arr.Sort();
            arr.Show();
            WriteLine();

            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(0, 15);
            }
            WriteLine("Gnome: ");
            arr.sort = new Gnome();
            arr.array = array;
            arr.Show();
            arr.Sort();
            arr.Show();

            ReadKey();
        }
    }
}
