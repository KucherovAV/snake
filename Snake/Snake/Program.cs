using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> pList = new List<Point>();

            Point p1 = new Point(1, 2, '^');
            pList.Add(p1);

            Point p2 = new Point(4, 5, '!');
            pList.Add(p2);

            foreach (var pl in pList)
            {
                pl.Draw();
            }
            Console.ReadKey();
        

        Console.ReadLine();


        }         
                     
}


}
