using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Hotel> Hotels = new List<Hotel>();



            Room a = new Room();
            a.Name = "Andrei";
            a.Adults = 2;
            a.Children = 3;
            a.Rate = 50;

            Console.WriteLine(a.FullDescription);


            Room c = new Room();
            c.Name = "Costel";
            c.Adults = 1;
            c.Children = 1;

            Hotel b = new Hotel();
            b.Name = "Unirii";
            b.City = "Iasi";

            Hotel d = new Hotel();
            d.Name = "remus";
            d.City = "Vs";

            Rate e = new Rate();
            e.Amount = 50;
            e.Currency = "£";

            //-Find a room with a price lower than some value.

          







        }
    }
}
