using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            //Listar todos
            /*var query = from p in context.Products
                        select p;*/

            //Listar elementos con categoria Beverages
            /*var query = from p in context.Products
                        where p.Categories.CategoryName == "Beverages"
                        select p;*/

            //Listar elementos con precio menor a 2'
            /*var query = from p in context.Products
                        where p.UnitPrice < 20
                        select p;*/

            //Listar elementos que contengan la palabra queso
            /*var query = from p in context.Products
                        where p.ProductName.Contains("queso")
                        select p;
             foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }*/

            //Listar elementos cuya presentación sean paquetes pkg o pkgs
            /*var query = from p in context.Products
                        where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Presentación={2}", prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            }*/

            //Listar elementos que empiezan con la letra A
            /*var query = from p in context.Products
                        where p.ProductName.Substring(0,1) == "A"
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("Name={0} \t Precio={1}", prod.ProductName, prod.UnitPrice);
            }*/

            //Listar elementos sin stock
            /*var query = from p in context.Products
                        where p.UnitsInStock == 0
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }*/

            //Listar elementos descontinuados
            /*var query = from p in context.Products
                        where p.Discontinued == true
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }*/

            //Insertar registro producto
            /*Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;

            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();*/

            //Insertar registro categoría
            /*Categories c = new Categories();
            c.CategoryName = "New Category";
            c.Description = "This is a new category";

            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();*/

            //Modificar elemento
            /*var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;
            context.SubmitChanges();*/

            //Eliminar elemento
            /*var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();*/

            //Listar elementos pertenecientes a la categoria Dairy Products
            /*var query = from p in context.Products
                        where p.CategoryID == 4
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Proveedor={2}", prod.ProductID, prod.ProductName, prod.Suppliers.CompanyName);
            }*/

            //Listar elementos con proveedor ubicado en USA
            var query = from p in context.Products
                        where p.Suppliers.Country == "USA"
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Proveedor={2} \t País del proveedor={3}", prod.ProductID, prod.ProductName, prod.Suppliers.CompanyName, prod.Suppliers.Country);
            }

            Console.ReadKey();
        }
    }
}
