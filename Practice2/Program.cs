using System.ComponentModel.Design;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char[,] matris = new char[25, 25];


            #region Hint

            //for (int i = 0; i < matris.GetLength(0); i++)     istället för matris.GetLength(0) så kan man hårdkoda 25 om man vill
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)     istället för matris.GetLength(1) så kan man hårdkoda 25 om man vill
            //    {
            //        if (Här behöver det läggas till logik för att avgöra om en "|" eller en "0" ska skrivas ut)
            //        {
            //            // om true skriv ut en "|"
            //        }
            //        else
            //        {
            //            // om false skriv ut en "0"
            //        }
            //    }
            //    // Här behöver man göra ett radbryt
            //}


            // Tänk på att använda int variablerna i forloopen i och j!

            #endregion

            // Skriv ut i Consolen så att det ser ut som i Pattern1. Hårdkoda inte använd loopar och if satser eller ternary
            // Använd matrisen om du vill för storleken på looparn eller hårdkoda storleken
            // Storleken på det utskrivna ska vara 25*25




            #region Hint

            // samma hint som den första men logiken i if-satsen måste vara annan.

            // Tänk på att använda i och j variablerna men på ett annat sätt

            #endregion

            // Samma sak med Pattern2


            #region Hint

            // Här behöver vi lägga till det som vi gjorde i Pattern 1 och Pattern 2 samtidigt
            // Ledtråd = || det vill säga "or"
                
            #endregion

            // Samma sak med pattern3


        }
    }
}