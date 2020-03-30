using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Studii_de_caz
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstScene();
            SecondScene();
            Console.ReadKey();
        }
        

        static void FirstScene()
        {
            using (var context = new ProductContext())
            {
                var product = new Product();
                while (true)
                {
                    Console.WriteLine("Do you want to save a product? (1/0)");
                    string a = Console.ReadLine();
                    if (a.Contains("1"))
                    {
                        Console.WriteLine("Enter SKU");
                        product.SKU = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Description");
                        product.Description = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        product.Price = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter ImageURL");
                        product.ImageURL = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
            using (var context = new ProductContext())
            {
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }

        }


        static void SecondScene()
        {
            using (var context = new SceneFourContext())
{
                Console.WriteLine("Do you want to save a business? (1/0)");
                string ans = Console.ReadLine();
                if (ans.Contains("y"))
                {
                    var business = new Business();
                    Console.WriteLine("Enter name");
                    business.Name = Console.ReadLine();
                    Console.WriteLine("Enter License Number");
                    business.LicenseNumber = Console.ReadLine();
                    context.Businesses.Add(business);
                    var retail = new Retail();
                    Console.WriteLine("Enter retail name");
                    retail.Name = Console.ReadLine();
                    Console.WriteLine("Enter retail License Number");
                    retail.LicenseNumber = Console.ReadLine();
                    Console.WriteLine("Enter retail address");
                    retail.Address = Console.ReadLine();
                    Console.WriteLine("Enter retail city");
                    retail.City = Console.ReadLine();
                    Console.WriteLine("Enter retail state");
                    retail.State = Console.ReadLine();
                    Console.WriteLine("Enter retail ZIPCode");
                    retail.ZIPCode = Console.ReadLine();
                    context.Businesses.Add(retail);
                    var web = new eCommerce();
                    Console.WriteLine("Enter eCommerce name");
                    web.Name = Console.ReadLine();
                    Console.WriteLine("Enter eCommerce License Number");
                    web.LicenseNumber = Console.ReadLine();
                    Console.WriteLine("Enter eCommerce URL");
                    web.URL = Console.ReadLine();
                    context.Businesses.Add(web);
                    context.SaveChanges();
                }
            }
            using (var context = new SceneFourContext())
{
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }
    }
}
