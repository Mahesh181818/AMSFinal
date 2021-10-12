using System;
using System.Collections.Generic;
using System.Text;

namespace AMS_Repository
{
    public interface Igeneric<T> where T : class
    {
        IEnumerable<T> getall();

        T getbyid(object UID);
        T insertrecord(T data);
        T updaterecord(T data);
        void deletecustomer(int UID);

    }
}
