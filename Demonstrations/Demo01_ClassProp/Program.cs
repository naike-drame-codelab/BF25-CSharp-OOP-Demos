using Demo01_ClassProp.Models;
using System.Text;

// ALT + ENTER : permet d'ajouter le using nécessaire à l'utilisation de la class
// F12 sur l'objet : accès direct à la class
Car c = new Car();

// par défaut, les élément d'une class ont un niveau d'accès private
// c.Test

// accès à une propriété d'une class
c.Color = "Red";


Car car = new Car();

// initialisation de nos attributs
car.Brand = "Honda";
car.Model = "Civic";
car.Year = 2006;
car.Consumption = 5.9;

// afficher les infos
Console.WriteLine(car.GetCarInfo());

double distance = 500; // en km
double fuelPrice = 1.6; // en €/litre
double cost = car.GetFuelCost(distance, fuelPrice);

Console.OutputEncoding = Encoding.Unicode;
Console.WriteLine($"Le coût du carburant pour une distance de {distance} km est de {cost} €.");