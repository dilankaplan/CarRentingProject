using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult (T Data,string message):base(Data,true,message)
        {

        }

        public SuccessDataResult(T data):base(data,true)
        { 
        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult() : base(default,true)
        {

        }
        
    }
}
