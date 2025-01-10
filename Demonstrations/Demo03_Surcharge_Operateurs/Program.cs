// prototype = accesseur Nom (arguments)
using Demo03_Surcharge_Operateurs.Models;

Car car1 = new Car();

// appel de l'indexeur pour récupérer un élément sur base de son index dans le tableau
car1.Brand = "Honda";
car1.Model = "Civic";
car1.Year = 2006;
car1.Consumption = 5.9;
car1[0] = "Toto";
car1[1] = "Tata";
car1[2] = "Titi";

Car car2 = new Car();
car2.Brand = "Tesla";
car2.Model = "3";
car2.Year = 2022;
car2.Consumption = 0.2;
car2[0] = "John";
car2[1] = "Alain";
car2[2] = "Senna";

Car combinedCar = car1 + car2;

Console.WriteLine(combinedCar.GetCarInfo());

double distance = 500;      // en km
double fuelPrice = 1.6; // en €/Litre

double price = combinedCar.GetFuelCost(distance, fuelPrice);

Console.WriteLine("Passagers : ");

for (int i = 1; i <= 3; i++)
{
    if (combinedCar[i - 1] != null)
    {
        Console.WriteLine($"Passager {i} : {combinedCar[i - 1]}");
    }
}

Console.WriteLine($"Coût du carburant pour {distance} km : {price} Euros.");

Console.WriteLine(combinedCar[0] = "Toto");
