using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Køretøj
    {

        public MC(bool Øresundsbro)
        {

        }


        public override int Pris()
        {
            if (Øresundsbro == true)
            {
                return 210;
            }
            return 125;
        }

        public override string Typekøretøj()
        {
            if (Øresundsbro == true)
            {
                return "Øresund MC";
            }

            return "MC";
        }

        public int ØreesundBrobizz()
        {
            return 73;
        }

    }
}
