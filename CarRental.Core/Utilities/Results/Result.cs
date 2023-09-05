using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool s, string msg) : this(s)
        {
            Message = msg;
        }
        public Result(bool s)
        {
            Success = s;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
