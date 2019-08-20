using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертер валют на 12.07.2019");
            Console.WriteLine("Выберите номер операции" + "\r\n" + "1.Usd to BYN" + "\r\n" + "2.BYN to USD");
            string nomer = Console.ReadLine();
            int a = Convert.ToInt32(nomer);
            if (a == 1)
                {
                    Console.WriteLine("Введите сумму в USD");
                    string USD = Console.ReadLine();
                    double val;
                    double.TryParse(USD, out val);
                    Console.WriteLine("К выплате BYN " + (val * 2.031));
                }
            if (a == 2)
                {
                    Console.WriteLine("Введите сумму в BYN");
                    string BYN = Console.ReadLine();
                    double val;
                    double.TryParse(BYN, out val);
                    Console.WriteLine("К выплате USD " + (val / 2.035));
                }
            Console.ReadLine();
            }
                  
    }
}
