using Demo04_Heritage.Models;


// polymorphisme des classes
Animal c = new Chat();
c.Nom = "Felix";
c.DateNaissance = DateTime.Now;
c.DireBonjour();
c.Test();

// casting explicite 
((Chat)c).Miauler();

Animal c1 = new Chien()
{
    Nom = "Pluto"
};
c1.DireBonjour();
// ne fonctionne pas : on ne peut pas caster entre frères
// ((Chat)c1).Miauler();

object o = new Chat().GetType();