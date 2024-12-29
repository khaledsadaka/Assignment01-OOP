using System.ComponentModel;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" 

            /*

            foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(days.ToString());
            }

            */

            #endregion


            #region 2-Create an Enum called "Season"

            /*

            Console.Write("Enter Season ");
            string input = Console.ReadLine();
            Season season;

            if (Enum.TryParse(input, true, out season))
            {
                switch(season)
                {
                    case Season.spring:
                        Console.WriteLine("spring march to may ");
                        break;

                    case Season.summer:
                        Console.WriteLine("summer june to august ");
                        break;

                    case Season.autumn:
                        Console.WriteLine("autumn September to November  ");
                        break;

                    case Season.winter:
                        Console.WriteLine("winter December to February");
                        break;

                }

            }

            */

            #endregion


            #region 3-Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum




            #endregion


            #region 4-Create an Enum called "Colors" 

            /*

            Console.Write("Enter a Color ");
            string input = Console.ReadLine();

            Colors color;

            if (Enum.TryParse(input, true, out color))
            {
                Console.WriteLine($" {color} is a primary color ");
            }
            else
            {
                Console.WriteLine($" {input} is not primary color ");
            }

            */

            #endregion
        }
    }
}
