
//Завдання 1
//Розробіть консольну програму з використанням одного списку з типом (List< ваш вибір >) одного з варіантів.

//1. Магазин – Product
//1) +Id: Guid
//2) +Name: string
//3) +Cost: double
//4) +Description: string
//5) +Quantity: int

//Заповніть ваш список значеннями (10 значень).
//Виведіть на екран значення за індексом > 1, 5, 0, 7
//Знайдіть та виведіть індекси > 1, 5 за властивістю Id
//Знайдіть та виведіть індекси > 0, 7 за властивістю Name
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace EFLesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            {
                products.Add(new Product()
                {
                    Id = 1,
                    Name = "Iphone 12",
                    Cost = 35000,
                    Description = "Apple iPhone 12 is" +
                    " the bigger version of the regular iPhone 12 mini. The handset's hardware include a 6.1-inch OLED display," +
                    " 5nm Apple A14 Bionic processor, and a dual-camera setup with a large sensor. 5G and Face ID are on board, too." +
                    " The Apple iPhone 12 starting price is $829.\r\n",
                    Quantity = 1000
                });
                products.Add(new Product()
                {
                    Id = 2,
                    Name = "Iphone 13",
                    Cost = 40000,
                    Description = "The iPhone 13 has a 6.1-inch screen," +
                    " and the iPhone 13 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 1000
                });

                products.Add(new Product()
                {
                    Id = 3,
                    Name = "Iphone 13",
                    Cost = 40000,
                    Description = "The iPhone 13 has a 6.1-inch screen," +
                    " and the iPhone 13 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 3000
                });
                products.Add(new Product()
                {
                    Id = 4,
                    Name = "Iphone 14",
                    Cost = 50000,
                    Description = "The iPhone 14 and iPhone 14 Plus are smartphones designed, developed, and marketed by Apple Inc." +
                    " They are the sixteenth and latest generation of iPhones, succeeding the iPhone 13 and iPhone 13 Mini," +
                    " and were announced during Apple Event, Apple Park in Cupertino, California, on September 7, 2022," +
                    " alongside the higher-priced iPhone 14 Pro and iPhone 14 Pro Max flagships. ",
                    Quantity = 500
                });

                products.Add(new Product()
                {
                    Id = 5,
                    Name = "MacBook Pro 13",
                    Cost = 60000,
                    Description = "The 13-inch MacBook Pro fits between Apple's entry laptop and high-end pro models. " +
                    "It is the last Apple computer with the Touch Bar and retains the old Intel design. Active cooling and" +
                    " a thicker chassis give this laptop a performance advantage over the M2 MacBook Air, despite using the same processor.",
                    Quantity = 700
                });
                //----------------------------------------------------------

                products.Add(new Product()
                {
                    Id = 6,
                    Name = "Iphone 10",
                    Cost = 10000,
                    Description = "Apple iPhone 10 is" +
                    " the bigger version of the regular iPhone 12 mini. The handset's hardware include a 6.1-inch OLED display," +
                    " 5nm Apple A14 Bionic processor, and a dual-camera setup with a large sensor. 5G and Face ID are on board, too." +
                    " The Apple iPhone 10 starting price is $829.\r\n",
                    Quantity = 10000
                });
                products.Add(new Product()
                {
                    Id = 7,
                    Name = "Iphone 11",
                    Cost = 25000,
                    Description = "The iPhone 13 has a 6.1-inch screen," +
                    " and the iPhone 11 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 1000
                });

                products.Add(new Product()
                {
                    Id = 8,
                    Name = "Iphone 15",
                    Cost = 100000,
                    Description = "The iPhone 15 has a 6.1-inch screen," +
                    " and the iPhone 13 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 50
                });
                products.Add(new Product()
                {
                    Id = 9,
                    Name = "Iphone 6s",
                    Cost = 50000,
                    Description = "The iPhone 6s and iPhone 6s Plus are smartphones designed, developed, and marketed by Apple Inc." +
                    " They are the sixteenth and latest generation of iPhones, succeeding the iPhone 6 and iPhone 6 Mini," +
                    " and were announced during Apple Event, Apple Park in Cupertino, California, on September 7, 2022," +
                    " alongside the higher-priced iPhone 14 Pro and iPhone 6s Pro Max flagships. ",
                    Quantity = 500
                });

                products.Add(new Product()
                {
                    Id = 10,
                    Name = "MacBook Pro 14",
                    Cost = 60000,
                    Description = "The 14-inch MacBook Pro fits between Apple's entry laptop and high-end pro models. " +
                    "It is the last Apple computer with the Touch Bar and retains the old Intel design. Active cooling and" +
                    " a thicker chassis give this laptop a performance advantage over the M2 MacBook Air, despite using the same processor.",
                    Quantity = 700
                });
            }//add products to list


            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"Product id - {product.Id},\n name - {product.Name},\n cost - {product.Cost},\n" +
            //        $" description - {product.Description},\n quontity - {product.Quantity}");
            //    Console.WriteLine(new string('-', 50));
            //}


            Console.WriteLine($"Product id - {products[1].Id},\n name - {products[1].Name},\n cost - {products[1].Cost},\n" +
                $" description - {products[1].Description},\n quontity - {products[1].Quantity}");
            Console.WriteLine(new string('-', 50));


            Console.WriteLine($"Product id - {products[5].Id},\n name - {products[5].Name},\n cost - {products[5].Cost},\n" +
                $" description - {products[5].Description},\n quontity - {products[5].Quantity}");
            Console.WriteLine(new string('-', 50));


            Console.WriteLine($"Product id - {products[0].Id},\n name - {products[0].Name},\n cost - {products[0].Cost},\n" +
                $" description - {products[0].Description},\n quontity - {products[0].Quantity}");
            Console.WriteLine(new string('-', 50));


            Console.WriteLine($"Product id - {products[7].Id},\n name - {products[7].Name},\n cost - {products[7].Cost},\n" +
                $" description - {products[7].Description},\n quontity - {products[7].Quantity}");
            Console.WriteLine(new string('-', 50));


            var list = from product in products
                       where product.Id == 1 || product.Id == 6
                       select product;

            foreach (Product product1 in list)
            {
                Console.WriteLine("Search by id: ");
                Console.WriteLine($"Product id - {product1.Id},\n name - {product1.Name},\n cost - {product1.Cost},\n" +
                    $" description - {product1.Description},\n quontity - {product1.Quantity}");
                Console.WriteLine(new string('-', 50));
            }

            var list2 = from product in products
                        where product.Name == "Iphone 15" || product.Name == "Iphone 12"
                        select product;

            foreach (Product product2 in list2)
            {
                Console.WriteLine("Search by name: ");
                Console.WriteLine($"Product id - {product2.Id},\n name - {product2.Name},\n cost - {product2.Cost},\n" +
                    $" description - {product2.Description},\n quontity - {product2.Quantity}");
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}