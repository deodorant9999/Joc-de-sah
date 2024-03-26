using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Cal : Piesa
    {
        enum MUTARE
        {
            INVALID,
            CVALID=4
        }
        
        public Cal() 
        {
            
        }
        public override int Muta(int i, int j,int ii, int ji, int c)
        {
            switch(i-ii)
            {
                case 1:
                    {
                        switch(j-ji)
                        {
                            case -2: return (int)MUTARE.CVALID;
                            case 2: return (int)MUTARE.CVALID;
                            default: return (int)MUTARE.INVALID;
                        }
                    }
                case -1:
                    {
                        switch(j-ji) 
                        {
                            case -2: return (int)MUTARE.CVALID;
                            case 2: return (int)MUTARE.CVALID;
                            default: return (int)MUTARE.INVALID;
                        }
                    }
                case 2:
                    switch(j-ji)
                    {
                        case -1: return (int)MUTARE.CVALID;
                        case 1: return (int)MUTARE.CVALID;
                        default: return (int)MUTARE.INVALID;
                    }
                case -2:
                    {
                        switch(j-ji) 
                        {
                            case -1: return (int)MUTARE.CVALID;
                            case 1: return (int)MUTARE.CVALID;
                            default: return (int)MUTARE.INVALID;
                        }
                    }
            }
            return (int)MUTARE.INVALID;
        }
    }
}
