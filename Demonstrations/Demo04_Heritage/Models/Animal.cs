using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Heritage.Models
{
    // class parent
    public class Animal
    {
        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }

        public virtual void DireBonjour()
        {
            Console.WriteLine($"Hello, je m'appelle {Nom}.");
        }

        public void Test()
        {
            Console.WriteLine("Test animal");
        }
    }
}
