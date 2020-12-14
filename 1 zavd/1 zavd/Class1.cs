using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zavd
{
    class Array
    {
        private int[] a;
        //поле класу
        public Array(params int[] a)
        //конструктор, в якому ініціалізується об'єкт
        {
            this.a = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                this[i] = a[i];
        }
        public int Length
        {
            //повертає довжину об'єкта
            get
            {
                return a.Length;
            }
        }
        public int this[int i]
        {
            get
            {
                //умова, при якій існує масив
                if (i >= 0 && i < this.Length)
                    return a[i];
                else
                    return 0;
            }
            set
            {
                if (i >= 0 && i < this.Length && value >= 0 && value <= 100)
                    a[i] = value;
            }
        }
        public override string ToString()
        //перевизначення методу ToString, класу object (одна з особливостей поліморфізму) 
        {
            string res = " ";
            for (int i = 0; i < a.Length; i++)
            {
                res = res + a[i] + " ";
            }
            return res;
        }
        public int FindMax()
        //знаходження максимального елементу
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public int FindMin()
        //знаходження мінімального елементу
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
    }
}