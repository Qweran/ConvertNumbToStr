using System;
using System.IO;

namespace Slavik
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int []n = null;
                int []ed = null;
                string[] b = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять" };
                string[] bb = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять" };
                string[] c = { "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                string[] d = { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семдесят", "восемьдесят", "девяносто", "сто" };
                string[] f = { "сто","двести", "триста", "четыриста", "пятьсот","Чупапупа", "семьсот", "восемьсот", "девятьсот", "тысяча" };

               if(a > 10)
                {
                    if (a > 19)
                    {
                        if (a > 100)
                        {
                            Console.Write(f[a/100-1] + " ");
                            if (a - (a/100*100) > 19) 
                            {
                                Console.WriteLine(d[(a - (a / 100 * 100)) / 10 - 2] + " " + bb[(a - (a / 100 * 100)) - ((a - (a / 100 * 100)) / 10) * 10]);
                            }
                            else
                            {
                                if (a - (a / 100 * 100) <= 10)
                                {
                                    Console.WriteLine(bb[((a - a / 100 * 100) - (a - a / 100 * 100) / 10 * 10)]);
                                }
                                else
                                {
                                    Console.WriteLine(c[a - (a / 100 * 100) - 11]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(d[a / 10 - 2] + " " + bb[a - (a / 10) * 10]);
                        }
                         
                    }
                    else
                    {
                        Console.WriteLine(c[a - 11]);
                    }
                   

                }
                else
                {
                    Console.WriteLine(b[a]);
                }
                
            }
            Console.ReadKey();
        }
    
    }

  }


    
