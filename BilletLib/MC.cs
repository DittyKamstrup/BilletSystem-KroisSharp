using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Køretøj
    {
        public override int Pris()
        {
            return 125;
        }

        public override string Typekøretøj()
        {
            return "MC";
        }
    }
}
