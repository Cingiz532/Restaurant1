using Core.Helpers.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        IResult Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        IDataResult<List<Product>> GetAll();
        Product Get();
    }
}
