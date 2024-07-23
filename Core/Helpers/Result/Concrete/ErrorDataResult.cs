﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Result.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string message , T data) : base(data,false,message)
        {
            
        }
        public ErrorDataResult() : base(default, false)
        {
            
        }
    }
}
