using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrstuhl
{
    class Program
    {
        /*
             Baut einen Fahrstuhl

            Der Fahrstuhl bedient 5 Etagen (Erdgeschoss, 1,2,3,4)
            Auf jeder Etage kann ein potentieller Fahrgast auf einen Knopf drücken
            Es gibt nur einen Knopf, der dem Fahrstuhl signaliert, dass da jemand wartet.
            Egal, wo der Fahrgast hin möchte ... Der Fahrstuhl behält seine Richtung bei.

            Beispiel: Im Erdgeschoss steigt jemand ein und will in die 4 Etage
            In der 2. Etage steigt jemand ein und will ins Erdgeschoss
            Der Fahrstuhl fährt erst in die 4. Etage, dann wieder runter.

            Während der Fahrstuhl vor sich hin fahrstuhlt, können weitere Gäste auf beliebigen
            Etagen ankommen und auf den Knopf drücken. Diese neuen Gäste sollen auch
            berücksichtigt werden.
         */
        static void Main(string[] args)
        {
            
            FahrsthuhlClass fahrsthuhl1 = new FahrsthuhlClass();

            fahrsthuhl1.KnopfGedrueckt(3);
            //fahrsthuhl1.KnopfGedrueckt(3);
            fahrsthuhl1.KnopfGedrueckt(4);
            fahrsthuhl1.KnopfGedrueckt(0);
        }
    }
}
