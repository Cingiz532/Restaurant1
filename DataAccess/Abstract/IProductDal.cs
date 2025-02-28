﻿using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IBaseRepository<Product>
    {
    }
}
