using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Heritage.Models
{
    // class enfant
    public class Chat : Animal
    {
        public void Miauler()
        { 
            Console.WriteLine("MIAOU"); 
        }

        // redéfinition de la méthode de base
        public override void DireBonjour()
        {
            Miauler();
            base.DireBonjour();
        }

        // dissimulation de méthode
        // à éviter : on va écraser en C# les méthodes qui sont spécifiées comme virtual
        public new void Test()
        {
            Console.WriteLine("Test chat");
        }
    }
}
