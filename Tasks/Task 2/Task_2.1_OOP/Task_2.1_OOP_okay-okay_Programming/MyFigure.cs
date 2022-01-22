using System;
using System.Collections.Generic;
using System.Text;
using EpamClassLibrary;

namespace Task_2._1_OOP_okay_okay_Programming
{
    public class MyFigure
    {
        List<Figure> figures = new List<Figure>();

        public void ShowListFigure<T>() //Показать все фигуры
        {
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i] is T)
                {
                    Console.Write("№{0} - ", i + 1);
                    figures[i].PrintFigure();
                }
            }
        }
        public Dot CreateDot() // Создать точку
        {
            Console.WriteLine("Введите имя точки");
            string name = Console.ReadLine();
            int x = Numbers.Read_Int("Введите Х точки");
            int y = Numbers.Read_Int("Введите Y точки");
            Dot d = new Dot(name, x, y);
            d.PrintFigure(); 
            figures.Add(d); // Добавляем точку в список
            return d;
        }

        public void LineTypeCheck() // Создать линию
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine(" 1 - Содать новую линию; 2 - Создать линию из существующих точек");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1": // Создание линии из двух новых точек
                    {
                        CreateLine();
                        break;
                    }
                case "2": // Создание линии из существующих точек
                    {
                        ShowListFigure<Dot>(); // Выводим на экран только точки
                        CreateLine(
                            NumberFigure<Dot>("Введите номер первой точки") as Dot, 
                            NumberFigure<Dot>("Введите номер второй точки") as Dot);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неверный вариант!");
                        Console.WriteLine();
                        break;
                    }
            }
        }

        private Figure NumberFigure<T>( string message ) // Метод проверки типа фигуры
        {
            int num = 0;
            do
            {
                num = Numbers.Read_Int(message) - 1;
            }
            while (figures[num].GetType() != typeof(T));
            return figures[num];
        }
        private void CreateLine() // Сохдание линии из новых точек
        {
            Console.WriteLine("Для создания линии необходимо две точки:");
            Dot d1 = CreateDot();
            Dot d2 = CreateDot();
            Line l = new Line(d1, d2);
            l.PrintFigure();
            figures.Add(l);

        }
        private void CreateLine(Dot d1, Dot d2) // Создание линии из существующих точек
        {
            Line l = new Line(d1, d2);
            l.PrintFigure();
            figures.Add(l);
        }
    }

    public abstract class Figure // фигуры слева направо
    {
        internal abstract void PrintFigure();
        internal abstract void ShowSpecifications();
    }

    public class Dot : Figure
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
        internal override void PrintFigure() // выводим в консоль точку
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

        internal override void ShowSpecifications() { } // Метод пустышка
    }
    public class Line : Figure
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

        internal override void PrintFigure() // Выводит линию
        {
            Console.WriteLine("Линия {0}({1},{2})", _name, _dot_x.Coordinates(), _dot_y.Coordinates());// выводим линию с координатами точек
        }

        internal override void ShowSpecifications() // Выводит характеристики линии
        {
            Console.WriteLine("     Длина линии {0} = {1}", _name, Return_Lenght()); // выводим длину линии
        }

        public double Return_Lenght()
        {
            return _lenght;
        }
    }

}
