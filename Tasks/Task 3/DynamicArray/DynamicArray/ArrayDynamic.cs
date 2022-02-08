using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicArray
{
    public class ArrayDynamic<T>
    {
        private T[] arr;
        public int lenght { get; private set; } //получение количества элементов. Не путать с ёмкостью (Capacity).
        public int capacity { get; private set; } //получение ёмкости: длины внутреннего массива.
        public ArrayDynamic()
        {
            arr = new T[8];
        }
        public ArrayDynamic(int lenght)
        {
            arr = new T[lenght];
        }

        protected void Add(T item)
        {

        }

        protected void AddRange()
        {

        }

        protected bool Remove(int index)
        {
            return true;
        }

        protected bool Insert(int index, T item)
        {

            return true;
        }
    }
}
