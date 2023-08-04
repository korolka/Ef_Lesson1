//Завдання 2
//Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
//Потрібно: Інсталюйте необхідні пакети для роботи з Entity Framework
//Створіть контекст бази даних MyDatabaseContext та, використовуючи матеріали завдання 1 (цього уроку),
//перенесіть ваш список у якості колекції DbSet, виконайте міграцію Заповніть таким самим способом,
//що і в першому завдані, через контекст MyDatabaseContext вашу колекцію тими самими значеннями.
//Переконайтесь, що дані збереглись у базу. Знайти та вивести > 1, 5, 0, 7 з Product/User/Order (ваш варінт) контексту за ім’ям
using EFLesson1;
namespace EF_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            {
                products.Add(new Product()
                {
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
                    Name = "Iphone 13",
                    Cost = 40000,
                    Description = "The iPhone 13 has a 6.1-inch screen," +
                    " and the iPhone 13 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 3000
                });
                products.Add(new Product()
                {
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
                    Name = "Iphone 11",
                    Cost = 25000,
                    Description = "The iPhone 13 has a 6.1-inch screen," +
                    " and the iPhone 11 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 1000
                });

                products.Add(new Product()
                {
                    Name = "Iphone 15",
                    Cost = 100000,
                    Description = "The iPhone 15 has a 6.1-inch screen," +
                    " and the iPhone 13 mini has a 5.4-inch screen. They both use Apple's Ceramic Shield cover glass, which adds improved drop " +
                    "protection. The Super Retina XDR display is 28% brighter up to 800 nits for regular content 1200 nits for HDR",
                    Quantity = 50
                });
                products.Add(new Product()
                {
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
                    Name = "MacBook Pro 14",
                    Cost = 60000,
                    Description = "The 14-inch MacBook Pro fits between Apple's entry laptop and high-end pro models. " +
                    "It is the last Apple computer with the Touch Bar and retains the old Intel design. Active cooling and" +
                    " a thicker chassis give this laptop a performance advantage over the M2 MacBook Air, despite using the same processor.",
                    Quantity = 700
                });
            }
            using (DatabaseContext context = new DatabaseContext())
            {

                context.Products.AddRange(products);
                context.SaveChanges();
                Console.WriteLine("Values saves");

                var listByName = from product in products
                                 where product.Name == "Iphone 12" || product.Name == "Iphone 10"
                                 || product.Name == "Iphone 13" || product.Name == "Iphone 15"
                                 select product;

                foreach (var product in listByName)
                {
                    Console.WriteLine(product.Name);
                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}