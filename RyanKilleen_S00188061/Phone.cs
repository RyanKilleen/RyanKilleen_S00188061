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
    }
     public class phoneData : DbContext
    {
        public phoneData() : base("PhonePriceData"){ }

        public DbSet<Phone> phones { get; set; }
    }
     


    public void IncreasePrice(double Price, long previousValue, long currentValue)
    {
        var trend = "10%";

        if(previousValue < currentValue)
        {
            if(previousValue != 0)
            {
                var difference = previousValue - currentValue;
                var pctIncrease = (double)(difference / previousValue) * 100;
                trend = pctIncrease.ToString("P");
            }
            else
            {
                trend = currentValue.ToString("P");
            }

            return trend;

        }
    }
}
