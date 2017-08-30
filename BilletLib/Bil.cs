using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøj
    {
        public override int Pris()
        {
             return 240;
        }

        public override string Typekøretøj()
        {
            return "Bil";
        }
    }
}
