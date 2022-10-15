



using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

public class Program
{
    public static void Main(string[] arg)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.Get()) 
        {
            Console.WriteLine(product.ProductName);
        }

    }
}