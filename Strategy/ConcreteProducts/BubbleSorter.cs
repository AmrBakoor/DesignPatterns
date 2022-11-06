using Strategy.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteProducts
{
    /// <summary>
    /// Concrete class that contains the generic algorithm and denpends on abstrction
    /// </summary>
    public class BubbleSorter
    {
        private int operations = 0;
        private int length = 0;
        private ISortHandler _iSortHandler = null;

        public BubbleSorter(ISortHandler iSortHandler)
        {
            _iSortHandler = iSortHandler;
        }

        /// <summary>
        /// Bubble Sort Generic Algoritm
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Sort(object array)
        {
            _iSortHandler.SetArray(array);
            length = _iSortHandler.Length();

            operations = 0;
            if (length <= 1)
                return operations;
            for (int nextToLast = length - 2; nextToLast >= 0; nextToLast--)
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (_iSortHandler.OutOfOrder(index))
                        _iSortHandler.Swap(index);
                    operations++;
                }

            return operations;
        }
        
    }
}
