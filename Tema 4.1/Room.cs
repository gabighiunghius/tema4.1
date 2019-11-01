using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1
{
    class Room
    {


//        Room
//- Name
//- Rate
//- Adults
//- Children
//- Method: GetPriceForDays(int numberOfDays)
//- Print() - Display all fields for the class

        public string Name { get; set; }

        public int Rate { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }




        public int getpricefordays(int numberofdays)
        {
            int sum;
            sum = numberofdays * Rate;
            return sum;
        }

        public string FullDescription
        {
            get { return $"Name:{Name}, Rate:{Rate}, Adults:{Adults}, Children:{Children}, Price for days: "; }
        }

        




    }
}
