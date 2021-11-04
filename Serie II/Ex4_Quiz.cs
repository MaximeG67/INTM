using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Qcm
    {
        //Propriétés
        public string Question;
        public string[] Answers;
        public int Solution;
        public int Weight;

        public Qcm(string question, string[] answers, int solution, int weight)
        {
            Question = question;
            Answers = answers;
            Solution = solution;
            Weight = weight;
        }
        //Méthodes
    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            //TODO: Créer variables score et total
            //Pour chaque Qcm du tableau
            foreach (Qcm qst in qcms)
            {
                //Si la Qcm est valide
                if (QcmValidity(qst))
                {
                    //Poser la question & gérer le score et le total
                    AskQuestion(qst);
                }
            }
            //TODO: Ecrire le score / total
            Console.WriteLine($"score / total");
        }

        public static int AskQuestion(Qcm qcm)
        {
            //Ecrire la question
            Console.WriteLine(qcm.Question);
            //Ecrire les réponses
            for (int i = 0; i < qcm.Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {qcm.Answers[i]}");
            }
            //TODO: Demander choix utilisateur
            //TODO: Vérifier choix utilisateur

            return -1;
        }

        public static bool QcmValidity(Qcm qcm)
        {
            if (qcm.Weight > 0 && qcm.Solution >= 0 && qcm.Solution < qcm.Answers.Length)
            {
                return true;
            }
            return false;
            //return qcm.Weight > 0 && qcm.Solution >= 0 && qcm.Solution < qcm.Answers.Length;
        }
    }
}
