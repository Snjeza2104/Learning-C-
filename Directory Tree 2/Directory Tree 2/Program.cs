/*Program vraća sve poddirektorije za unesenu putanju*/
using System;
using System.IO;

namespace Directory_Tree_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Glavni program samo poziva rekurziju
            Console.WriteLine("Unesite putanju: ");
            GetFolders(Console.ReadLine());
            Console.ReadKey();
        }
        //Ako ne želim raditi preko brojanja, mogu koristiti statičnu varijablu koja
        //bi mogla brojati zapravo koliko je rekurzija duboko pozvana
        static int b = 0;
        private static void GetFolders(string sPath)
        {
            //Prvo ispisujem ime korijenskog direktorija, ali tako da bude sve lijepo uvučeno
            Console.WriteLine("{0}{1}", new string(' ', GetDepth(sPath) * 2), Path.GetFileName(sPath));
            b++;
            //Zatim uzimam sve poddirektorije tog korijenskog direktorija
            string[] sDirs = Directory.GetDirectories(sPath);

            //Pregledavam ih sve redom kroz petlju
            foreach(string sD in sDirs)
            {
                //i rekurzivno pozivam istu tu funkciju
                GetFolders(sD);
            }
            b--;
        }

        private static int GetDepth(string sPath)
        {
            int a = 0;
            foreach (char c in sPath)
            {
                if (c == '\\')
                {
                    a++;
                }
            }
            return a;
        }
    }
}
