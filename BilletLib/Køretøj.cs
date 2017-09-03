using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
   public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public abstract int Pris();
        public abstract string Typekøretøj();

        /// <summary>
        /// vi vil se om vores nummerplade er for stor. smider en execption hvis den er for lang.
        /// </summary>
        /// <returns></returns>
        public int NummerpladeLænge()
        {
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er for lang");
            }
            return Nummerplade.Length ;
        }
        
        /// <summary>
        /// vi beregner prisen ved først at finde ud af hvor meget 5% udgør af prisen MC/BIL
        /// og finder så brobizzPrisen og smider den tilbage
        /// </summary>
        /// <returns></returns>
        public virtual int BrobizzRabat()
        {
            int rabat = Pris() / 100 * 5;
            int brobizzPris = Pris() - rabat;


            return brobizzPris;
        }



    }
}
