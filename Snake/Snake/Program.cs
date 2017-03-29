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
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(6, 6, '#');
            Point p3 = new Point(8, 8, '$');
            Point p4 = new Point(10, 10, '&');
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadLine();


        }         
                     
}


}
