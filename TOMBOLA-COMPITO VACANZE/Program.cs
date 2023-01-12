using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMBOLA_COMPITO_VACANZE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TITOLO 
            //posizionare il titolo in alto e al centro
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "IL GIOCO DELLA TOMBOLA PER 2 GIOCATORI".Length) / 2, 0);
            Console.WriteLine("IL GIOCO DELLA TOMBOLA PER 2 GIOCATORI");


            //funzione random
            Random random = new Random();





            //1 dichiarazione delle due cartelle
            int[,] cartella1 = new int[3, 9];
            List<int> numeri = new List<int>();

            //generazione 1 cartella
            Console.WriteLine("- ");
            Console.WriteLine(" CARTELLA 1 GIOCATORE ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 91);
                    } while (numeri.Contains(num));
                    numeri.Add(num);
                    cartella1[i, j] = num;

                    //sistemazione numeri nella prima casella
                    //colonna n.0
                    cartella1[0, 0] = random.Next(1, 9);
                    cartella1[1, 0] = random.Next(1, 9);
                    cartella1[2, 0] = 0;
                    //colonna n.1
                    cartella1[0, 1] = random.Next(10, 19);
                    cartella1[1, 1] = random.Next(20, 29);
                    cartella1[2, 1] = random.Next(20, 29);
                    //colonna n.2
                    cartella1[0, 2] = 0;
                    cartella1[1, 2] = random.Next(20, 29);
                    cartella1[2, 2] = 0;
                    //colonna n.3
                    cartella1[0, 3] = 0;
                    cartella1[1, 3] = random.Next(30, 39);
                    cartella1[2, 3] = random.Next(30, 39);
                    //colonna n.4
                    cartella1[0, 4] = random.Next(40, 49);
                    cartella1[1, 4] = 0;
                    cartella1[2, 4] = 0;
                    //colonna n.5
                    cartella1[0, 5] = 0;
                    cartella1[1, 5] = 0;
                    cartella1[2, 5] = random.Next(50, 59);
                    //colonna n.6
                    cartella1[0, 6] = random.Next(60, 69);
                    cartella1[1, 6] = random.Next(60, 69);
                    cartella1[2, 6] = 0;
                    //colonna n.7
                    cartella1[0, 7] = 0;
                    cartella1[1, 7] = random.Next(70, 79);
                    cartella1[2, 7] = random.Next(70, 79);
                    //colonna n.8
                    cartella1[0, 8] = random.Next(80, 90);
                    cartella1[1, 8] = 0;
                    cartella1[2, 8] = random.Next(80, 90);
                }
            }
            //ciclo for per test dei valori e per posizionarli in righe e colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //generazione 2 cartella 
            Console.WriteLine("- ");
            Console.WriteLine(" CARTELLA 2 GIOCATORE ");
            //dichiarazione cartella 2
            int[,] cartella2 = new int[3, 9];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 91);
                    } while (numeri.Contains(num));
                    numeri.Add(num);
                    cartella2[i, j] = num;

                    //sistemazione numeri nella seconda casella
                    //colonna n.0
                    cartella2[0, 0] = random.Next(1, 9);
                    cartella2[1, 0] = random.Next(1, 9);
                    cartella2[2, 0] = 0;
                    //colonna n.1
                    cartella2[0, 1] = random.Next(10, 19);
                    cartella2[1, 1] = 0;
                    cartella2[2, 1] = random.Next(10, 19);
                    //colonna n.2
                    cartella2[0, 2] = 0;
                    cartella2[1, 2] = random.Next(20, 29);
                    cartella2[2, 2] = 0;
                    //colonna n.3
                    cartella2[0, 3] = 0;
                    cartella2[1, 3] = random.Next(30, 39);
                    cartella2[2, 3] = random.Next(30, 39);
                    //colonna n.4
                    cartella2[0, 4] = random.Next(40, 49);
                    cartella2[1, 4] = 0;
                    cartella2[2, 4] = 0;
                    //colonna n.5
                    cartella2[0, 5] = 0;
                    cartella2[1, 5] = 0;
                    cartella2[2, 5] = random.Next(50, 59);
                    //colonna n.6
                    cartella2[0, 6] = random.Next(60, 69);
                    cartella2[1, 6] = random.Next(60, 69);
                    cartella2[2, 6] = 0;
                    //colonna n.7
                    cartella2[0, 7] = 0;
                    cartella2[1, 7] = random.Next(70, 79);
                    cartella2[2, 7] = random.Next(70, 79);
                    //colonna n.8
                    cartella2[0, 8] = random.Next(80, 90);
                    cartella2[1, 8] = 0;
                    cartella2[2, 8] = random.Next(80, 90);
                }
            }
            ///ciclo for per test dei valori e per posizionarli in righe e colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella2[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        
    }
}
