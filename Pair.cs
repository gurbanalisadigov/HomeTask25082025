using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask24082025
{
    internal class Pair<T,U>
    {
        public Pair<T, U>[] arr = new Pair<T, U>[0];
        public T Key { get; set; }
        public U Value { get; set; }

        public Pair()
        {
            
        }
        public Pair(T key,U value)
        {
            Key = key;
            Value = value;


        }

       

        public U this[T key]
        {
            get
            {
                foreach (var pair in arr)
                {
                    if (pair.Key.Equals(key))
                    {
                        return pair.Value;
                    }
                }
                return default(U);
            }
            
            
        }
        

        public void Add(Pair<T, U> pair)
        {
            foreach (var key in arr)
            {
                if (key.Key.Equals(pair.Key))
                    return;   
            }
            
            Pair<T, U>[] newArr = new Pair<T, U>[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
              newArr[i] = arr[i];
            }
             newArr[arr.Length] = pair; 
             arr = newArr;
            
           
        }
      

    }
}
