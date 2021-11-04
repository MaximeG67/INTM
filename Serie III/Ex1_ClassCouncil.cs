using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            Dictionary<string, List<float>> dico = new Dictionary<string, List<float>>();
            string[] lines = System.IO.File.ReadAllLines(input);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                string[] tab = line.Split(';');
                if (!dico.ContainsKey(tab[1]))
                {
                    dico.Add(tab[1], new List<float>());
                }
                dico[tab[1]].Add(float.Parse(tab[2].Replace('.', ',')));
            }
            lines = new string[dico.Count];
            int i = 0;
            foreach (var matière in dico)
            {
                Console.WriteLine(matière.Key);
                Console.WriteLine(matière.Value.Average());
            }
            File.WriteAllLines("result.txt", lines);
        }
    }
}
