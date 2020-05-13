using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RyanKilleen_S00188061
{
    public class Phone
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public String OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        public int ID { get; set; }

        public virtual List<Phone> Phones { get; set; }

        public Phone(string name, double price, string operatingSystem, string oS_image, string phone_image)
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = oS_image;
            Phone_Image = phone_image;
        }

        public void IncreasePrice(double price)
        {
            Price += price * (1.1);
        }

    }
     public class phoneData : DbContext
    {
        public phoneData() : base("PhonePriceData"){ }

        public DbSet<Phone> phones { get; set; }
    }
     


   
}
