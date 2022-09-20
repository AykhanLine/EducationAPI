using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper.Results.Concrete.ErrorResults
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult() : base(default, true)
        {

        }
        public ErrorDataResult(T data) : base(data, true)
        {

        }
        public ErrorDataResult(string message) : base(default, true, message)
        {

        }
        public ErrorDataResult(T data, string message) : base(data, true, message)
        {

        }
    }
}
