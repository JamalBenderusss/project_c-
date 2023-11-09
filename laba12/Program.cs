using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[11];
            Random rnd= new Random();
            for (int z = 0; z < massive.Length; z++)
            {
                massive[z] = rnd.Next(0,100);
            }
            for (int z = 0; z < massive.Length; z++)
            {
                Console.Write("{0}  ", massive[z]);
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine(massive[11]);
            }
            catch (Exception e) 
            {
                string ex = e.ToString();
                Console.WriteLine("{0}\n{1}", ex, e.Message);
            }
            Console.WriteLine() ;

            int i = 10 * 11;
            int j = 5+ 11;
            try
            {
                while (j>=-10)
                {
                    Console.Write("{0} ", i % j);
                    i += 3;
                    j-=1;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0");
            }
            Console.WriteLine("Задание 2");
            int notshort = rnd.Next(35000, 222222222);
            short sh;

            try
            {
                for (int a = 1; a < 15; a++)
                {
                    try
                    {
                        sh = checked((short)notshort);
                        Console.WriteLine(sh);
                    }
                    catch(OverflowException) 
                    {
                        Console.WriteLine("Сработал внутренний обработчик");
                        throw;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Сработал внешний обработчик");
            }
            finally
            {
                sh = (short)notshort;
                Console.WriteLine(sh);
            }
        }
    }
}
