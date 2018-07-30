namespace Demo.Migrations
{
    using Demo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Drawing.Imaging;
    internal sealed class Configuration : DbMigrationsConfiguration<Demo.Models.DtpDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo.Models.DtpDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.FruitTable.AddOrUpdate(
                p => p.F_Name,
                new Fruit(1, "Apple", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\apple.jpg"), 450.00),
                new Fruit(2, "Orange", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\orange.jpg"), 555.00),
                new Fruit(3, "Mango", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\mango3.jpg"), 250.50),
                new Fruit(4, "Painapple", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\painapple.jpg"), 600.00),
                new Fruit(5, "Sapodilla", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\sapodilla.jpg"), 150.00),
                new Fruit(6, "Banana", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\banana.jpg"), 170.00),
                new Fruit(7, "White Grapes", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\whitegrapes.jpg"), 230.00),
                new Fruit(8, "Black Grapes", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\blackgrapes.jpg"), 340.00),
                new Fruit(9, "Cherries", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\cherries.jpg"), 720.00),
                new Fruit(10, "Pomegranate", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\pomegrante.jpg"), 410.00),
                new Fruit(11, "Papaya", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\papaya.jpg"), 640.00),
                new Fruit(12, "Water milon", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\watermilan.jpg"), 590.00),
                new Fruit(13, "Guava", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\guava.jpg"), 390.00),
                new Fruit(14, "Black berries", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\blackberry.jpg"), 840.00),
                new Fruit(15, "Charentais melon", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\charentaismelon.jpg"), 479.00),
                new Fruit(16, "Kivi fruit", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\kiwi.jpg"), 755.00),
                new Fruit(17, "white honeydew melon", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\whitehoneydewmelon.jpg"), 275.00),
                new Fruit(18, "Cucumber", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\cucumber.jpg"), 55.00),
                new Fruit(19, "Lion dates", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\dates.jpg"), 1030.00),
                new Fruit(20, "Plum", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\plum.jpg"), 960.00),
                new Fruit(21, "Lemon", Imagetobase.GetBase64StringForImage(@"C:\Users\sudhakarl\Downloads\lemon.jpg"), 90.00)

                    );

        }
    }
}
