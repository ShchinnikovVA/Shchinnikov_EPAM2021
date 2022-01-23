using System;
using System.Collections.Generic;
using System.Text;
using EpamClassLibrary;

namespace Task_2._1_OOP_okay_okay_Programming
{
    public class MyFigure
    {
        List<Figure> figures = new List<Figure>();

        public void ShowListFigure<T>(bool showSpecifications) //Показать все фигуры
        {
            if (figures.Count > 0)
            {
                for (int i = 0; i < figures.Count; i++)
                {
                    if (figures[i] is T)
                    {
                        Console.WriteLine("-----------------");
                        Console.Write("№{0} - ", i + 1);
                        figures[i].PrintFigure();
                    }
                    if (showSpecifications)
                    {
                        figures[i].ShowSpecifications();
                    }
                }
                Console.WriteLine("-----------------");
            }
            else
            {
                Console.WriteLine("Список фигур пуст!");
            }
        }
        public void RemoveFigures()
        {
            //figures.RemoveAll(typeof(Figure));
        }
        public Dot CreateDot() // Создать точку
        {
            string name;
            do
            {
                Console.WriteLine("Введите имя точки");
                name = Console.ReadLine();
            }
            while (name == "");
            int x = Numbers.Read_Int("Введите Х точки");
            int y = Numbers.Read_Int("Введите Y точки");
            Dot d = new Dot(name, x, y);
            Console.WriteLine();
            d.PrintFigure(); 
            figures.Add(d); // Добавляем точку в список
            return d;
        }

        public void CreateLine() // Создать линию
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine(" 1 - Содать новую линию; 2 - Создать линию из существующих точек");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1": // Создание линии из двух новых точек
                    {
                        AddendumLine();
                        break;
                    }
                case "2": // Создание линии из существующих точек
                    {
                        ShowListFigure<Dot>(false); // Выводим на экран только точки
                        AddendumLine(
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

        internal Figure NumberFigure<T>( string message ) // Метод проверки типа фигуры
        {
            int num = 0;
            do
            {
                num = Numbers.Read_Int(message) - 1;
            }
            while (figures[num].GetType() != typeof(T));
            return figures[num];
        }
        private void AddendumLine() // Создание линии из новых точек
        {
            Console.WriteLine("Для создания линии необходимо две точки:");
            Dot d1 = CreateDot();
            Dot d2 = CreateDot();
            Line l = new Line(d1, d2);
            Console.WriteLine();
            l.PrintFigure();
            figures.Add(l);
        }
        private void AddendumLine(Dot d1, Dot d2) // Создание линии из существующих точек
        {
            Line l = new Line(d1, d2);
            Console.WriteLine();
            l.PrintFigure();
            figures.Add(l);
        }
        public void CreateTriangle()
        {
            Console.WriteLine("Для создания линии необходимо три вершины:");
            Dot d1 = CreateDot();
            Console.WriteLine("Вторая вершина:");
            Dot d2 = CreateDot();
            Console.WriteLine("Третья вершина:");
            Dot d3 = CreateDot();
            Triangle t = new Triangle(d1, d2, d3);
            Console.WriteLine();
            t.PrintFigure();
            figures.Add(t);
        }
        public void CreateSquare()
        {
            Console.WriteLine("Введите имя квадрата");
            string name = Console.ReadLine();
            int a = Numbers.Read_Int("Введите длину его стороны");
            Square s = new Square(name, a);
            Console.WriteLine();
            s.PrintFigure();
            figures.Add(s);
        }
        public void CreateRectangle()
        {
            Console.WriteLine("Введите имя прямоугольника");
            string name = Console.ReadLine();
            int a = Numbers.Read_Int("Введите длину его первой стороны");
            int b = Numbers.Read_Int("Введите длину его второй стороны");
            Rectangle r = new Rectangle(name, a, b);
            Console.WriteLine();
            r.PrintFigure();
            figures.Add(r);
        }
        public void CreateRound()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine(" 1 - создать круг в новой точке; 2 - создать круг в существующей точке");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1": // Создание круга из новой точки
                    {
                        AddendumRound(CreateDot(), Numbers.Read_Int("Введите длину радиуса"));
                        break;
                    }
                case "2": // Создание круга из существующей точки
                    {
                        ShowListFigure<Dot>(false); // Выводим на экран только точки
                        AddendumRound(
                            NumberFigure<Dot>("Введите номер центральной точки") as Dot, 
                            Numbers.Read_Int("Введите длину радиуса"));
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
     
        private Round AddendumRound(Dot center, int radius)
        {
            Round r = new Round(center, radius);
            Console.WriteLine();
            r.PrintFigure();
            figures.Add(r);
            return r;
        }
        public void CreateRing()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine(" 1 - создать внешний круг в новой точке; 2 - создать круг в существующей точке");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1": // Создание круга из новой точки
                    {
                        Dot center = CreateDot(); // создаём центр
                        Round r = AddendumRound(center, Numbers.Read_Int("Введите длину радиуса")); // создаём внешний круг
                        AddendumRing(r, AddendumRound(center, InnerRadiusForRing(r))); // из того же центра создаём второй круг
                        break;
                    }
                case "2": // Создание круга из существующей точки
                    {
                        ShowListFigure<Dot>(false); // Выводим на экран только точки
                        Dot center = NumberFigure<Dot>("Введите номер центральной точки") as Dot; // выбираем точку как центр
                        Round r = AddendumRound(center, Numbers.Read_Int("Введите длину радиуса")); // создаём внешний круг
                        AddendumRing(r, AddendumRound(center, InnerRadiusForRing(r)));// из того же центра создаём второй круг
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
        private void AddendumRing(Round outer_r, Round inner_r) // принимаем внешний и внутренний круги
        {
            Ring ri = new Ring(inner_r, outer_r);
            Console.WriteLine();
            ri.PrintFigure();
            figures.Add(ri);
        }
        private int InnerRadiusForRing(Round r) // считываем внутренний радиус
        {
            int innerRadius = r.Return_Radius() + 1;
            do
            {
                innerRadius = Numbers.Read_Int("Введите внутренний радиус");
            }
            while (innerRadius >= r.Return_Radius()); // он не должен быть больше внешнего радиуса
            return innerRadius;
        }
    }

    public abstract class Figure // фигуры слева направо
    {
        internal abstract void PrintFigure();
        internal abstract void ShowSpecifications();
    }
    public abstract class Shape : Figure // квадратные фигуры
    {
        protected int _a;
        protected Shape(int a)
        {
            _a = a;
        }
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
        public double Vector(Dot endDot)
        {
            return Math.Sqrt(Math.Pow((_x - endDot.Return_X()), 2) + Math.Pow((_y - endDot.Return_Y()), 2));
        }
        public int Return_X() => _x;
        public int Return_Y() => _y;
        public string Return_Name() => _name;
        internal override void ShowSpecifications() { } // Метод пустышка
    }
    public class Line : Figure
    {
        Dot _dot_a;
        Dot _dot_b;
        string _name;
        double _lenght;

        public Line(Dot dot_a, Dot dot_b)
        {
            _dot_a = dot_a;
            _dot_b = dot_b;
            _name = dot_a.Return_Name() + dot_b.Return_Name(); // имя линии - имена точек
            _lenght = Math.Sqrt(Math.Pow((_dot_b.Return_X() - _dot_a.Return_X()),2)+Math.Pow((_dot_b.Return_Y() - _dot_a.Return_Y()),2));
            // рассчёт длины линии
        }
        internal override void PrintFigure() // Выводит линию
        {
            Console.WriteLine("Линия {0}({1},{2})", _name, _dot_a.Coordinates(), _dot_b.Coordinates());// выводим линию с координатами точек
        }
        internal override void ShowSpecifications() // Выводит характеристики линии
        {
            Console.WriteLine("     Длина линии {0} = {1}", _name, _lenght); // выводим длину линии
        }
        //public double Return_Lenght() => _lenght;
    }
    class Triangle : Figure
    {
        Dot _dot_a;
        Dot _dot_b;
        Dot _dot_c;
        string _name;
        double _area;

        public Triangle(Dot dot_a, Dot dot_b, Dot dot_c)
        {
            _dot_a = dot_a;
            _dot_b = dot_b;
            _dot_c = dot_c;
            _name = dot_a.Return_Name() + dot_b.Return_Name() + dot_c.Return_Name(); // имя из имён точек
            _area = (_dot_a.Vector(_dot_b) + _dot_a.Vector(_dot_c) + _dot_b.Vector(_dot_c)) / 2; 
        }

        internal override void PrintFigure()
        {
            Console.WriteLine("Треугольник {0}({1},{2},{3})", _name, _dot_a.Coordinates(), _dot_b.Coordinates(), _dot_c.Coordinates());
        }
        internal override void ShowSpecifications()
        {
            Console.WriteLine("     Площадь треугольника {0} = {1}", _name, _area);
        }
    }
    class Square : Shape
    {
        string _name;
        int _area;
        int _perimeter;
        public Square(string name, int a) : base(a)
        {
            _name = name; // имя квадрату придётся придумать
            _area = a * a;
            _perimeter = a * 4;
        }

        internal override void PrintFigure()
        {
            Console.WriteLine("Квадрат {0} со стороной равной {1}", _name, _a);
        }
        internal override void ShowSpecifications()
        {
            Console.WriteLine("     Площадь квадрата {0} = {1}", _name, _area);
            Console.WriteLine("     Периметр квадрата {0} = {1}", _name, _perimeter);
        }
    }
    class Rectangle : Shape
    {
        string _name;
        int _b;
        int _area;
        int _perimeter;
        public Rectangle(string name, int a, int b) : base(a)
        {
            _b = b;
            _name = name;
            _area = a * b;
            _perimeter = a * 2 + b * 2;
        }

        internal override void PrintFigure()
        {
            Console.WriteLine("Квадрат {0} со сторонми {1} и {2}", _name, _a, _b);
        }
        internal override void ShowSpecifications()
        {
            Console.WriteLine("     Площадь прямоугльника {0} = {1}", _name, _area);
            Console.WriteLine("     Периметр прямоугльника {0} = {1}", _name, _perimeter);
        }
    }
    public class Round : Figure
    {
        Dot _center;
        int _radius;
        double _area;

        public Round(Dot center, int radius)
        {
            _center = center;
            _radius = radius;
            _area = Math.PI * _radius * _radius;
        }

        internal override void PrintFigure()
        {
            Console.WriteLine("Круг {0}{1}", _center.Return_Name(), _center.Coordinates());
        }
        internal override void ShowSpecifications()
        {
            Console.WriteLine("     Радиус круга {0} = {1}", _center.Return_Name(), _radius);
            Console.WriteLine("     Площадь круга {0} = {1}", _center.Return_Name(), _area);
        }

        public double Return_Area() => _area;
        public Dot Return_Center() => _center;
        public int Return_Radius() => _radius;
    }
    class Ring : Figure
    {
        Round _inner;
        Round _outer;
        double _area;

        public Ring(Round inner, Round outer)
        {
            _inner = inner;
            _outer = outer;
            _area = _outer.Return_Area() - _inner.Return_Area();
        }

        internal override void PrintFigure()
        {
            Console.WriteLine("Кольцо {0}{1}", _outer.Return_Center().Return_Name(), _outer.Return_Center().Coordinates()); 
            // обращаемся к имени и координатам точки внешнего круга
        }
        internal override void ShowSpecifications()
        {
            Console.WriteLine("     Площадь кольца {0} = {1}", _outer.Return_Center().Return_Name(), _area);
            Console.WriteLine("     Радиус внешнего круга = {0}", _outer.Return_Radius());
            Console.WriteLine("     Радиус внутреннего круга = {0}", _inner.Return_Radius());
        }
    }
}
