using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights
{
    class Program
    {
        public static int[] flightNumbers = { 201, 321, 510, 633 };
        public static String[] airportCode = { "AUS", "CRP", "DFW", "HOU" };
        public static String[] airportName = { "Austin", "Corpus Cristi", "Dallas Fort Worth", "Houston" };
        public static int[] time = { 0710, 0830, 0915, 1140 };
       
        
        
        public static String flightNum = "Flight Number: ";
        public static String airportCodeString = "Airport Code: ";
        public static String airportNameString = "Airport Name: ";
        public static String timeString = "Time: ";

        static void Main(string[] args)
        {

            Console.WriteLine("Enter either flight Number or Airport code: "); 
            String code = Console.ReadLine();
            int num;

            if (int.TryParse(code, out num))
            {
                
                GetFlightInfo(num); 
            }
            else
            {
                

                GetFlightInfo(code);
            }














        }

        public static void GetFlightInfo(String airportCode)
        {

             



            switch (airportCode)
            {
                case "AUS":
                    Console.WriteLine(flightNum + flightNumbers[0] + "\n"  + airportNameString + airportName[0] + "\n" + timeString + time[0]);
                    Console.ReadLine();
                    break;
                case "CRP":
                    Console.WriteLine(flightNum + flightNumbers[1] +  "\n" + airportNameString + airportName[1] + "\n" + timeString + time[1]);
                    Console.ReadLine();
                    break;
                case "DFW":
                    Console.WriteLine(flightNum + flightNumbers[2] + "\n"  + airportNameString + airportName[2] + "\n" + timeString + time[2]);
                    Console.ReadLine();
                    break;
                case "HOU":
                    Console.WriteLine(flightNum + flightNumbers[3] + "\n"  + airportNameString + airportName[3] + "\n" + timeString + time[3]);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Flight not found");
                    Console.ReadLine();
                    break;



            }




        }
        
        public static void GetFlightInfo(int flightNumber)
        {
            switch (flightNumber)
            {
                case 201:
                    Console.WriteLine( airportCodeString + airportCode[0] + "\n" + airportNameString + airportName[0] + "\n" + timeString + time[0]);
                    Console.ReadLine();
                    break;
                case 321:
                    Console.WriteLine(airportCodeString + airportCode[1] + "\n" + airportNameString + airportName[1] + "\n" + timeString + time[1]);
                    Console.ReadLine();
                    break;
                case 510:
                    Console.WriteLine(airportCodeString + airportCode[2] + "\n" + airportNameString + airportName[2] + "\n" + timeString + time[2]);
                    Console.ReadLine();
                    break;
                case 633:
                    Console.WriteLine(airportCodeString + airportCode[3] + "\n" + airportNameString + airportName[3] + "\n" + timeString + time[3]);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Flight not found");
                    Console.ReadLine();
                    break;






            }





        }


    }
    
    }
   

