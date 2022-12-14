namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "kalem",
                UnitPrice = 35
            };

            //PascalCase //CamelCase
            //CaseSensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int,double,bool... değer tip
            //diziler,class,abstract class,interface... referans tip

            productManager.Topla2(3, 6);

            Console.ReadLine();


        }
    }
}