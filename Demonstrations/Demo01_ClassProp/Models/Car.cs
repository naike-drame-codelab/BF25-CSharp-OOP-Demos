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
        #region Demo attributs & propriétés
        int Test { get; set; }

        // attribut privé de la class
        private string _Color;

        // propriété dudit attribut définissant les accès en dehors de la class
        public string Color
        {
            // Accesseur (get) : si seul, writeonly
            get
            {
                return _Color;
            }
            // Accesseur (set) : si seul, readonly
            set
            {
                _Color = value;
            }
            // générer une propriété auto : prop + TAB
            // générer une propriété auto complète : propfull + TAB
        }
        #endregion

        #region Attributs / variable Membres
        // variables membres
        private string _Brand;
        private double _Consumption; // Litres

        // attributs avec propriétés auto
        public string Model { get; set; }
        public int Year { get; set; }

        #endregion

        #region Propriétés
        public string Brand
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        public double Consumption
        {
            get
            {
                return _Consumption;
            }
            set
            {
                // validation : la consommation doit être positive
                if (value > 0)
                {
                    _Consumption = value;
                }
                else
                {
                    Console.WriteLine("La consommation doit être positive.");
                }
            }
        }

        #endregion

        #region Méthodes
        // calcul du coût du carburant sur une distance donnée
        public double GetFuelCost(double distance, double fuelPrice)
        {
            return (distance * _Consumption / 100) * fuelPrice;
        }

        public string GetCarInfo()
        {
            return $"Marque : {_Brand}, Modèle : {Model}, Année : {Year}, Consommation : {_Consumption} L/100km.";
        }

        #endregion
    }
}