using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The time at the first camera (in the form HH:MM:SS): ");
            string time1 = Console.ReadLine();

            int hrs1 = Convert.ToInt32(time1[0]);
            int hrs12 = Convert.ToInt32(time1[1]);
            int hrs1t = int.Parse(hrs1.ToString() + hrs12.ToString());

            int min1 = Convert.ToInt32(time1[3]);
            int min12 = Convert.ToInt32(time1[4]);
            int min1t = int.Parse(min1.ToString() + min12.ToString());

            int sec1 = Convert.ToInt32(time1[6]);
            int sec12 = Convert.ToInt32(time1[7]);
            int sec1t = int.Parse(sec1.ToString() + sec12.ToString());

            TimeSpan a = new TimeSpan(hrs1t, min1t, sec1t);
            Console.Write("Enter the time at the second camera (in the same form): ");
            string time2 = Console.ReadLine();

            int hrs2 = Convert.ToInt32(time2[0]);
            int hrs22 = Convert.ToInt32(time2[1]);
            int hrs2t = int.Parse(hrs2.ToString() + hrs22.ToString());

            int min2 = Convert.ToInt32(time2[3]);
            int min22 = Convert.ToInt32(time2[4]);
            int min2t = int.Parse(min2.ToString() + min22.ToString());

            int sec2 = Convert.ToInt32(time2[6]);
            int sec22 = Convert.ToInt32(time2[7]);
            int sec2t = int.Parse(sec2.ToString() + sec22.ToString());

            TimeSpan b = new TimeSpan(hrs2t, min2t, sec2t);
            TimeSpan dif = b.Subtract(a);
            float difs = (float)dif.TotalHours;
            float Speed = 1 / difs;
            Console.WriteLine("The average speed is: " + Speed + "m/h.");

            Console.ReadKey();
        }
    }
}
