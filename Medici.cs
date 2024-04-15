using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medici_Pacienti
{
    [Serializable]
    public class Medic
    {   private string cnp;
        private string nume;
        private int anAbsolvire;
        private string specializare;
        private DateTime dataNastere;
        public Medic() { }
        public Medic(string _CNP, string _nume, int _anAbsolvire, 
            string _specializare, DateTime _dataNastere)
        {   this.cnp = _CNP;
            this.nume = _nume;
            this.anAbsolvire = _anAbsolvire;
            this.specializare = _specializare;
            this.dataNastere = _dataNastere;
        }
        public string Cnp   {get { return cnp; }
            set { cnp = value; }}
        public string Nume
        {   get { return nume; }
            set { nume = value; }
        }
        public int AnAbsolvire
        {   get { return anAbsolvire; }
            set { anAbsolvire = value; }
        }
        public string Specializare
        {   get { return specializare; }
            set { specializare = value; }
        }
        public DateTime DataNastere
        {   get { return dataNastere; }
            set { dataNastere = value; }
        }
    }
}
