using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_ClassProp.Models
{
    class Car
    {

        #region Attributs / variable Membres
        // variables membres
        private string _Brand;
        private double _Consumption; // Litres
        private string[] _Passengers = new string[5];

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

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _Passengers.Length)
                {
                    return _Passengers[index];
                }
                Console.WriteLine("Index hors limite");
                return null;
            }
            set {
                if (index >= 0 && index < _Passengers.Length)
                {
                    _Passengers[index] = value;
                }
                else
                {
                    Console.WriteLine("Index hors limite");
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