using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalcV2
{
    class Program
    {
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

        static private float CalcWallPaint(List<float> wallsize)
        {
            float wallheight = 0, totalwallarea = 0;

            wallheight = GetUserInput("Enter the wall height");
            
            for (int i = 0; i < wallsize.Count; i++)
            {
                totalwallarea += wallsize[i] * wallheight;
            }
            return totalwallarea * 2;
        }

        static private float calcRoomVolume(List<float> wallsize, int wallheight)
        {
            float roomvolume = (wallsize[0] * wallsize[1] * wallheight);
            return roomvolume;
        }

        static void Main(string[] args)
        {
            float area, walllength, requiredpaint;
            List<float> wallsize = new List<float>();

            walllength = GetUserInput("Enter the length of the room");
            wallsize.Add(walllength);
            walllength = GetUserInput("Enter the width of the room");
            wallsize.Add(walllength);

            area = wallsize[0] * wallsize[1];
            Console.WriteLine("The area of the room is: " + area + " metres squared");

            requiredpaint = CalcWallPaint(wallsize);
            Console.WriteLine("The required amount of paint for this room is " + requiredpaint + " square metres or " + (requiredpaint / 14) + " litres");
            Console.ReadKey();
        }
    }
}
