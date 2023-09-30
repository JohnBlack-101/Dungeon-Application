using DungeonLibrary;
using System.Threading;

namespace DungeonApp
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {
            int countOuter = 0;
            int countInner = 0;
            bool outerLoop = true;
            Console.WriteLine("The Fung Hai Tong have kidnapped the love of your life.\nEnter the Dungeon and demonstrate why they have just made the gravest mistake of their lives.");
            Console.WriteLine();


            //Player Creation 
            Player player = Player.GetPlayer();
            //Game Loop
            bool exit = false;
            do
            {
                //Create Monster
                Minion minion = Minion.GetMinion();
                //Create Room
                Console.WriteLine(GetRoom());
                //encounter loop:

                bool reload = false;
                bool isencountered = false;
                do
                {
                    if (!isencountered)
                    {
                        Console.WriteLine($"You've encountered {minion.Name}!\n");
                        isencountered = true;
                    }
                    Console.WriteLine("What will you do!?");
                    Console.WriteLine("A) Attack\nR) Retreat\nP) Player Info\nM) Minion Info\nX) Quit\n");
                    string input = Console.ReadKey(false).Key.ToString();
                    Console.Clear();//only clear after accepting input.
                                    //using branching logic to act upon the user's menu selection
                    switch (input)
                    {
                        case "A":
                            Console.WriteLine("Combat!");
                            //if the monster is dead, DoBattle returns true and reloads the room.
                            reload = Combat.DoBattle(player, minion);
                            break;

                        case "R":
                            Console.WriteLine("Run Away!");
                            Console.WriteLine($"{minion.Name} attacks you as you flee!\n");
                            Combat.DoAttack(minion, player);
                            reload = true;
                            break;

                        case "P":
                            Console.WriteLine("Player Info\n");
                            Console.WriteLine(player);
                            break;

                        case "M":
                            Console.WriteLine("Minion Info\n");
                            Console.WriteLine(minion);
                            break;

                        case "X":
                        case "E":
                            Console.WriteLine("I guess she WASN'T the love of your life...\n");
                            //exit both loops
                            exit = true;
                            break;
                        default:
                            //invalid input.
                            Console.WriteLine("You have chosen poorly...\n");
                            break;
                    }//end switch

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been defeated and are now a grim reminder to not trifle with the Fung Hai...\a");

                        exit = true;//leave both loops.
                    }
                    if (player.Score >= 10)
                    {
                        Console.WriteLine("You have saved your love and exacted revenge!!");

                        exit = true;
                    }
                } while (!reload && !exit);
                //if exit = true, both loops will terminate.
                //If reload = true, only the inner loop will terminate.

            } while (!exit); //exit == false
            Console.WriteLine($"You have defeated {player.Score} Tong Member{(player.Score == 1 ? "." : "s.")}");
        }//end Main()
         //Custom method called GetRoom() -> Ref Magic8Ball lab.
        private static string GetRoom()
        {
            //Mini-Lab: build a string array of room descriptions
            //Return a random string from that collection.

            //build an array:
            //Collection Initialization Syntax:
            string[] rooms =
            {
                "A room adorned with mirrors instead of walls, your reflections make it hard to see where you are going..\n",
                "It is dark and hard to see. There is a strong smell of death in this room..\n",
                "You are in the den of the hideout, there is a fireplace crackling and portraits of past leaders of the tong..\n",
                "You have made it to the dining room, show the tong how strong your appetite is for revenge..\n",
                "The courtyard has been reached and there are many landscaping options that give you the high ground..\n",
                "The cellar of the tong has been reached, there is a printing press with plates that llok like US currency..\n"

                
            };
            return rooms[new Random().Next(rooms.Length)];
        }
}
}