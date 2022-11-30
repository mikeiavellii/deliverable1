using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool getContinue = true;
            while (getContinue)
            {
                Console.WriteLine("Hi there and welcome to Harry's Hoagie Hero House and Haberdashery. \n \nMy name is Know What's in your Food Bot #386, but you can call me Harry Herbert the Hairy Habadasher III, Esquire. \nI didn't catch your name.\n");
                string name = Console.ReadLine();
                Console.WriteLine("\nWell " + name + ", due to Page 87, Section 6, Subsection 28, paragraph E, Line 28 of the New World Order Decree set by our \noverlords at the Grand Circus, praise be onto them, we are required by law to inform you of the number of each \ningredient in your sandwich so you can make an informed nutritional decision. This is so that the tragedy of our \nbeloved King Jacob never befalls anyone in our community ever again. In order to ensure that, I need to know how many \nheroes will be having a hoagie here today? Please note we only have Peanut Butter and Jelly Hoagies today.\n");
                int People = int.Parse(Console.ReadLine());

                if (People > 0)
                {
                    Console.WriteLine("\nThank you, I am processing your results. I should have them to you momentarily.\n");
                    /*
                    Abbreviation Key
                     ________________________________________________
                    |                                               |
                    | SpL   =  Slices per loaf                      |
                    | PBpJ  =  Tablespoons of Peanut Butter per Jar |
                    | JpJ   =  Teaspoons of Jelly per Jar           |
                    | TLN   =  Total Loaves Needed                  |
                    | TJPN  =  Total Jars of Peanut Butter Needed   |
                    | TJJN  =  Total Jars of Jelly Needed           |
                    |_______________________________________________|
                    A sandwich consists of 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly;
                    So one sandwich equates to:*/

                    double Slices = People * 2;
                    double TofP = People * 2;
                    double TofJ = People * 4;

                    const double SpL = 28;
                    const double PpJ = 32;
                    const double JpJ = 48;

                    double TLN = Slices / SpL;
                    double TJPN = TofP / PpJ;
                    double TJJN = TofJ / JpJ;

                    Console.WriteLine("3\n\n2\n\n1\n\n");
                    Console.WriteLine("Your party would be consuming " + People + " PB&J Hero Hoagies or:\n" + Slices + " slices of bread \n" + TofP + " tablespoons of peanut butter \n" + TofJ + " teaspoons of jelly");
                    Console.WriteLine("\n \nThis equates to:\n" + Math.Ceiling(TLN) + " loaves of bread \n" + Math.Ceiling(TJPN) + " jars of peanut butter\n" + Math.Ceiling(TJJN) + " jars of jelly");

                }
                else if (People <= 0)
                {
                    Console.WriteLine("\nThis is a place for heroes to have their hoagies. Only villianous scum like you would turn down a Hero hoagie. \nPrepare for you and your villianous party to be eradicated. \n\nGoodbye!");
                }
                Console.WriteLine("\n\nJudging by the look on your face, it appears as though you've stated the wrong number of people \nin your party. It is an easy mistake to make, especially with small human brains\nWould you like to try again?");

                string userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "yes" || userResponse.ToLower() == "y")
                {
                    Console.WriteLine();
                    getContinue = true;
                }
                else
                {
                    Console.WriteLine("This line is for customers only. So either submit and order, buy some fantastic mens accessories, or get out. \nFailure to comply will result in you and your party being turned into Know What's in your Food Bots. \nYou have 10 seconds to comply.\nGOODBYE!\n");
                    getContinue = false;
                    break;
                }
            }

        }
    }
}