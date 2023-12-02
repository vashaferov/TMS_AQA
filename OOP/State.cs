using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class State
    {
        public string publicVar = "public"; // виден везде, во всех сборках

        private string privateVar = "private"; // виден только в рамках класса

        protected string protectedVar = "protected"; // виден в рамках класса + дочерние 

        internal string internalVar = "internal"; // доступна в любом месте проекта

        // protected internal ... - совмещает оба условия (В любом месте этого проекта и в дочерних классах в другом проекте)

        // private protected ... - совмещает оба условия (Доступен из текущего класса и дочерних, которые определены в том же проекте)

        public void Print()
        {

        }
    }
}
