using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()                       //так называемый процедурный метод
                                                //эта ф-ия позволяет нам не копировать несколько раз нижеприведенный код, а выполняет его
                                                //относительно количества вышенаписаных Draw
        {
            Console.SetCursorPosition(x, y);//указали координаты где выводить точку
            Console.Write(sym);//выводим символ в координатах указаных сверху
        }

    }
}
