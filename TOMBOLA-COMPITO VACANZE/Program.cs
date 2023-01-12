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
        }
    }
}
