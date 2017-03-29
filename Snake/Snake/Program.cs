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

            pList.Add(new Point(1, 3, '#'));
            pList.Add(new Point(2, 3, '*'));
            pList.Add(new Point(3, 3, '!'));
            pList.Add(new Point(4, 3, '@'));

            for (int i = 0; i < pList.Count; i++)
            {
                int z = i + 1;
                Console.WriteLine("Точка " + z + " имеет координаты x:" + pList[i].x + " y:" + pList[i].y +
                    " и символ \" " + pList[i].sym + "\""
                    );
            }


            Console.ReadLine();


        }         
                     
}


}
