using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool s, string msg) : base(s, msg)
        {
            Data = data;
        }
        public DataResult(T data, bool s) : base(s)
        {
            Data = data;
        }

    }
}
