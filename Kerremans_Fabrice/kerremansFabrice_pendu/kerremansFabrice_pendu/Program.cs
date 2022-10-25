using System.Linq;
using System.Text;

void menu()
{

    Console.WriteLine("                ***JEU DU PENDU*** ");
    Console.WriteLine("                                        ");
    Console.WriteLine("       Trouvez le mot exact en moins de 5 tentatives  ");
    Console.WriteLine("      ***********************************************");
    Console.WriteLine("                                        ");

}


string RetourneMot()
{
    //Fonction qui renvoie un mot au hasard
    Random rnd = new Random();
    string[] LISTE = { "CHIEN", "LION", "TORTUE","LOUP","KIKOU" };
    int random = rnd.Next(LISTE.Length);
    string mot;
    mot = LISTE[random];
    return mot;

}


int Compter(string Mot)
{
    int count = 0;
    for (int i = 0; i < Mot.Length; i++)
    {
        if ((Mot[i]).Equals("") == false)
        {
            count++;
        }
    }
    return count;
}


int AffichePendu(int compter)
{
    return compter;// if count=1 afficher P
}


// Main
menu();
bool val = true;
string liste = RetourneMot();
liste.ToUpper();
int essai = 0;
char[] lettre = new char[20];

Console.WriteLine("Trouvez ce mot composé de " + liste.Length + " lettres");
Console.WriteLine(lettre);
for (int i = 0; i < liste.Length; i++)
{
    lettre[i] = '-';

}

while (essai < liste.Length && essai < 11 && val == true)
{
    int compter = 1;
    string choix;
    Console.WriteLine("    Vos vies restantes :" + (11 - essai));
    Console.WriteLine("*******************************");
    Console.WriteLine(" Choisis 1 lettre  : ");
    choix = Console.ReadLine();
    choix = choix.ToUpper();
    //choix=choix.ToUpper();
    char mot = char.Parse(choix);
    //-


    for (int i = 0; i < liste.Length; i++)
    {
        if (mot.Equals(liste[i]))
        {
            lettre[i] = mot;
            compter++;
        }
    }
    Console.WriteLine(lettre);
    if (liste.Length.Equals(Compter))
    {
        Console.WriteLine("Gagné");
        val = false;
    }

  

    essai++;
  }
    