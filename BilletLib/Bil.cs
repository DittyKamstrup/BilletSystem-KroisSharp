using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil
    {
        //props
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// prisen er fast på 240kr 
        /// </summary>
        /// <returns></returns>
        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }


    }
}
