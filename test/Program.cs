using System;
using System.IO;
//hfdhfghjhgffty
namespace Slavik
{
    class Program
    {
        static string[] ed = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        static string[] edd = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        static string[] krig = { "десять", "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
        static string[] dec = { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семдесят", "восемьдесят", "девяносто" };
        static string[] hagr = { "", "сто", "двести", "триста", "четыриста", "пятьсот", "Чупапупа", "семьсот", "восемьсот", "девятьсот", "тысяча" };
        static string[] hagsrEd = { "тысяч", "одна тысяча", "две тысячи", "три тысячи", "четыре тысячи" };
        static string[] hgagr = { "", "сто", "двести", "триста", "четыриста", "пятьсот", "Чупапупа", "семьсот", "восемьсот", "девятьсот", "тысяча" };

        public static void Main()
        {
            int j = 50000;
            while (j < 70000)
            {
                string s = j.ToString();
                Console.Write(j + "  =  ");
                int n = int.Parse(s);

                switch (n)
                {
                    case < 10:
                        Console.WriteLine(ed[n]);
                        break;
                    case < 20:
                        Console.WriteLine(krig[n-10]);
                        break;
                    case < 100:
                        Console.Write(dec[int.Parse(s[0].ToString())-2] + " ");
                        Console.WriteLine(edd[int.Parse(s[1].ToString())]);
                        break;
                    case < 1000:
                        Sot(s);
                        break;
                    case < 10000:
                        switch (int.Parse(s[s.Length - 4].ToString()))
                        {
                            case < 5:
                                Console.Write(hagsrEd[int.Parse(s[s.Length - 4].ToString())] + " ");
                                break;
                            default:
                                Console.Write(edd[int.Parse(s[s.Length - 4].ToString())] + " тысяч ");
                                break;
                        }
                        Sot(s);
                        break;
                    case < 100000:
                        switch (int.Parse(s[s.Length - 5].ToString()))
                        {
                            case < 2:
                                Console.Write(krig[int.Parse(s[s.Length - 4].ToString())] + " тысяч ");
                                break;
                            default:
                                Console.Write(dec[-2 + int.Parse(s[s.Length - 5].ToString())] + " ");
                                switch (int.Parse(s[s.Length - 4].ToString()))
                                {
                                    case < 5:
                                        Console.Write(hagsrEd[int.Parse(s[s.Length - 4].ToString())] + " ");
                                        break;
                                    default:
                                        Console.Write(edd[int.Parse(s[s.Length - 4].ToString())] + " тысяч ");
                                        break;
                                }
                                break;
                        }
                        Sot(s);
                        break;
                    default:
                        break;
                }
                j++;
            }

            //Console.ReadKey();
        }

        public static void Sot(string s)
        {
            Console.Write(hagr[int.Parse(s[s.Length-3].ToString())] + " ");
            switch (int.Parse(s[s.Length - 2].ToString() + s[s.Length-1].ToString()))
            {
                case < 10:
                    Console.WriteLine(edd[int.Parse(s[s.Length - 1].ToString())]);
                    break;
                case < 20:
                    Console.WriteLine(krig[int.Parse(s[s.Length - 1].ToString())]);
                    break;
                case < 100:
                    Console.Write(dec[int.Parse(s[s.Length - 2].ToString()) - 2] + " ");
                    Console.WriteLine(edd[int.Parse(s[s.Length - 1].ToString())]);
                    break;
                default:
                    break;
            }
        }
    }
}