using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalcV2
{
    public class CalculateRoom
    {
        // function for getting user input, takes the message which is shown to the user as an arguement
        static private float GetUserInput(string promptmsg)
        {
            float numberinput = 0;
            string userin;
            bool getinput = true;

            while (getinput == true)
            {
                Console.WriteLine(promptmsg);
                userin = Console.ReadLine();
                bool inputcheck = float.TryParse(userin, out numberinput);

                if (inputcheck == false)
                {
                    Console.WriteLine("Please enter a number");
                }
                else
                {
                    getinput = false;
                }
            }
            return numberinput;
        }

        // function that calculates the amount of paint required for all of the walls
        static public float CalcWallPaint(List<float> wallsize, float wallheight)
        {
            float totalwallarea = 0;           
            
            for (int i = 0; i < wallsize.Count; i++)
            {
                totalwallarea += wallsize[i] * wallheight;
            }
            return totalwallarea * 2;
        }

        // calculates the room volume
        static private float calcRoomVolume(List<float> wallsize, float wallheight)
        {
            float roomvolume = (wallsize[0] * wallsize[1] * wallheight);
            return roomvolume;
        }

        static void Main(string[] args)
        {
            float area, walllength, requiredpaint, coats = 1, volume, wallheight;

            // value to hold all of the walls.
            List<float> wallsize = new List<float>();

            // get dimensions from user
            walllength = GetUserInput("Enter the length of the room");
            wallsize.Add(walllength);
            walllength = GetUserInput("Enter the width of the room");
            wallsize.Add(walllength);
            wallheight = GetUserInput("Enter the wall height");

            area = wallsize[0] * wallsize[1];
            Console.WriteLine("The area of the room is: " + area + " metres squared");

            volume = calcRoomVolume(wallsize, wallheight);
            Console.WriteLine("The volume of the room is: " + volume + " metres cubed");

            requiredpaint = CalcWallPaint(wallsize, wallheight);
            coats = GetUserInput("Enter the number of coats");

            // calculate paint usage by getting the required paint from the calculatewallpaint function and then 
            // dividing it by the recommended metres per litre.
            Console.WriteLine("The required amount of paint for this room is " + requiredpaint + " square metres or " + Math.Round((requiredpaint / 14) * coats, 2) + " litres for " + coats + " coats");
            Console.ReadKey();
        }
    }
}
