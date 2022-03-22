using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Qcm
    {
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
    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            int score = 0;
            int total = 0;
            for (int i = 0; i < qcms.Length; i++)
            {
                score += AskQuestion(qcms[i]);
                total += qcms[i].Weight;
            }
            Console.WriteLine($"Résultats du questionnaire : {score} / {total}");
        }

        public static int AskQuestion(Qcm qcm)
        {
            if (QcmValidity(qcm))
            {
                Console.WriteLine(qcm.Question); // on lui pose la question

                for (int i = 0; i < qcm.Answers.Length; i++) // on affiche les réponses possibles
                {
                    Console.Write($"{i + 1}. {qcm.Answers[i]} ");
                }
                Console.WriteLine();

                string input = Console.ReadLine(); // on lui demande une réponse
                int retour;
                int.TryParse(input, out retour);
                
                while (retour < 0 || retour > qcm.Answers.Length || !int.TryParse(input, out retour)) // si la réponse donnée ne correspond pas à celle attendue
                {
                    Console.WriteLine("Reponse Invalide!");
                    input = Console.ReadLine(); // on lui redemande une réponse
                    int.TryParse(input, out retour);
                }

                if(retour == qcm.Solution)
                {
                    Console.WriteLine("Bravo, c'est la bonne réponse");
                    return qcm.Weight;
                }
                else
                {
                    Console.WriteLine("Perdu");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("QCM Invalide");
                throw new ArgumentException();
            }
        }

        public static bool QcmValidity(Qcm qcm)
        {
            if (qcm.Solution >= 0 && qcm.Solution <= qcm.Answers.Length && qcm.Weight > 0)
            {
                return true;
            }
            return false;
        }
    }
}
