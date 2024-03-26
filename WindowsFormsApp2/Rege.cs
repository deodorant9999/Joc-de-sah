using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Rege : Piesa
    {
        enum MUTARE
        {
            INVALID,
            KVALID=21
        }
        public Rege()
        {
        }
        public override int Muta(int i, int j, int ii, int ji, int c)
        {
            switch(i-ii)
            {
                case 0:
                    {
                        switch(j-ji)
                        {
                            case -1: return (int)MUTARE.KVALID;
                            case 1: return (int)MUTARE.KVALID;
                            default: return (int)MUTARE.INVALID;
                        }
                    }
                case 1:
                    {
                        switch (j - ji)
                        {
                            case -1: return (int)MUTARE.KVALID;
                            case 0: return (int)MUTARE.KVALID;
                            case 1: return (int)MUTARE.KVALID;
                            default: return (int)MUTARE.INVALID;
                        }
                    }
                case -1: 
                    {
                        switch (j - ji)
                        {
                            case -1: return (int)MUTARE.KVALID;
                            case 0: return (int)MUTARE.KVALID;
                            case 1: return (int)MUTARE.KVALID;
                            default: return (int)MUTARE.INVALID;
                        }
                    }
                default: return (int)MUTARE.INVALID;
            }
        }

    }
}
