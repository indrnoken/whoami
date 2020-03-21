using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_praktikum3
{
    class Program
    {
        static void Main(string[] args)
        {

            taxi taxi1 = new taxi();

            taxi1.Drivername = "Zoro";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 10;


            taxi1.TaxiInfo();
            taxi1.dropofpassenger();
            taxi1.pickuppassenger();

            Console.ReadKey();
        }
    }
}
