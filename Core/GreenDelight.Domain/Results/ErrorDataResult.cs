using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data, bool succes) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(message)
        {

        }
    }
}
