using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.AbstractProducts
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public interface ISortHandler
    {
        bool OutOfOrder(int index);
        void Swap(int index);
        int Length();
        void SetArray(object array);
    }
}
