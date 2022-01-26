using System;
using System.Collections.Generic;
using System.Text;
using EpamClassLibrary;

namespace GameTask
{
    public class GameFunctional
    {
        List<Tree> tree = new List<Tree>();
        public void CreateTrees()
        {
            Console.WriteLine("Введите координаты точек");
            int x = Numbers.Read_Int("x:");
            int y = Numbers.Read_Int("y:");
            Cell c = new Cell(x, y);
            Console.WriteLine("Введите имя дерева, например Дерево или Олег");
            Tree t = new Tree(Console.ReadLine(), c);
            tree.Add(t);
        }
    }

    public struct Cell
    {
        internal int _x { get; set; }
        internal int _y { get; set; }
        public Cell(int x, int y)
        {
            _x = x;
            _y = y;
        }
        internal string Coordinates()
        {
            return $"({_x}, {_y})";
        }
        internal void Set_X(int x) => _x = x;
        internal void Set_Y(int y) => _y = y;
        internal void Set_XY(int x, int y)
        {
            _x = x;
            _y = y;
        }

    }
    public abstract class GameObject
    {
        protected string _name;
        protected Cell _cell;

        protected GameObject(string name, Cell cell)
        {
            _name = name;
            _cell = cell;
        }

        internal abstract void SayMyName();
        internal abstract void WhereItIs();
    }
    class Player : GameObject
    {
        private int _health { get; set; } // жизни
        private int _maxHealth { get; set; } // максимальное хп
        private int _regeneration { get; set; } // количество единиц регенерации
        private int _step // шаг
        {
            get
            {
                return _step;
            }
            set
            {
                _step = value;
                if (_step < 1)
                    _step = 1;
            }
        } 

        public Player(string name, Cell cell) : base(name, cell)
        {
            _maxHealth = 10;
            _health = _maxHealth;
            _regeneration = 1;
            _step = 1;
        }

        internal override void SayMyName()
        {
            Console.WriteLine("Имя: {0}; ХП {1}/{2};", _name, _health, _maxHealth);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }
        internal void Regeneration()
        {
            if (_health < _maxHealth) _health += _regeneration;
            if (_health > _maxHealth) _health = _maxHealth;
        }
        // upValue - значение, на которое повышается поле
        internal void ChangeRegen(int changeValue) => _regeneration += changeValue;
        internal void ChangeHealth(int changeValue)
        {
            if (_health < _maxHealth) _health += changeValue;
            if (_health > _maxHealth) _health = _maxHealth;
        }
        internal void ChangeMaxHP(int changeValue) => _maxHealth += changeValue;
        internal void ChangeStep(int changeValue)
        {
            if (_step + changeValue > 0)
            {
                _step += changeValue;
            }
        }
        internal int GoStepX(bool upStep, List<Tree> t)
        {
            for (int i = 0; i < t.Count; i++)
            {
                if (_cell._x + _step != t[i].ThisDot()._x || _cell._x - _step != t[i].ThisDot()._x) 
                    // Если Х + или - шаг не равен точке какого-нибудь дерева, то шагаем
                {
                    if(upStep) _cell._x += _step;
                    else _cell._x -= _step;
                }
            }
            return _cell._x;
        }
        internal int GoStepY(bool upStep, List<Tree> t)
        {
            for (int i = 0; i < t.Count; i++)
            {
                if (_cell._y + _step != t[i].ThisDot()._y || _cell._y - _step != t[i].ThisDot()._y)
                // Если Х + или - шаг не равен точке какого-нибудь дерева, то шагаем
                {
                    if (upStep) _cell._y += _step;
                    else _cell._y -= _step;
                }
            }
            return _cell._y;
        }
    }

    #region [bonuses]
    public abstract class Bonus : GameObject
    {
        protected Bonus(string name, Cell cell) : base(name, cell) { }
        internal abstract void AssignBonus(Player player);
    }

    class Apple : Bonus // hp++
    {

        public Apple(string name, Cell cell) : base(name, cell)
        {

        }

        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }

        internal override void AssignBonus(Player player)
        {
            player.ChangeHealth(2);
        }
    }
    class Pear : Bonus // hpMax++
    {

        public Pear(string name, Cell cell) : base(name, cell)
        {

        }

        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }

        internal override void AssignBonus(Player player)
        {
            player.ChangeMaxHP(5);
        }
    }
    class Banana : Bonus // regen++
    {

        public Banana(string name, Cell cell) : base(name, cell)
        {

        }

        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }

        internal override void AssignBonus(Player player)
        {
            player.ChangeRegen(1);
        }
    }
    class Salt : Bonus // step++
    {

        public Salt(string name, Cell cell) : base(name, cell)
        {

        }

        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }

        internal override void AssignBonus(Player player)
        {
            player.ChangeStep(1);
        }
    }
    #endregion

    #region [monsters]
    public abstract class Monster : GameObject
    {
        protected Monster(string name, Cell cell) : base(name, cell) { }
        internal abstract void NegativeImpact(Player player);
    }

    class Slime : Monster 
    {
        public Slime(string name, Cell cell) : base(name, cell)
        {

        }
        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }
        internal override void NegativeImpact(Player player)
        {
            player.ChangeHealth(-1);
        }
    }
    class Spider : Monster
    {
        public Spider(string name, Cell cell) : base(name, cell)
        {

        }
        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }
        internal override void NegativeImpact(Player player)
        {
            player.ChangeHealth(-1);
            player.ChangeRegen(-1);
        }
    }
    class Zombie : Monster
    {
        public Zombie(string name, Cell cell) : base(name, cell)
        {

        }
        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }
        internal override void NegativeImpact(Player player)
        {
            player.ChangeHealth(-5);
        }
    }
    class Snake : Monster
    {
        public Snake(string name, Cell cell) : base(name, cell)
        {

        }
        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }
        internal override void NegativeImpact(Player player)
        {
            player.ChangeMaxHP(-2);
            player.ChangeHealth(0);
        }
    }
    class HypnotizingFrog : Monster
    {
        public HypnotizingFrog(string name, Cell cell) : base(name, cell)
        {

        }
        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }
        internal override void NegativeImpact(Player player)
        {
            player.ChangeStep(-1);
        }
    }
    #endregion

    #region [obstacke]
    public abstract class Obstacle : GameObject
    {
        protected Obstacle(string name, Cell cell) : base(name, cell) { }
    }

    public class Tree : Obstacle
    {
        public Tree(string name, Cell cell) : base(name, cell)
        {

        }
        internal override void SayMyName()
        {
            Console.WriteLine(_name);
        }
        internal override void WhereItIs()
        {
            Console.WriteLine(_cell.Coordinates());
        }

        public Cell ThisDot() => _cell;
        
    }
    #endregion
}
