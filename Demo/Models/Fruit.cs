using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Fruit
    {
         public Fruit() { }
        public Fruit(int id, string fname, string image, double price )
        {
            Id = id;
            F_Name = fname;
            Image = image;
            Price = price;
           
        }
        [Key]
        public int Id { get; set; }
        public string F_Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        
    }
}
    