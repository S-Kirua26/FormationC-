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
            Console.WriteLine($"Résultats du questionnaire  : {score} / {total}"); 
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
    // trim() permet de supprimer les espaces avant et apres une chaine de caracteres
    // trimStart permet de supprimer les espaces avant une chaine de caracteres
    // trimEnd permet de supprimer les espaces apres une chaine de caracteres
    // split permet de spliter mot par mot une chaine de caracteres

    // DateTime dt = new DateTime(1999, 12, 1, 26, 30);
    // TimeSpan permet de calculer la durée entre deux dates

    // string path = Directory.GetCurrentDirectory();
    // StreamWtiter file = new StreamWriter(path + @"\WriteLine.txt"); // crée un nouveau fichier dans le répertoire
    // file.WriteLine(variable) permet d'écrire dans le fichier

    // string text = File.ReadAllText(path + @"\WriteLine.txt"); 
    // string[] text = File.ReadAllLines(path + @"\WriteLine.txt");
    // using( var file = new StreamReader(path + @"\WriteLines.txt, Encoding.GetEncoding()"));

    //Stopwatch sw = new Stopwatch()
    //  sw.Start();
    //  sw.Stop();

    // List<string> names = new List<string> {"Juan", "Ana", "Felipe" };
    //    names.Add("Manu"); ajoute
    //    names.Remove("Felipe"); supprime
    //    names.RemoveAll(x => x == "Juan");
    //    names.Any(x => x = x.Contains("Juan")); recherche si dans la liste "Juan" existe

    // Dictionary<string, string> dico = new Dictionary<string, string>();
    //    dico.Add("fr", "français");
    //    foreach(KeyValuePair<string, string> d in dico) {}
}
