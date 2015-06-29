using System;
using System.Collections;
using System.Linq;

namespace GenericList
{
    public class GenericList<T> : IEnumerable
        where T : IComparable 
    {
        #region Fields

        private const int DefaultCapacity = 16;

        private T[] elements;
        private int capacity;
        private int count;

        #endregion

        #region Constructors

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Elements = new T[capacity];
            this.Capacity = capacity;
            this.Count = 0;
        }

        #endregion

        #region Properties

        public T[] Elements
        {
            get { return this.elements; }
            protected set { this.elements = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The capacity should be positive.");
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public int Count
        {
            get { return this.count; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The count should be positive.");
                }
                else
                {
                    this.count = value;
                }
            }
        }

        #endregion

        #region Methods

        public void Add(T elementToAdd)
        {
            if (this.Count >= this.Capacity)
            {
                this.Resize();
            }
            this.Elements[this.Count] = elementToAdd;
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("The index must be non-negative and less than the count of the list.");
            }

            for (int i = index; i < this.Count; i++)
            {
                this.Elements[i] = this.Elements[i + 1];
            }
            this.Elements[this.Count - 1] = default(T);
            this.Count--;
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("The index must be non-negative and less than the count of the list.");
            }

            if (this.Count >= this.Capacity)
            {
                this.Resize();
            }

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.Elements[i + 1] = this.Elements[i];
            }
            this.Elements[index] = element;
            this.Count++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.Elements[i] = default(T);
            }
            this.Count = 0;
        }

        public int Find(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(this.Elements[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            return Find(element) != -1;
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return string.Join(", ", this.Elements.Take(this.Count));
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.Elements[i];
            }
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            T minValue = this.Elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (minValue.CompareTo(this.Elements[i]) > 0)
                {
                    minValue = this.Elements[i];
                }
            }
            return minValue;
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            T maxValue = this.Elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (maxValue.CompareTo(this.Elements[i]) < 0)
                {
                    maxValue = this.Elements[i];
                }
            }
            return maxValue;
        }

        private void Resize()
        {
            T[] resizedElements = new T[this.Capacity * 2];
            this.Capacity *= 2;
            for (int i = 0; i < this.Count; i++)
            {
                resizedElements[i] = this.Elements[i];
            }
            this.Elements = resizedElements;
        }

        #endregion

        #region Operators

        public T this[int index]
        {
            get { return this.Elements[index]; }
            set { this.Elements[index] = value; }
        }

        #endregion
    }
}
