using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_ch2
{
   [Serializable]
   public class UserCollection<T> : IEnumerable<T>,IEnumerator<T> ,IDisposable
    {
        /*
         * If it need I can realize this program by using 
         * Arrays (element[]) without using collection. 
         * When arrays add new item I will copy this arr to new with size+1...
         */
        private List<T> userColection = new List<T>();
        int position = 0;
        public T this[int index] 
        {
            get { return userColection[index];  }
            set { userColection[index] = value; }
        }
       /// <summary>
       /// Add element to collection
       /// </summary>
       /// <param name="t">element to add</param>
        public void Add(T t) 
        {
            userColection.Add(t);
            
        }
       /// <summary>
       /// return size of user collection
       /// </summary>
       /// <returns>size of collection</returns>
        public int Capacity() 
        {
            return userColection.Capacity;
        }
       /// <summary>
        /// This method is Clear userColection
       /// </summary>
        public void Clear() 
        {
            this.userColection = new List<T>();
        }
       /// <summary>
        ///Check collection if she contains item return true
       /// </summary>
       /// <param name="item">checking items </param>
       /// <returns>true/false if collections conteins item or not</returns>
        public bool Contains(T item)
        {
            return userColection.Contains(item);
        }
       /// <summary>
       /// copy to new array
       /// </summary>
       /// <param name="list">list to copy</param>
       /// <param name="elementFrom">elemet from what start copy</param>
        public void CopyTo(T[] list, int elementFrom) 
        {
            userColection.CopyTo(list, elementFrom);
        }
       /// <summary>
        /// remove item from collection
       /// </summary>
       /// <param name="item">item to remove</param>
       /// <returns>result of operation true/false</returns>
        public bool Remove(T item) 
        {
            return userColection.Remove(item);
        }
       /// <summary>
       /// Look for item in colection
       /// </summary>
       /// <param name="item">item to find</param>
       /// <returns>index of item</returns>
       public int IndexOf(T item)
       {
           return userColection.IndexOf(item);
       }
       /// <summary>
       /// Insert element in same position in collection
       /// </summary>
       /// <param name="index">index of element</param>
       /// <param name="value">new element</param>
       public void Insert(int index , T value) 
       {
           userColection.Insert(index,value);
       }
       /// <summary>
       /// Remove element from colection by index
       /// </summary>
       /// <param name="index">index of element ot delet</param>
       /// <returns>result of operation</returns>
       public bool RemoveAt(int index)
       {
           if (index < 0) return false;
           if (userColection.Capacity >= index) { userColection.RemoveAt(index); return true; }
           return false;
       }
       /// <summary>
       /// For printing elements with ','-> is split
       /// </summary>
       /// <returns>String with all items from colection</returns>
       public string ToStringElement() 
       {
           string str = "[ ";
           for (int i = 0; i < userColection.Count; i++) 
           {
               str += ",";
               str += userColection[i];
              
           }
           str += "]";
           return str;

       }

        //IEnumerator 1
        public bool MoveNext()
        {
            if (position < userColection.Count-1) 
            {
                position++;
                return true;
            }else
            return false;
        }
        //get position before/ previous position
        public bool MoveBack() 
        {
            if (position > 0)
            {
                position--;
                return true;
            }
            else
                return false;

        }
        //IEnumerator 2
        public void Reset()
        {
            position = 0;
        }
        //IEnumerator 3
        public T Current
        {
            get { return userColection[position]; }
        }
        //IEnumerable 1
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        //IDisposable
        public void Dispose()
        {
            ((IEnumerator)this).Reset();
        }
        //&&&
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this;
        }

        object System.Collections.IEnumerator.Current
        {
            get { return userColection[position]; }
        }

       
    }
}
