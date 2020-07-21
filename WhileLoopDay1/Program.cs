using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WhileLoopDay1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declar our bool and start loop

            bool bContinue = true;
            while (bContinue)
            {
                //grabbing the input for length. Declare and store it.
                Console.WriteLine("Please input the length of the room in feet.");
                string input = Console.ReadLine();
                double length = double.Parse(input);

                //same as above but for width
                Console.WriteLine("Please input the width of the room in feet.");
                string input2 = Console.ReadLine();
                double width = double.Parse(input2);

                //doing the math 
                double area = length * width;
                double perimeter = length * 2 + width * 2;

                //output info to the user
                Console.WriteLine("The area of your room is " + area + " and the perimeter of your room is " + perimeter);

                //give the user the choice
                Console.WriteLine("Woudl you like to do another room? y/n");
                string input3 = Console.ReadLine();
                input3 = input3.ToLower();
                char[] charArray = input3.ToCharArray();

                if (input3 == "yes")
                {
                    bContinue = true;
                }
                else if (input3 == "no")
                {
                    bContinue = false;
                }
            } 
                
        }
    }
}
