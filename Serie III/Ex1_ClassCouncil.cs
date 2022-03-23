using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            using (StreamReader lecture = new StreamReader(input))
            {
                while (!lecture.EndOfStream)
                {
                    string line = lecture.ReadLine();
                    //Console.WriteLine(line);
                    string[] tableauLine = line.Split(';');

                    string matiere = tableauLine[1];
                    string note = tableauLine[2].Replace('.', ',');

                    if (dico.ContainsKey(matiere))
                    {
                        Debug.WriteLine($"{tableauLine[0]} {matiere}");
                        dico[matiere].Add(float.Parse(note));
                    }
                    else
                    {
                        Console.WriteLine($"{tableauLine[0]} {matiere} console 2");
                        dico.Add(tableauLine[1], new List<float>() { float.Parse(note) });
                    }
                }
            }
            using (StreamWriter sortie = new StreamWriter(output))
            {
                foreach (KeyValuePair<string, List<float>> m in dico)
                {
                    //double total = 0;
                    //foreach (var note in m.Value)
                    //{
                    //    total += note;
                    //}
                    //total /= m.Value.Count;
                    sortie.WriteLine(m.Key + ";" + m.Value.Average());
                }
            }
            //StreamWriter fichier1 = new StreamWriter(path + @"\sortie.txt");
        }
    }
}
