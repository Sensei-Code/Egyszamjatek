using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Egyszamjatek
{
    class Program
    {
        class Jatekos
        {
            public string Nev;
            public List<int> Tipplista = new List<int>();           
        }


        static void Main(string[] args)
        {
            const string file = "egyszamjatek.txt";
            StreamReader sr = new StreamReader(file);
            List<Jatekos> Jatekosok = new List<Jatekos>();

            string sor;
            string[] adatsor;            

            while (!sr.EndOfStream)
            {
                Jatekos temp = new Jatekos();
                sor = sr.ReadLine();
                adatsor = sor.Split(' ');
                temp.Nev = adatsor[0];

                for (int i = 1; i < adatsor.Length; i++)
                {
                    temp.Tipplista.Add(int.Parse(adatsor[i]));
                }

                Jatekosok.Add(temp);
            }
            sr.Close();



        }
    }
}
