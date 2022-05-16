using System;
using System.Collections.Generic;
using System.Text;

namespace HjælpLone
{
    class Wizard : ICharacter, IMagicUser
    {
        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }

        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
    }
}
