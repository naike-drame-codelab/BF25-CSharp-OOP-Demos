using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Heritage.Models
{
    // class enfant
    public class Chien : Animal
    {
        // on écrase directement, contrairement au chat qui reprend de la class parent
        public override void DireBonjour()
        {
            Console.WriteLine("Waf waf");
        }
        public void Aboyer()
        {
            Console.WriteLine("WAF");
        }
    }
}
