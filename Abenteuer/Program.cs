using System;

namespace Abenteuer
{
    class Program
    {
        static void Main(string[] args)
        {
            //game init strings
            string greeting = "Welcome to Abenteuer! ... reply with lowercase y/n to input your choices during this game. " +
                "\n You have come to a eerie hallway. ..... Das Abenteuer beginnt!";

            //steps in the game
            string one = "\n Enter through the creepy door on you left?";
            string two = "What about the one on your right?";
            string three = "You sure?";
            string four = "Straight ahead maybe?";

            //results of the game
            string dead = "Well, you're dead!";
            string won = "Well done!";
            string other = "No door there?!";
            string where = "Well where are you going then?";

            //user input
            string oneResult,twoResult,threeResult,fourResult,current;

            //init user
            Console.WriteLine(greeting);

            //game begins
            Console.WriteLine(one);
            oneResult = Console.ReadLine();
            current = (oneResult == "n") ? two : other; // instead of long if statements
            Console.WriteLine(current); // lead step to the next question

            Console.WriteLine(two);
            twoResult = Console.ReadLine();
            current = (twoResult == "n") ? four : three;
            Console.WriteLine(current);

            threeResult = Console.ReadLine();
            current = (threeResult == "n") ? dead : four;
            Console.WriteLine(current);

            fourResult = Console.ReadLine();
            current = (fourResult == "n") ? where : won;
            Console.WriteLine(current);


        }
    }
}
