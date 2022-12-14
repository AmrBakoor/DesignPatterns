using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractProducts;

namespace TemplateMethod.ConcreteProducts
{
    public class IntBubbleSorter : BubbleSorter
    {
        private int[] array = null;

        public int Sort(int [] theArray)
        {
            array = theArray;
            length = array.Length;
            return DoSort();
        }
        protected override bool OutOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }

        protected override void Swap(int index)
        {
            var temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
