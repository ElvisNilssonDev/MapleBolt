namespace MapleBolt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to MapleBolt...PRESS TO PROCEED");
            Console.ReadLine();
            Console.WriteLine("mapleBolt is an Enterprise for checking my own stupidity...PRESS TO PROCEED");
            Console.ReadLine();
            {

                Console.WriteLine("Are you a pro or a beginner??");
                string rank = Console.ReadLine();

                if (rank == "pro")
                {
                    Console.WriteLine("Thats what I like to hear");
                }
                else if (rank == "beginner")
                {
                    Console.WriteLine("Thats okay! you will learn");
                }
                else
                {
                    Console.WriteLine("Hi there, " + rank + "! I have never heard of you but thats okay, I am sure you were meant to do something.");
                }
         
            }

        }
    }
}
