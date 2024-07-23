using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;

ProductManager productManager = new ProductManager(new ProductDal());
Product product = new Product();
product.ProductName = "Aş N1";
product.ProductDescription = "Azərbaycan mətbəxi";
product.ProductCount = 9;
product.ProductPrice = 100;
/*productManager.Add(product);*/

/*var adds = productManager.Add(product);
Console.WriteLine(adds.Message);*/
/*var alls = productManager.GetAll();
Console.WriteLine(alls.Message);*/
/*foreach (var item in alls)
{

}

if (product.Id == 7)
{
    productManager.Delete(product);
}
*/

/*var y = productManager.Get();
Console.WriteLine($"{y.ProductName} - gətirildi")*/;