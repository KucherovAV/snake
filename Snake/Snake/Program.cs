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
            Point t1 = new Point(0, 0, '=');
            Point t2 = new Point(1, 1, '*');
            Point t3 = new Point(2, 2, '+');

            List<Point> listPoints = new List<Point>();
            listPoints.Add(t1);
            listPoints.Add(t2);
            listPoints.Add(t3);

            foreach (Point i in listPoints)
                i.Draw();
            Console.WriteLine();
            Console.ReadLine();


        }         
                     
}


}
