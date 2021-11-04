using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vG = { 1, 2, 3 };
            int[] vD = { -1, -4, 0 };
            int[][] m = Matrix.BuildingMatrix(vG, vD);
            Matrix.DisplayMatrix(m);

            int[][] mG =
            {
                new int[]{1,2 },
                new int[]{ 4,6},
                new int[]{-1,8 },
            };
            Matrix.DisplayMatrix(mG);
            int[][] mD =
            {
                new int[]{-1,5},
                new int[]{-4,0},
                new int[]{0,2},
            };
            Matrix.DisplayMatrix(mD);

            m = Matrix.Addition(mG, mD);
            Matrix.DisplayMatrix(m);
            m = Matrix.Substraction(mG, mD);
            Matrix.DisplayMatrix(m);

            #region Exercice 4

            Qcm q1 = new Qcm();
            q1.Question = "Quelle est l'année du sacre de Charlemagne ?";
            q1.Answers = new string[4];
            q1.Answers[0] = "476";
            q1.Answers[1] = "800";
            q1.Answers[2] = "1066";
            q1.Answers[3] = "1789";
            q1.Solution = 1;
            q1.Weight = 1;

            string qst = "Quelle est l'année du sacre de Charlemagne ?";
            string[] ans = new string[]
            {
                "476",
                "800",
                "1066",
                "1789"
            };
            int sln = 1;
            int pts = 1;
            Qcm q2 = new Qcm(qst, ans, sln, pts);

            Qcm q3 = new Qcm
            {
                Question = qst,
                Answers = ans,
                Solution = sln,
                Weight = pts
            };

            Qcm[] questions = new Qcm[] { q1, q2, q3 };

            //Quiz.AskQuestion(q1);
            Quiz.AskQuestions(questions);
            #endregion

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
