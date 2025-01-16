using Exercice03_CarWash.Models;

// event : ajout de la méthode est public MAIS l'exécution est private
// utilisé avec les delegates
Car v = new Car("001");
Carwash carwash = new();

carwash.etapes += v => Console.WriteLine("Cette méthode a été ajoutée en dehors de la class Carwash");

// avec l'ajout du event dans la variable privée public etapes,
// la méthode ajoutée est public
// mais l'exécution reste privée

// impossible car event
// carwash.etapes.Invoke(v);

//Button btn = new Button();
//btn.Text = "Cliquer sur moi";
//btn.Clicked += (_, _) => Console.WriteLine("Vous venez de cliquer sur le bouton.");
//btn.Clicked.Invoke();