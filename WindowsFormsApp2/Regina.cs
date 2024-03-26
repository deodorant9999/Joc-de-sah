using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp2.Piesa;

namespace WindowsFormsApp2
{
    internal class Regina:Piesa
    {
        enum MUTARE
        {
            INVALID,
            QST=13,
            QSTS,
            QS,
            QDRS,
            QDR,
            QDRJ,
            QJ,
            QSTJ
        }
        public Regina()
        {

        }
        public override int Muta(int i, int j, int ii, int ji, int c)
        {
            if (i - ii == 0)
            {
                if (j - ji > 0) return (int)MUTARE.QDR;
                if (j - ji < 0) return (int)MUTARE.QST;
                return (int)MUTARE.INVALID;
            }
            if (j - ji == 0)
            {
                if (i - ii > 0) return (int)MUTARE.QJ;
                if (i - ii < 0) return (int)MUTARE.QS;
                return (int)MUTARE.INVALID;
            }
            if (i - ii == j - ji)
            {
                if (i - ii < 0 && j - ji < 0) return (int)MUTARE.QSTS;
                
                if (i - ii > 0 && j - ji > 0) return (int)MUTARE.QDRJ;
            }
            if (ji + ii == j + i)
            {
                if (i - ii < 0 && j - ji > 0) return (int)MUTARE.QDRS;
                if (i - ii > 0 && j - ji < 0) return (int)MUTARE.QSTJ;
            }
            return (int)MUTARE.INVALID;
        }
    }
}
