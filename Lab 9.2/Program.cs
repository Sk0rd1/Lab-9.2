using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong result;
            int lightSpeed = 299792;/* km/c */
            int hour = 60 * 60;
            int day = hour * 24;

            result = (ulong)lightSpeed * (ulong) hour;
            Console.WriteLine("Hour: " + result + " km.");
            result = (ulong)lightSpeed * (ulong)day;
            Console.WriteLine("Day: " + result + " km.");
            Console.ReadKey();
        }
    }
}
