using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_ClassProp.Models
{
    // par défaut, les éléments au sein d'un namespace non spécifiés sont internal

    class Car
    {
        int Test {  get; set; }

        public string Color { get; set; }
    }
}
