using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абсциссу точки C :");
            Single korX = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите ординату точки С :");
            Single korY = Convert.ToSingle(Console.ReadLine());

            if ( korY >= Math.Abs(korX) - 1 & korY <= -Math.Abs(korX) +1 )
                Console.WriteLine("Заданная точка C (" + korX + ";" + korY + ") принадлежит заштрихованной плоскости");
            else
                Console.WriteLine("Данная точка C (" + korX + ";" + korY + ") не принадлежит заштрихованной плоскости");

            Console.ReadLine();
        }
    }
}
