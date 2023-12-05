using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Game
{
    internal class Warrior : Character
    {
        public Warrior(int level) : base(level)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior Attack");
        }

        public override void Move()
        {
            Console.WriteLine("Warrior Move");
        }

        public override void UseAbility()
        {
            Console.WriteLine("Warrior UseAbility");
        }
    }
}
