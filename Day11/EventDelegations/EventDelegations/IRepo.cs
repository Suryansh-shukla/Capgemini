using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegations
{
    public interface IRepo<T> where T : Product
    {
    }
}
