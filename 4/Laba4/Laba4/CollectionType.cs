using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class CollectionType<T> : IList<T>
    {
       // public delegate string Str(CollectionType<T> t);
        private T[] _contents = new T[8];
        public static int numOfCol =1;
        private int _count;
        public readonly int id;

        public  CollectionType()
        {
            id = numOfCol;
            numOfCol++;
            _count = 0;
        }

        // IList Members
        public void Add(T value)
        {
            if (_count < _contents.Length)
            {
                _contents[_count] = value;
                _count++;
            }
        }


        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(T value)
        {
            bool inList = false;
            for (int i = 0; i < Count; i++)
            {
                if (_contents[i].Equals(value))
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public int IndexOf(T value)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (_contents[i].Equals(value))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, T value)
        {
            if ((_count + 1 <= _contents.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _contents[i] = _contents[i - 1];
                }
                _contents[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(T value)
        {
            RemoveAt(IndexOf(value));
            return true;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _contents[i] = _contents[i + 1];
                }
                _count--;
            }
        }

        public T this[int index]
        {
            get
            {
                return _contents[index];
            }
            set
            {
                _contents[index] = value;
            }
        }

        // ICollection Members

        public void CopyTo(T[] array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_contents[i], j);
                j++;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        // Return the current instance since the underlying store is not
        // publicly available.
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }

        // IEnumerable Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }



        public void PrintContents()
        {
            Console.WriteLine("List has a capacity of {0} and currently has {1} elements.", _contents.Length, _count);
            Console.Write("List contents:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(" {0}", _contents[i]);
            }
            Console.WriteLine();
        }
        public void WriteTofile(string path)
        {
            StreamWriter F = new StreamWriter(path);
            try
            {
                int _count = _contents.Count();
                F.WriteLine("Information about your Collection_type object"); // инф-ия об объекте этой коллекции
                for (int i = 0; i < _count; i++)
                    F.WriteLine(_contents[i].ToString());
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine("File isn't found because of " + exc.Message);
            }
            catch (FieldAccessException exc)
            {
                Console.WriteLine("There wasn't access to the file because of " + exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Unknown exception: " + exc.Message);
            }
            finally
            {
                Console.WriteLine("Filing information about your Collection_type object is finished");
                if (F != null) // если исключения не возникли
                { F.Close(); }
            }          
        }
        public override string ToString()
        {
            string str="";
            for (int i = 0; i < this.Count(); i++)
            {
                str += (i+1) + ". " + this[i];
            }
                return str;
        }


    }
}
