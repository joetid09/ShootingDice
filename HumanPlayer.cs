using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.WriteLine($"{Name}, choose a number 1-6");
            string newRoll = Console.ReadLine();
            int myRoll = int.Parse(newRoll);
            int otherRoll = other.Roll();

            //refactored to add 1 to the player if they roll first
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");


            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}