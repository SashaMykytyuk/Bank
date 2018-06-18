using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    static class RemoveNULL<T>
    {
        public static ICollection<T> DelNull(ICollection<T> _collections)
        {
            return _collections.Where(i => i != null).ToList();
        }
    }
}
