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

        public string NummerpladeLænge()
        {
            if (Nummerplade.Length < 7  )
            {
                throw new ArgumentException("Nummerplade er for lang");
            }
            return Nummerplade;
        }
        

    }
}
