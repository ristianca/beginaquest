using System;
using System.ComponentModel;
/* Initial*/

Console.WriteLine("what is your name");
string yourname = Console.ReadLine();
Random rdm = new Random();
int luckynumber = rdm.Next(1, 15);
Console.WriteLine(yourname+ " your lucky Number is: " + luckynumber);
int namelength = yourname.Length;
int namecounter = namelength;
int questcounter = 0;
string plaqueline = "";
bool gemfound = false;
bool plaquefound = false;
bool swordfound = false;
bool catfound = false;
bool iteminroom = false;
int roll = luckynumber;
string location = "";
string gemroom = "-";
string plaqueroom = "-";
string swordroom = "-";
string catroom = "-";
int roomgen = 4;
string plaquegraphic = "";
string gemgraphic = "";
string swordgraphic = "";
string catgraphic = "";
//Grapic Generation
//Gem
gemgraphic = "  x    \n xxx   \nxxxxx\n xxx   \n  x     ";
//Plaque
while (namecounter > 0)
{
    plaqueline = plaqueline + "~";
    namecounter--;
}
plaqueline = plaqueline + "~~~~~~";
plaquegraphic = plaqueline + "\n" + "~~~" + yourname + "~~~" + "\n" + plaqueline;
namecounter = namelength;
//Sword 
swordgraphic = ",_._._._._._._._._|__________________________________________________________,\n|_|_|_|_|_|_|_|_|_|_________________________________________________________/\n                  !";
//Cat
catgraphic = "(\"`-''-/\").___..--''\"`-._ ";
catgraphic = catgraphic + "\n `6_ 6  )   `-.  (     ).`-.__.`) ";
catgraphic = catgraphic + "\n (_Y_.)'  ._   )  `._ `. ``-..-' ";
catgraphic = catgraphic + "\n   _..`--'_..-_/  /--'_.'";
catgraphic = catgraphic + "\n  ((((.-''  ((((.'  (((.-' ";

//Room Generation
while (roomgen > 0)
{
    if (roomgen == 4)
    {
        location = "North";
        while (iteminroom == false)
        {
            if (roll >= 0 && roll <= 3)
            {
                if (gemfound == false)
                //Gem is present
                {
                    gemroom = location;
                    iteminroom = true;
                    gemfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 4 && roll <= 7)
            {
                if (plaquefound == false)
                //Plaque is present
                {
                    plaqueroom = location;
                    iteminroom = true;
                    plaquefound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 8 && roll <= 11)
            {
                if (swordfound == false)
                //Sword is present
                {
                    swordroom = location;
                    iteminroom = true;
                    swordfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 12 && roll <= 15)
            {
                if (catfound == false)
                //Cat is present
                {
                    catroom = location;
                    iteminroom = true;
                    catfound = true;
                }

                else
                {
                    roll = roll - 12;
                }
            }
        }
    }
    roomgen--;
    iteminroom = false;

    if (roomgen == 3)
    {
        location = "West";
        while (iteminroom == false)
        {
            if (roll >= 0 && roll <= 3)
            {
                if (gemfound == false)
                //Gem is present
                {
                    gemroom = location;
                    iteminroom = true;
                    gemfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 4 && roll <= 7)
            {
                if (plaquefound == false)
                //Plaque is present
                {
                    plaqueroom = location;
                    iteminroom = true;
                    plaquefound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 8 && roll <= 11)
            {
                if (swordfound == false)
                //Sword is present
                {
                    swordroom = location;
                    iteminroom = true;
                    swordfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 12 && roll <= 15)
            {
                if (catfound == false)
                //Cat is present
                {
                    catroom = location;
                    iteminroom = true;
                    catfound = true;
                }

                else
                {
                    roll = roll - 12;
                }
            }
        }
    }
    roomgen--;
    iteminroom = false;

    if (roomgen == 2)
    {
        location = "East";
        while (iteminroom == false)
        {
            if (roll >= 0 && roll <= 3)
            {
                if (gemfound == false)
                //Gem is present
                {
                    gemroom = location;
                    iteminroom = true;
                    gemfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 4 && roll <= 7)
            {
                if (plaquefound == false)
                //Plaque is present
                {
                    plaqueroom = location;
                    iteminroom = true;
                    plaquefound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 8 && roll <= 11)
            {
                if (swordfound == false)
                //Sword is present
                {
                    swordroom = location;
                    iteminroom = true;
                    swordfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 12 && roll <= 15)
            {
                if (catfound == false)
                //Cat is present
                {
                    catroom = location;
                    iteminroom = true;
                    catfound = true;
                }

                else
                {
                    roll = roll - 12;
                }
            }
        }
    }
    roomgen--;
    iteminroom = false;

    if (roomgen == 1)
    {
        location = "South";
        while (iteminroom == false)
        {
            if (roll >= 0 && roll <= 3)
            {
                if (gemfound == false)
                //Gem is present
                {
                    gemroom = location;
                    iteminroom = true;
                    gemfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 4 && roll <= 7)
            {
                if (plaquefound == false)
                //Plaque is present
                {
                    plaqueroom = location;
                    iteminroom = true;
                    plaquefound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 8 && roll <= 11)
            {
                if (swordfound == false)
                //Sword is present
                {
                    swordroom = location;
                    iteminroom = true;
                    swordfound = true;
                }

                else
                {
                    roll = roll + 4;
                }
            }
            if (roll >= 12 && roll <= 15)
            {
                if (catfound == false)
                //Cat is present
                {
                    catroom = location;
                    iteminroom = true;
                    catfound = true;
                }

                else
                {
                    roll = roll - 12;
                }
            }
        }
    }
    roomgen--;
    iteminroom = false;


}
gemfound = false;
plaquefound=false;
swordfound=false;
catfound=false;
location = "Center";
/*List of options*/

while (questcounter < 4)
{
    Console.WriteLine("What would you like to do? \n1. Look Around\n2. Have you found them?\n3. Change Location\n4. Leave");
    string menuchoice = Console.ReadLine();
    switch (menuchoice)
    {
        //Look Around
        case "1":
            Console.Clear();
            Console.WriteLine("You look around");
            if (location == "Center")
            {
                Console.WriteLine("You see an empty room with doors to the North West East and South");
            }
            if (location == "North")
            {
                Console.WriteLine("You see a door leading back to the Center");
                if (gemroom == "North")
                {
                    Console.WriteLine("You Found The Gem!");
                    gemfound = true;
                    Console.WriteLine(gemgraphic);
                }
                if (plaqueroom == "North")
                {
                    Console.WriteLine("You Found The Plaque!");
                    plaquefound = true;
                    Console.WriteLine(plaquegraphic);
                }
                if (swordroom == "North")
                {
                    Console.WriteLine("You Found The Sword!");
                    swordfound = true;
                    Console.WriteLine(swordgraphic);
                }
                if (catroom == "North")
                {
                    Console.WriteLine("You Found The Cat!");
                    catfound = true;
                    Console.WriteLine(catgraphic);
                }
            }
            if (location == "West")
            {
                Console.WriteLine("You see a door leading back to the Center");
                if (gemroom == "West")
                {
                    Console.WriteLine("You Found The Gem!");
                    gemfound = true;
                    Console.WriteLine(gemgraphic);
                }
                if (plaqueroom == "West")
                {
                    Console.WriteLine("You Found The Plaque!");
                    plaquefound = true;
                    Console.WriteLine(plaquegraphic);
                }
                if (swordroom == "West")
                {
                    Console.WriteLine("You Found The Sword!");
                    swordfound = true;
                    Console.WriteLine(swordgraphic);
                }
                if (catroom == "West")
                {
                    Console.WriteLine("You Found The Cat!");
                    catfound = true;
                    Console.WriteLine(catgraphic);
                }

            }
            if (location == "East")
            {
                Console.WriteLine("You see a door leading back to the Center");
                if (gemroom == "East")
                {
                    Console.WriteLine("You Found The Gem!");
                    gemfound = true;
                    Console.WriteLine(gemgraphic);
                }
                if (plaqueroom == "East")
                {
                    Console.WriteLine("You Found The Plaque!");
                    plaquefound = true;
                    Console.WriteLine(plaquegraphic);
                }
                if (swordroom == "East")
                {
                    Console.WriteLine("You Found The Sword!");
                    swordfound = true;
                    Console.WriteLine(swordgraphic);
                }
                if (catroom == "East")
                {
                    Console.WriteLine("You Found The Cat!");
                    catfound = true;
                    Console.WriteLine(catgraphic);
                }
            }
            if (location == "South")
            {
                Console.WriteLine("You see a door leading back to the Center");
                if (gemroom == "South")
                {
                    Console.WriteLine("You Found The Gem!");
                    gemfound = true;
                    Console.WriteLine(gemgraphic);
                }
                if (plaqueroom == "South")
                {
                    Console.WriteLine("You Found The Plaque!");
                    plaquefound = true;
                    Console.WriteLine(plaquegraphic);
                }
                if (swordroom == "South")
                {
                    Console.WriteLine("You Found The Sword!");
                    swordfound = true;
                    Console.WriteLine(swordgraphic);
                }
                if (catroom == "South")
                {
                    Console.WriteLine("You Found The Cat!");
                    catfound = true;
                    Console.WriteLine(catgraphic);
                }
            }
            break;
        //Check to-do
        case "2":
            Console.Clear();
            Console.WriteLine("You check your to-do list\n\n");
            if (gemfound == true)
            {
                Console.WriteLine("The Gem has been found");
            }
            else
            {
                Console.WriteLine("The Gem has not been found\n");
            }
            if (plaquefound == true)
            {
                Console.WriteLine("The Plaque has been found\n");
            }
            else
            {
                Console.WriteLine("The Plaque has not been found\n");
            }
            if (swordfound == true)
            {
                Console.WriteLine("The Sword has been found\n");
            }
            else
            {
                Console.WriteLine("The Sword has not been found\n");
            }
            if (catfound == true)
            {
                Console.WriteLine("The Cat has been found\n");
            }
            else
            {
                Console.WriteLine("The Cat has not been found\n");
            }
            break;
        //Move location
        case "3":
            Console.Clear();
            Console.WriteLine("Where would you like to go?");

            if (location == "Center")
            {
                Console.WriteLine("1. North");
                Console.WriteLine("2. West");
                Console.WriteLine("3. East");
                Console.WriteLine("4. South");
                Console.WriteLine("5. Nevermind");
                menuchoice = Console.ReadLine();
                switch (menuchoice)
                {
                    case "1":
                        Console.WriteLine("You move to the North room");
                        location = "North";
                        break;
                    case "2":
                        Console.WriteLine("You move to the West room");
                        location = "West";
                        break;
                    case "3":
                        Console.WriteLine("You move to the East room");
                        location = "East";
                        break;
                    case "4":
                        Console.WriteLine("You move to the South room");
                        location = "South";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("1. Back to center room");
                Console.WriteLine("2. Nevermind");
                menuchoice = Console.ReadLine();
                switch (menuchoice)
                {
                    case "1":
                        Console.WriteLine("You walk back to the center");
                        location = "Center";
                        break;
                    case "2":
                        break;
                    default:
                        break;
                }
            }
            break;
        //Escape Check
        case "4":
            Console.Clear();
            if (gemfound == true && plaquefound == true && swordfound == true && catfound == true)
            {
                Console.WriteLine("Congratulations you have escaped!");
                questcounter = 4;
            }
            else
            {
                Console.WriteLine("You have not yet found all the treasures!");
            }
            break;
        default:
            Console.WriteLine("That is not an option");
            break;
    }
}
