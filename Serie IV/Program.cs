using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice I - Code Morse
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Exercice I - Code Morse");
            Console.WriteLine("-----------------------------------------------");

            Morse s = new Morse();
            Console.WriteLine("Traduction Morse :");
            // Codes en morse
            string morse = "........===..=.===.=...===.===.===...===.=.=...=.....===.===...===.===.===...=.===.=...=.=.=...=.....===.===.=.=.=...=.=.=.=.=";
            //Console.WriteLine($"{morse} : {s.LettersCount(morse)} lettres - {s.WordsCount(morse)} mots");
            Console.WriteLine($"{s.EfficientMorseTranslation(morse)}");
            morse = "QTC 52 ";
            Console.WriteLine(s.MorseEncryption(morse));
            #endregion
            //#region Exercice III - Liste des contacts télephoniques
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Exercice III - Liste des contacts télephoniques");
            //Console.WriteLine("-----------------------------------------------");

            //int numbers = 0123456789;
            //string[] names = new string[] { "aaron","abby","abdul","abe","abel","abigail" };

            //PhoneBook pb = new PhoneBook();
            //pb.AddPhoneNumber("0632359668", "Arthur");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    pb.AddPhoneNumber("0" + numbers.ToString(), names[i]);
            //    numbers++;
            //}
            //pb.PhoneContact("0123456789");
            //pb.DeletePhoneNumber("0123456789");
            //pb.DisplayPhoneBook();
            //#endregion
            //#region Exercice IV - Emploi du temps professionnel
            //BusinessSchedule bs = new BusinessSchedule();
            //DateTime dt = DateTime.Today;
            //try
            //{
            //    bs.SetRangeOfDates(new DateTime(dt.Year, 1, 1), new DateTime(dt.Year, 12, 31));
            //    TimeSpan oneHour = new TimeSpan(1,0,0);
            //    for (int i = 0; i < 24; i++)
            //    {
            //        bs.AddBusinessMeeting(dt, oneHour);
            //        dt += oneHour;
            //    }
            //    bs.DeleteBusinessMeeting(DateTime.Today + new TimeSpan(DateTime.Now.Hour,0,0),oneHour);
            //    bs.AddBusinessMeeting(DateTime.Now, oneHour);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //bs.DisplayMeetings();
            //#endregion

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
