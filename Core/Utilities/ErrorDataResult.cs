using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorDataResult<T> :DataResult<T>
    {
        public ErrorDataResult(T Data, bool success, string message) : base(Data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, true)
        {
        }

        public ErrorDataResult(string message) : base(default, true, message)
        {

        }
        public ErrorDataResult() : base(default, true)
        {

        }
    }
}
