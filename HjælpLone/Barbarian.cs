﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HjælpLone
{
    class Barbarian : ICharacter, IMeleeUser
    {
        public void Bash()
        {
            throw new NotImplementedException();
        }

        public void Cleave()
        {
            throw new NotImplementedException();
        }

        public void Slash()
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
