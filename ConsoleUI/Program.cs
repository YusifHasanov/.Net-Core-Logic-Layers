using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

public class Program
{
    public static void Main(string[] arg)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        /* foreach (var product in productManager.GetProductDetails()) 
         {
             Console.WriteLine(product.ProductName + "/" + product.CategoryName);
         }*/

        Console.WriteLine(categoryManager.GetById(5).CategoryName); 
        

    }
}