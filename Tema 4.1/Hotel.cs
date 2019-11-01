using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1
{
    class Hotel
    {
//        Hotel
//- Name
//- City
//- List of Rooms
//- GetPriceForNumberOfRooms(int numberOfRooms)
//- Print() - Display all fields for the class

        public string Name { get; set; }
        public string City { get; set; }
                    

        public List<Room> Rooms { get; set; } = new List<Room>();


        public int getpricefornumberofrooms(int numberofrooms)
        {
            int price;

            price = numberofrooms * Rate.Amount;
            return price;

        }
        public void Print()
        {
            Console.WriteLine($"Hotel: {this.Name}, from: {this.City}, Rooms available:");
            foreach (var room in Rooms)
            {
                Console.WriteLine(room.Name);
            }

        }
    }
}
