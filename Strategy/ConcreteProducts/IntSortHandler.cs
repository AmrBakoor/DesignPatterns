using Strategy.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteProducts
{
    /// <summary>
    /// Detailed Implementation that depends on abstraction
    /// </summary>
    public class IntSortHandler : ISortHandler
    {
        private int[] array = null;

        public int Length()
        {
            return array.Length;
        }

        public bool OutOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }

        public void SetArray(object array)
        {
            this.array = (int[])array;
        }

        public void Swap(int index)
        {
            var temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
