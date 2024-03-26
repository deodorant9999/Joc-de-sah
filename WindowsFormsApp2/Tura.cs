using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Tura:Piesa
    {
        enum MUTARE
        {
            INVALID,
            TS=5,
            TDR,
            TJ,
            TST
        }
        
        public Tura() 
        {

        }
        public override int Muta(int i, int j, int ii, int ji, int c)
        {
            if(i-ii==0)
            {
                if (j - ji > 0) return (int)MUTARE.TDR;
                if (j - ji < 0) return (int)MUTARE.TST;
                return (int)MUTARE.INVALID;
            }
            if(j-ji==0)
            {
                if (i - ii > 0) return (int)MUTARE.TJ;
                if (i - ii < 0) return (int)MUTARE.TS;
                return (int)MUTARE.INVALID;
            }
            return (int)MUTARE.INVALID;
        }

    }
}
