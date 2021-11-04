using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
           
            
                if (heure >= 0 && heure < 6) { 
                    Console.WriteLine("Merveilleuse nuit !");
            }
            else if (heure >= 6 && heure < 12) { 
                    Console.WriteLine("Bonne matinée !");
            }
            else if (heure == 12) { 
                    Console.WriteLine("Bon appétit !");
            }
            else if (heure >= 13 && heure <= 18)
            {
                Console.WriteLine("Profitez de votre après midi !");
            }
            else if (heure > 18)
            {
                Console.WriteLine("Passez une bonne soirée ! ");
            }         

            return string.Empty;
        }
    }
}
