using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma
            //int i;
            //for (i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*);
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma
            //int i;
            //for (i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //int i;
            //for (i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen
            //int i, j;
            //for (i = 1; i <= 5; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Dik Üçgen

            //int i, j;
            //for (i = 5; i >= 1; i--)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen Beraber

            //int i, j, k, l;
            //for (i = 1; i <= 10; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();

            //}

            //for (k = 9; k >= 1; k--)
            //{
            //    for (l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi
            int n = 5;
            int i, k, j, l;

            for (i = 1; i <= n; i++)
            {
                for (j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            for (i = n - 1; i >= 1; i--)
            {
                for (j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (l = 1; l < 2 * i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
            Console.Read();

        }
    }
}
