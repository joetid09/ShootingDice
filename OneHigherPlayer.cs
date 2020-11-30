using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            //refactored to add 1 to the player if they roll first
            Console.WriteLine($"{Name} rolls a {myRoll + 1}");
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