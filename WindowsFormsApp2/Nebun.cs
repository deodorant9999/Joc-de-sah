using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Nebun: Piesa
    {
        enum MUTARE
        {
            INVALID,
            NSTS=9,
            NDRS,
            NSTJ,
            NDRJ,
        }

        public Nebun()
        {
        }
        public override int Muta(int i, int j, int ii, int ji, int c)
        {
            if(i-ii==j-ji)
            {
                if (i - ii < 0 && j - ji < 0) return (int)MUTARE.NSTS;               
                if (i - ii > 0 && j - ji > 0) return (int)MUTARE.NDRJ;
            }
            if(ji+ii==j+i)
            {
                if (i - ii < 0 && j - ji > 0) return (int)MUTARE.NDRS;
                if (i - ii > 0 && j - ji < 0) return (int)MUTARE.NSTJ;
            }
            return (int)MUTARE.INVALID;
        }

    }
}
