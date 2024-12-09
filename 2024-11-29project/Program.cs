using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024_11_29project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제 1
            //Console.WriteLine("비교할숫자 넣으세요");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("비교할숫자 넣으세요");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("비교할숫자 넣으세요");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("비교할숫자 넣으세요");
            //int d = int.Parse(Console.ReadLine());
            //WhoBig(a,b,c,d);
            #endregion

            #region 과제 2
            //int i = 0;
            //float[] arr = new float[5];
            //while (i < 5)
            //{
            //    Console.WriteLine("값을넣으세요");
            //    arr[i] = float.Parse(Console.ReadLine());
            //    Bigtwosum(arr[0], arr[1], arr[2], arr[3], arr[4]);
            //    i++;
            //}

            #endregion

            #region 과제 3

            //Console.WriteLine("비교할숫자 넣으세요");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("비교할숫자 넣으세요");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Trfa(a, b));

            #endregion

        }
        static void WhoBig(int a, int b, int c, int d)
        {
            int Bestbig1 = 0;
            int Bestbig2 = 0;
            if (a > b)
            {
                a = Bestbig1;
            }
            else
            {
                b = Bestbig1;
            }

            if (c > d)
            {
                Bestbig2 = c;
            }
            else
            {
                Bestbig2 = d;
            }

            if (Bestbig1 > Bestbig2)
            {
                Console.WriteLine(Bestbig1);
            }
            else
            {
                Console.WriteLine(Bestbig2);
            }
        }

        static void Bigtwosum(float a, float b, float c, float d, float e)
        {
            float Bestbig1 = 0;
            float Bestbig2 = 0;
            if (a > b)
            {
                a = Bestbig1;
            }
            else
            {
                b = Bestbig1;
            }

            if (c > d)
            {
                Bestbig2 = c;
            }
            else
            {
                Bestbig2 = d;
            }
            if (Bestbig1 > Bestbig2)
            {
                if (Bestbig1 < e)
                {
                    Console.WriteLine(Bestbig1 + e);
                }
                else if (Bestbig1 > e)
                {
                    if (Bestbig2 < e)
                    {
                        Console.WriteLine(Bestbig1 + e);
                    }
                    else
                    {
                        Console.WriteLine(Bestbig1 + Bestbig2);
                    }

                }
            }
            else if (Bestbig2 > Bestbig1)
            {
                if (Bestbig2 < e)
                {
                    Console.WriteLine(Bestbig2 + e);
                }
                else if (Bestbig2 > e)
                {
                    if (Bestbig1 < e)
                    {
                        Console.WriteLine(Bestbig2 + e);
                    }
                    else
                    {
                        Console.WriteLine(Bestbig1 + Bestbig2);
                    }

                }
            }
        }

        static bool Trfa (int a, int b)
        {
            int change = 0;
            if(b>a)
            {
                change = a;
                a = b;
                b = change;
                change = a - b;
            }
            else
            {
                change = a - b;
            }

            if (change < 100)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static int fihonaci(int a)
        {
            int sum;
            int num = 1;
            for(int i = 1; i < a; i++)
            {
                sum = i + num;
                Console.WriteLine(sum);
            }



        }







    }

    
}
