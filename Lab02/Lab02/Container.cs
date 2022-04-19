using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Container
    {
        Product[] data;

        public int Count
        {
            get
            {
                return data != null ? data.Length : 0;
            }
        }

        public void Add(Product p)
        {
            Product[] newData = new Product[Count + 1];
            for(int i = 0; i < Count; i++)
                newData[i] = data[i];
            newData[Count] = p;
            data = newData;
        }
        public Product this[int i] 
        {
            get { return data[i]; } 
            set { data[i] = value; } 
        }
    }
}