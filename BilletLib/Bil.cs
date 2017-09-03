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

        /// <summary>
        /// overskrevet da biler har særlig vilkår ang. weekend priser
        /// </summary>
        /// <returns></returns>
        public override int BrobizzRabat()
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                int rabat = Pris() / 100 * 20;
                int brobizzPris = Pris() - rabat;
                return brobizzPris;
            }
            else
            return base.BrobizzRabat();
        }
    }
}
