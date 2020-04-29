using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>  // DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
               new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
                   new Category(){Name="Elektronik",Description="Elektronik Ürünleri"},
                       new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                           new Category(){Name="Beyaz Eşya",Description="Beyaz Eşya Ürünleri"}
            };

            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="Apple Iphone 6",Description=" en ucuz apple",Price=1200,Stock=100,IsApproved=true,CategoryId=4,IsHome=true,Image="telefon.jpeg"},
               new Product(){Name="intel i5",Description="elektronik ürünler",Price=1500,Stock=50,IsApproved=true,CategoryId=2,IsHome=true,Image="elektronik.jpeg"},
                   new Product(){Name="Casper",Description=".. Ürünleri",Price=1111,Stock=122,IsApproved=false,CategoryId=3,Image="bilgisayar.jpeg"},
                       new Product(){Name="Canon",Description="en net kamera",Price=2223,Stock=665,IsApproved=true,CategoryId=1,IsHome=true,Image="kamera.jpeg"},
                           new Product(){Name="Profilo",Description="beyaz esya Ürünleri",Price=3546,Stock=34,IsApproved=true,CategoryId=5,IsHome=true,Image="beyazesya.jpeg"}
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}