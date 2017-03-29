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
            // класс может работать не только с данными, но и с методами, фун-ми
            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            point p2 = new point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '+';
            p2.Draw();

            /*
            int x1 = 1; //не пишем на каждую переменную отдельно её тип, все в одной строке, чтобы сократить код
            int y1 = 3;
            char sym1 = '*';//указываем в одинарных скобках, это НЕ ТЕКСТ

            Draw(x1, y1, sym1);//в методе Draw нельзя указывать более 4 аргументов, поэтому пишем 2 раза

            int x2 = 4;
            int y2 = 5;
            char sym2 = '+';

            Draw(x2, y2, sym2);*/

            Console.ReadLine();//программа не закроется сама пока пользователь не нажмет Enter


        }
        /*static void Draw(int x, int y, char sym)//так называемый процедурный метод
                                                //эта ф-ия позволяет нам не копировать несколько раз нижеприведенный код, а выполняет его
                                                //относительно количества вышенаписаных Draw
        {
            Console.SetCursorPosition(x, y);//указали координаты где выводить точку
        Console.Write(sym);//выводим символ в координатах указаных сверху    }*/
                
            
           
}


}
