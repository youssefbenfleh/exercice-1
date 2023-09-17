using System;

class Program
{
    static void Main()
    {
        // Demander à l'utilisateur de saisir les prix d'achat
        double sommeTotale = 0;
        Console.Write("Entrez le prix d'achat (0 pour terminer) : ");
        double prix = double.Parse(Console.ReadLine());

        while (prix != 0)
        {
            sommeTotale += prix;
            Console.Write("Entrez le prix d'achat (0 pour terminer) : ");
            prix = double.Parse(Console.ReadLine());
        }

        // Demander à l'utilisateur de saisir la somme payée
        Console.Write("Entrez la somme payée : ");
        double sommePayee = double.Parse(Console.ReadLine());

        // Calculer la monnaie à rendre
        double monnaie = sommePayee - sommeTotale;

        // Afficher la monnaie à rendre en coupures de 10, 5 et 1 Euro
        int nombreCoupures10Euros = (int)(monnaie / 10);
        int nombreCoupures5Euros = (int)((monnaie % 10) / 5);
        int nombreCoupures1Euro = (int)(((monnaie % 10) % 5) / 1);

        Console.WriteLine("Monnaie à rendre : " + monnaie + " Euros");
        Console.WriteLine("Coupures de 10 Euros à rendre : " + nombreCoupures10Euros);
        Console.WriteLine("Coupures de 5 Euros à rendre : " + nombreCoupures5Euros);
        Console.WriteLine("Coupures de 1 Euro à rendre : " + nombreCoupures1Euro);
    }
}
