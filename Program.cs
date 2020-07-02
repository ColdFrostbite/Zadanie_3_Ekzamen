using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class Program
    {
       static void Main(string[] args)
       {

            int Banks;//количество банков
            double Razor;//вероятность банкротства
            Int32 Otvet;

            Banks = 4;

            Int32 Factorial(int x)
            {

                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }

            }

            double Bh(int n, int k)
            {

                return Factorial(n) / (Factorial(k) * Factorial(n - k));
            }

            Console.Write("Введите количество банков:  ");
            Banks = Convert.ToInt32(Console.ReadLine());
            while (Banks > 10)
            {
                Console.Write("Количество банков превышает допустимое");
                Console.Write("Хотите ли вы повторить ввод? (1-да/0-нет)");
                Otvet = Convert.ToInt32(Console.ReadLine());

                if (Otvet == 1)
                {
                    Console.Write("Введите количество банков:  ");
                    Banks = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    return;
                }

            }
            Console.Write("Введите вероятность разорения:  ");
            Razor = Convert.ToDouble(Console.ReadLine());
            if (Razor > 1)
            {
                Console.Write("Шанс разорения не может быть выше 1");
                return;
            }

            double[] Massive = new double[Banks+1];

            for (int i = 0; i <= Banks; i++)
            {
                Massive[i] = Bh(Banks, i) * Math.Pow(Razor, i) * Math.Pow(1 - Razor, Banks - i);
                Massive[i] = 100*Math.Round(Massive[i],2);
                Console.WriteLine("Вероятность разорения: " +i+" Банков "+ Massive[i] + " %");
            }


            Console.ReadLine();
        }
    }
 }
