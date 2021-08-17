using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houthandel
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameters
            int classs;
            double length;
            double height;
            double depth;
            DateTime delivery;
            DateTime receive;
            double cost = 0;
            double m3;
            double m2;
            double date;
            double discount = 0;
            //data
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the the delivery date.");
                    delivery = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Please enter the the receive date.");
                    receive = Convert.ToDateTime(Console.ReadLine());
                    date = (receive - delivery).TotalDays;
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid. Please try again.");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the number of the class you wish to use (1,2 or 3)");
                    classs = Convert.ToInt32(Console.ReadLine());
                    if (classs > 0 && classs < 4)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid. Please try again.");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the length.");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the height.");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the depth.");
                    depth = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid. Please try again.");
                }
            }
            //math
            m3 = length * height * depth;
            m2 = length * height;
            if (classs == 1){cost = m3 * 300;}
            else if(classs == 2){cost = m3 * 500;}
            else if(classs == 3){cost = m3 * 450;}
            cost = cost + (m2 * 0.6);
            if (date >= 14 && date < 21)
            {
                discount = 1;
            }
            else if (date >= 21 && date < 28)
            {
                discount = 2;
            }
            else if (date > 28)
            {
                discount = 2.5;
            }
            cost = cost - (cost / 100 * discount);
            Console.WriteLine("The total cost is: " + cost);
        }
    }
    // klasse 1: 300 euro per m3
    // klasse 2: 500 euro per m3
    // klasse 3: 450 euro per m3

    // schaafloon: 0,60 euro per m2
    // geen schaafloon als houtkosten >= 200

    // korting afhankelijk van levertijd
        // 14 tot 21 dagen: 1% korting
        // 21 tot 28 dagen: 2% korting
        // 28 of meer dagen: 2,5% korting

    // verschuldigde bedrag
    // levertijd in dagen
        // met leverdatum en besteldatum
            // besteldatum en leverdatum in hetzelfde jaar
        // maanden van 30 dagen
}
