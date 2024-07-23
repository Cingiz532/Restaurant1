using Business.Abstract;
using Core.Helpers.Result.Abstract;
using Core.Helpers.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager(IProductDal productDal) : IProductManager
    {
        private readonly IProductDal _productDal = productDal;
        public IResult Add(Product product)
        {
            if (product.ProductPrice >= 25 && product.ProductName.Length > 3)
            {
                _productDal.Add(product);
                return new SuccessResult("Məhsul uğurla əlavə olundu...");
            }
            else
            {
                return new ErrorResult("Vacib olaraq məhsulun şərtlərini ödəməlisiniz...");
            }
        }
        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get()
        {
            return _productDal.Get(p => p.Id == 3);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public IDataResult<List<Product>> GetAll()
        {
            List<Product> products = _productDal.GetAll(p => p.IsDeleted == false);
            if (products.Count > 5)
            {
                return new SuccessDataResult<List<Product>>("Məhsulların siyahısı uğurla hazırlandı... ", products);
            }
            else
            {
                return new ErrorDataResult<List<Product>>("Zəhmət olmasa məhsul şərtlərini ödəyin...", products);
            }
        }
    }
}
