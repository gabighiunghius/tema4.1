using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1
{
    class Rate
    {

        public int Amount { get; set; }

        public  string Currency { get; set; }
       

        public void Print()
        {
            System.Console.WriteLine($"Amount: {this.Amount}, Currency: {this.Currency}");

            System.Console.WriteLine();
        }
    }
}
