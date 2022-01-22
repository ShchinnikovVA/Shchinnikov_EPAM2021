using System;
using System.Collections.Generic;
using System.Text;
using EpamClassLibrary;

namespace Task_2._1_OOP_okay_okay_Programming
{
    class MyFigure
    {
        List<object> figures = new List<object>();

        public void ShowListFigure()
        {
            for (int i = 0; i < figures.Count; i++)
            {
                Console.Write("№{0} - ", i);
                //figures[i].PrintFigure();
            }
        }
        public void CreateDot()
        {
            Console.WriteLine("Введите имя точки");
            string name = Console.ReadLine();
            int x = Numbers.Read_Int("Введите Х точки");
            int y = Numbers.Read_Int("Введите Y точки");
            Dot d = new Dot(name, x, y);
            d.PrintFigure();
            figures.Add(d);
        }

        //public void CreateLine()
        //{
        //    Dot d1 = 
        //}
        public void CreateLine(Dot d1, Dot d2)
        {
            Line l = new Line(d1, d2);
        }
    }

    class Dot
    {
         string _name;
         int _x;
         int _y;
        public Dot(string name)
        {
            _name = name[0].ToString(); // Записываем только первую букву
            _x = 0;
            _y = 0;
        }
        public Dot(string name, int x, int y) : this(name[0].ToString())
        {
            _x = x;
            _y = y;
        }
        public void PrintFigure() // выводим в консоль точку
        {
            Console.WriteLine("Точка {0}({1},{2})", _name, _x, _y);
        }
        public string Coordinates() // возвращаем только координаты
        {
            return "(" + _x + "," + _y + ")";
        }
        public int Return_X()
        {
            return _x;
        }
        public int Return_Y()
        {
            return _y;
        }
        public string Return_Name()
        {
            return _name;
        }
    }
    class Line
    {
        Dot _dot_x;
        Dot _dot_y;
        string _name;
        double _lenght;

        public Line(Dot dot_x, Dot dot_y)
        {
            _dot_x = dot_x;
            _dot_y = dot_y;
            _name = dot_x.Return_Name() + dot_y.Return_Name(); // имя линии - имена точек
            _lenght = Math.Sqrt(Math.Pow((_dot_y.Return_X() - _dot_x.Return_X()),2)+Math.Pow((_dot_y.Return_Y() - _dot_x.Return_Y()),2));
            // рассчёт длины линии
        }

        public void PrintFigure()
        {
            Console.WriteLine("Линия {0}({1},{2})", _name, _dot_x.Coordinates(), _dot_y.Coordinates());// выводим линию с координатами точек
        }

        public void LineLenght()
        {
            Console.WriteLine("Длина линии {0} = {1}", _name, Return_Lenght()); // выводим длину линии
        }

        public double Return_Lenght()
        {
            return _lenght;
        }
    }

}
