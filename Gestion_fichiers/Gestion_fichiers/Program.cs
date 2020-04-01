using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_fichiers
{
    class Program
    {
        static void Main(string[] args)
        {

       
            Console.WriteLine("le nom du fichier:");
            string fichier = Console.ReadLine(); 
            LectureSep(fichier);
            Console.ReadLine();
  
        }

        public static void ReadToEnd(StreamReader sr)
        {
            Console.WriteLine(sr.ReadToEnd()); 
            sr.Close();
            Console.ReadLine();
        }

        public static void Read(StreamReader sr)
        {
            char[] buffer = new char[40];
            while (sr.EndOfStream == false)
            {
                sr.Read(buffer, 0, 40);
            }
            sr.Close();
            Console.ReadLine();
        }

        public static void ReadLine(StreamReader sr)
        {
            string s;
            s = sr.ReadToEnd();
            while (sr.EndOfStream == false)
            {
                s = sr.ReadLine();
                Console.WriteLine(s);
            }
            sr.Close();
            Console.ReadLine();
        }

        public static void Lecture(string fichier)
        {

            try

            {
                using (StreamReader sr = new StreamReader(fichier))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.ReadLine();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("le fichier n'existe pas");
                Console.WriteLine(ex.Message);


            }
        }
        public static void LectureSep(string fichier)
        {
            StreamReader sr = new StreamReader(fichier);
            string ligne= sr.ReadLine();
            while (ligne != null)
            {
                char[] delimi = new char[] { ';' };
                string[] result = ligne.Split(delimi);

                Console.Write(result[0]);
                Console.Write(" ");
                Console.Write(result[1]);
                Console.Write(" ");
                Console.WriteLine(result[2]);
                ligne = sr.ReadLine();
            }

       
        } 

                                                                                                                                                                                                                                                                                                                                   
            

    }
}
