using System;

namespace code
{
    public abstract class Vehicule
    {

        //On met les attributs en protected pour que les classes filles puisse les utiliser
        protected string models;
        protected string couleur;
        protected int puissance;
        protected double espace;

        //On crée le constructeur de la classe Automobile
        public Vehicule(string models, string couleur, int puissance, double espace)
        {
            this.models = models;
            this.couleur = couleur;
            this.puissance = puissance;
            this.espace = espace;
        }

        public abstract void AfficherCarac();
    }
}

public class VehiculeElectrique : Vehicule 
{
    public VehiculeElectrique(string models, string couleur, int puissance, double espace) : base(models, couleur, puissance, espace)
    {
    }

    //On implemente la méthode AfficherCarac de la classe mère
    public void AfficherCarac()
    {
        Console.WriteLine("Automobile electrique de marque " + models + " de couleur " + couleur + " de puissance " + puissance + " de capacite " + espace);
    }
}

public interface FabriqueVehicule
{
    Vehicule creerVehicule(string models, string couleur, int puissance, double espace);
}

public class FabriqueVehiculeElectrique : FabriqueVehicule
{
    public Automobile creerAutomobile(string models, string couleur, int puissance, double espace)
    {
        return new VehiculeElectrique(models, couleur, puissance, espace);
    }
}

public class Catalogue {

    public static int vehicleNumbre = 3;

    static void Main(string[] args)
    {
        //En réalité on gère la création des véhicules avec des paramètres de l'application console, des if/switchs etc.
        FabriqueVehicule fabrique = new FabriqueVehiculeElectrique();
        Vehicule v1 = fabrique.creerVehicule("Ford", "rouge", 200, 2.0);
        v1.AfficherCarac();

        Vehicule v2 fabrique.creerVehicule("Renault", "bleu", 300, 3.0);
        v2.AfficherCarac();

        Vehicule v3 = fabrique.creerVehicule("Peugeot", "blanc", 400, 4.0);
        v3.AfficherCarac();
    }
}
