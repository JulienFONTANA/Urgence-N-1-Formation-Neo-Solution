using System;

namespace Urgence_N_1_Formation_Néo
{
    class Urgence1Solution
    {
        static void Main(string[] args)
        {
            // Recrues! Ici le Commandant Morrison, chef suprème des héros!
            // Notre QG à été attaqué, et notre système informatique détruit!
            // Il va vous falloir le réparer en urgence!
            //
            // Nous avons besoin de crypter nos messages avec un pictogramme visuel.
            // Avec ce que vous avez appris aujourd'hui, il vous faut afficher
            // un rectange de LxH (Largeur fois hauteur) qui ressemble à ce qui suit:
            //
            // Exemple 1: L = 5, H = 3
            //
            // O---O
            // |   |
            // O---O
            //
            // Exemple 2: L = 9, H = 2
            //
            // O-------O
            // O-------O
            //
            // Exemple 3: L = 3, H = 5
            //
            // O-O
            // | |
            // | |
            // | |
            // O-O
            //
            // Vous devrez bien évidement prouvez à votre code Guru que ce système marche avec n'importe
            // quelles valeurs pour L et H comprises entre 1 et 50!
            //
            //
            // Vous avez validé cette première étape ? Très bien, voici la suite :
            // Vous allez devoir afficher un damier noir et blanc à l'interieur du rectangle.
            // 
            // Exemple: L = 10, H = 10
            //
            // 0--------0
            // |XOXOXOXO|
            // |OXOXOXOX|
            // |XOXOXOXO|
            // |OXOXOXOX|
            // |XOXOXOXO|
            // |OXOXOXOX|
            // |XOXOXOXO|
            // |OXOXOXOX|
            // 0--------0
            //
            //
            // Vous avez aussi validé la deuxième étape ? Parfais, voici la dernière :
            // Vous devez maintenant laisser une case vide dans le damier toute les 7 cases.
            //
            // Exemple: L = 10, H = 10
            //
            // 0--------0
            // |XOXOXO O|
            // |OXOXO OX|
            // |XOXO OXO|
            // |OXO OXOX|
            // |XO OXOXO|
            // |O OXOXOX|
            // | OXOXOX |
            // |OXOXOX X|
            // 0--------0

            // Interdiction de modifier ce code!!!
            char Coin = '0';
            char Hor = '-';
            char Ver = '|';
            char Centre = ' ';
            char Blanc = 'X';
            char Noir = 'O';

            int L = 0;
            int H = 0;
            Console.Write("Valeur pour la Largeur : ");
            int.TryParse(Console.ReadLine(), out L);
            Console.Write("Valeur pour la Hauteur : ");
            int.TryParse(Console.ReadLine(), out H);
            // Fin d'interdiction

            int count = 1;
            // On parcours la largeur
            for (int larg = 0; larg < L; larg++)
            {
                // On parcours la hauteur
                for (int haut = 0; haut < H; haut++)
                {
                    // Test de Coin
                    if ((larg == 0 && haut == 0) || (larg == L - 1 && haut == 0) || (larg == 0 && haut == H - 1) || (larg == L - 1 && haut == H - 1))
                    {
                        Console.Write(Coin);
                    }
                    // Test de coté Horizontal
                    else if ((larg == 0) || (larg == L - 1))
                    {
                        Console.Write(Hor);
                    }
                    // Test de coté Vertical
                    else if ((haut == 0) || (haut == H - 1))
                    {
                        Console.Write(Ver);
                    }
                    // Centre du carré
                    else
                    {
                        if (count % 7 == 0)
                            Console.Write(Centre);
                        else if (larg % 2 == 0)
                        {
                            if (haut % 2 == 0)
                                Console.Write(Blanc);
                            else
                                Console.Write(Noir);
                        }
                        else
                        {
                            if (haut % 2 == 0)
                                Console.Write(Noir);
                            else
                                Console.Write(Blanc);
                        }
                        count++;
                    }
                }
                // Fin de la ligne
                Console.WriteLine();
            }
        }
    }
}
