using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_ClassProp.Models
{
    // par défaut, les éléments au sein d'un namespace non spécifiés sont internal
    // internal : limité à son assembly/au projet où l'élément est défini

    // enum : internal par défaut
    // si je déclare une variable de type T, il faut que ce type T soit public également
    enum Values { Value1, Value2, Value3 }

    class Car
    {
        int Test { get; set; }

        public string Color { get; set; }
    }
}
