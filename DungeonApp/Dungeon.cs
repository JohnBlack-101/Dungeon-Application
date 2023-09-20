namespace DungeonApp
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {
            int countOuter = 0;
            int countInner = 0;
            bool outerLoop = true;
            Console.WriteLine("Welcome to The Tower of Death!");


            //Player Creation 
            //Game Loop
            bool exit = false;
            do
            {
                //Create Monster
                //Create Room
                //encounter loop:

                bool innerLoop = true;
                do
                {
                    Console.WriteLine("You've encountered The Fiend!");
                    Console.WriteLine("What will you do!?");
                    Console.WriteLine("D) Dragon Kick\nR) Retreat\nC) Character Info\nM) Monster Info");
                    string input = Console.ReadKey(false).Key.ToString();
                    Console.Clear();//only clear after accepting input.
                    switch (input)
                    {
                        case "D":
                            Console.WriteLine("CRITICAL HIT!! You have shown your true Warrior Spirit and the Monster has Fled ");
                            break;
                        case "R":
                            Console.WriteLine("You have chosen the way of the coward and have received a severe slash to your back! ");
                            break;
                        case "C":
                            Console.WriteLine("HP: 150\nMP: 300\nInner Dragon Spirit: 50");
                            break;
                        case "M":
                            Console.WriteLine("HP: 70\n MP: 90");
                            break;
                    }    
                            Console.WriteLine("Inner: " + countInner);
                    //innerLoop = false exits ONLY the inner loop.
                    //outerLoop = false, BOTH loops will exit!
                    countInner++;
                } while (innerLoop && outerLoop);
                countOuter++;
            } while (outerLoop);
        }
    }
}