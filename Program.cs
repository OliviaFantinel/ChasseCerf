namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        
        Console.WriteLine("Arthur, attention, un cerf! \nTu n'as que 5 flèches pour l'abattre.");
        int arrows = 5;
        int deerHealth = 3;
        for (int i = 0; i < arrows && deerHealth != 0; i++)
        {
            Console.WriteLine($"Tu as encore {arrows-i} flèches. Tu vises et tire. L'as tu touché ou raté?");
            string answer = Console.ReadLine();
            while (answer != "touché" && answer != "raté")
            {
                Console.WriteLine("Je n'ai pas compris, l'as tu touché ou raté?");
                answer = Console.ReadLine();
            }

            if (answer == "touché")
            {
                Console.WriteLine("Bravo ! Tu l'as eu !");
                deerHealth--;
            } 
            else if (answer == "raté")
            {
                Console.WriteLine("Zut. Retente ta chance.");
            }
        }

        if (deerHealth == 0)
        {
            Console.WriteLine("Tu es venu à bout de la bête.\n" +
                              "En la voyant de plus près, tu te rends compte que tu as ôté la vie à une créature majestueuse.\n" +
                              "Tout ça pour un hobby. Du frisson. Un passe-temps.\n" +
                              "Dans ses yeux vides, tu te reconnais Arthur.\n" +
                              "Est-ce que tu désires encore manger la viande de ton prochain?");
        }
        else
        {
            Console.WriteLine("Le cerf est parti.\n" +
                              "Tu l'as fait exprès, n'est-ce pas Arthur ?\n" +
                              "C'est certainement pour le mieux. On aura faim ce soir, mais notre conscience sera tranquille !");
        }
    }
}