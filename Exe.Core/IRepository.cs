using System;
using System.Collections.Generic;
using System.Text;

namespace Exe.Core
{
    public interface IRepository<T> where T:class
    {
        bool Add(T item);
    }
}
