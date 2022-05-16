using System;
using System.Collections.Generic;
using System.Text;

namespace HjælpLone
{
    class Witch : ICharacter, IMagicUser, IShieldUser
    {
        public void RaiseShield()
        {
            throw new NotImplementedException();
        }

        public void ShieldGlare()
        {
            throw new NotImplementedException();
        }

        public void Teleport(int x, int y)
        {
            throw new NotImplementedException();
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
