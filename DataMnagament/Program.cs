using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RyanKilleen_S00188061;

namespace DataMnagament
{
    class Program
    {
        static void Main(string[] args)
        {
            phoneData db = new phoneData();

            using (db)
            {

                Phone p1 = new Phone("Samsung S20", 500, "Android", "/Phone Images/android.png", "/Phone Images/ s20.jpg");
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/Phone Images/apple.png", "/Phone Images/iphone11.png");

                db.phones.Add(p1);
                db.phones.Add(p2);

                Console.WriteLine("Added Phones to Database");

                db.SaveChanges();

            }

        }
    }
}
