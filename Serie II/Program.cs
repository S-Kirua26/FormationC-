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
            int[] tableau1 = new int[]{1,-5,10,-3,4,2,-7};
            int[] tableau2 = new int[]{1,-5,10,-3,4,2,-7};
            Search.LinearSearch(tableau1, 4);
            Search.LinearSearch(tableau1, 34);

            Array.Sort(tableau2);
            Search.BinarySearch(tableau2, -3);

            Eratosthene.EratosthenesSieve(100);

            string question1 = "Quelle est l'anéée du sacre de Charlemagne";
            string[] reponse1 = { "476", "800", "1066", "1789" };
            int solution1 = 2;
            int ponderation1 = 1;
            Qcm q1 = new Qcm(question1,reponse1,solution1,ponderation1);
            Quiz.AskQuestion(q1);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            
            string question2 = "Pour le manga One Piece, combien y'a t'il de tome actuellement?";
            string[] reponse2 = { "80", "56", "100", "110" }; 
            int solution2 = 3;
            int ponderation2 = 1;
            Qcm q2 = new Qcm(question2, reponse2, solution2, ponderation2);

            string question3 = "Comment se nomme le protagoniste principale de Fairy Tail?";
            string[] reponse3 = { "Lucy", "Natsu", "Grey", "Erza" };
            int solution3 = 2;
            int ponderation3 = 1;
            Qcm q3 = new Qcm(question3, reponse3, solution3, ponderation3);

            string question4 = "Sur quel planète Goku se tranforme pour la première fois en super sayan?";
            string[] reponse4 = { "Terre", "Yardrat", "Iris", "Namek" };
            int solution4 = 4;
            int ponderation4 = 1;
            Qcm q4 = new Qcm(question4, reponse4, solution4, ponderation4);

            Qcm[] questions = new Qcm[] {q2,q3,q4};
            Quiz.AskQuestions(questions);

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
