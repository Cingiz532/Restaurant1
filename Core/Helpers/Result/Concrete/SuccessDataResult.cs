﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Result.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(string message , T data) : base(data,true,message)
        {
            
        }
        public SuccessDataResult(T data) : base(data,true)
        {
            
        }
    }
}
