using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    class MC
    {
        //props
        public String Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
