using System;
using System.Collections.Generic;
using System.Text;

namespace LPU_Common
{
    public interface IRepo<T>
    {
        
            //CRUD
            //C-Create
            //R-Read
            //U-Update
            //D-Delete
            public List<T> ShowAll();
            public T ShowDetailsByID(int id);
            public bool AddDetails(T obj);
            public bool UpdateDetails(int id, T obj);
            public bool DeleteDetails(int id);
    }
}
