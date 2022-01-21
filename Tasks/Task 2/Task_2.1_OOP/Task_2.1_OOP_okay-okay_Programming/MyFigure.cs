using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1_OOP_okay_okay_Programming
{
    class MyFigure
    {

    }

    class Box
    {
        int x;

        public Box()
        {
            x = 1;
        }
        public Box(int x)
        {
            this.x = x;
        }
    }
    class Rectangle: Box
    {
        int  y;
        
        public Rectangle()
        {
            
            y = 1;
        }

        public Rectangle(int y)
        {
            this.y = y;
        }
    }
}
