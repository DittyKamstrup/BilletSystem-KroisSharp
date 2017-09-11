using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøj
    {

        //FEEDBACK
        //Evt. lave en constructor for Bil med passende variabler fra base klassen

        //F.eks.
        //public Bil(string bro, string nummerPlade, DateTime dato) : base(bro, nummerPlade, dato)
        //{
        //
        //}



        //ctor vi ønsker at vælge hvilken bro der bliver brugt
        public Bil(bool øresundsbro)
        {

        }


        public override int Pris()
        {
            //vi har if med grundet vi ønsker en anden pris for øresundsbro
            if (Øresundsbro == true)
            {
                return 410;
            }
             return 240;
        }

        public override string Typekøretøj()
        {
            if (Øresundsbro == true)
            {
                return "Øresund Bil";
            }
            return "Bil";
        }

        /// <summary>
        /// overskrevet da biler har særlig vilkår ang. weekend priser
        /// </summary>
        /// <returns></returns>
        public override int BrobizzRabat()
        {
            if (Øresundsbro == true)
            {
                return 161;
            }
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
