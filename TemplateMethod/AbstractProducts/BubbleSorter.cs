using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.AbstractProducts
{
    /// <summary>
    /// Abstract base class contains the generic code, as well as the abstract methods
    /// </summary>
    public abstract class BubbleSorter
    {
        private int operations = 0;
        protected int length = 0;


        /// <summary>
        /// Bubble Sort Generic Algorithm 
        /// </summary>
        /// <returns></returns>
        protected int DoSort()
        {
            operations = 0;
            if (length <= 1)
                return operations;
            for (int nextToLast = length-2; nextToLast >= 0; nextToLast --)
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (OutOfOrder(index))
                        Swap(index);
                    operations++;
                }

            return operations;
        }

        protected abstract bool OutOfOrder(int index);
        protected abstract void Swap(int index);
    }
}
