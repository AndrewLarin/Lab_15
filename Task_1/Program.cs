using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Введите первый элемент арифметической прогрессии");
            arith.setStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите шаг прогрессии");
            arith.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());

            GeomProgression geom = new GeomProgression();
            Console.WriteLine("Введите первый элемент геометрической прогрессии");
            geom.setStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите знаменатель прогрессии");
            geom.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset();    
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
