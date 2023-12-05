using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Game
{
    internal class Wizard : Character
    {
        public Wizard(int level) : base(level)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Wizard Attack");
        }

        public override void Move()
        {
            Console.WriteLine("Wizard Move");
        }

        public override void UseAbility()
        {
            Console.WriteLine("Wizard UseAbility");
        }
    }
}
