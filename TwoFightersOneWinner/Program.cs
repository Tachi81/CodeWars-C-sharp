using System;

//  Create a function that returns the name of the winner in a fight between two fighters.
//  Each fighter takes turns attacking the other and whoever kills the other first is victorious.
//  Death is defined as having health <= 0.
//  Each fighter will be a Fighter object/instance. Both health and damagePerAttack will be integers larger than 0.

namespace TwoFightersOneWinner
{
    class Program
    {
        static void Main()
        {
            DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew");
            Console.ReadKey();
        }

        private static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            bool flag = fighter1.Name == firstAttacker;

            while (true)
            {
                Fighter first = flag ? fighter1 : fighter2;
                Fighter second = flag ? fighter2 : fighter1;
                second.Health -= first.DamagePerAttack;
                if (second.Health > 0)
                {
                    Console.WriteLine(
                        $"{first.Name} attacks {second.Name}; {second.Name} now has {second.Health} helth.");
                }
                else
                {
                    Console.WriteLine(
                        $"{first.Name} attacks {second.Name}; {second.Name} now has {second.Health} helth and is dead.{first.Name} wins");
                    return first.Name;
                }

                flag = !flag;
            }
        }
    }
}
