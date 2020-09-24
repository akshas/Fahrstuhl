using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fahrstuhl
{

    enum Etagen { erdgeschoss, erste, zweite, dritte ,vierte}


    class FahrsthuhlClass
    {
        public delegate void StartHandler(int e);
        public event StartHandler Start;
        public bool Knopf { get; set; }
        public bool NachOben { get; set; }
        public int AnzahlEtagen { get; set; }
        public Etagen aufenthalt { get; set; } = Etagen.erdgeschoss;

        public List<Etagen> EtagenList = new List<Etagen>(){Etagen.erdgeschoss, Etagen.erste, Etagen.zweite, Etagen.dritte, Etagen.vierte};

        public FahrsthuhlClass()
        {
        }

        public void KnopfGedrueckt(int e)
        {
            Start += Fahren;
            if ((int)aufenthalt < e)
            {
                NachOben = true;
            }
            else
            {
                NachOben = false;
            }


            Start?.Invoke(e);
        }


        public void Halten ()
        {
            Start -= Fahren;
        }
        public void Fahren(int e)
        {

            int i = (int)aufenthalt;
            while (NachOben ? i < e : i >= e)
            {
                Thread.Sleep(1000);
                Console.WriteLine(EtagenList[i]);
                aufenthalt = EtagenList[e];

                 _= NachOben ? i++ : i--;
            }
            Halten();
            Console.WriteLine("Die Tür wird geöffnet");
        }
    }
}
