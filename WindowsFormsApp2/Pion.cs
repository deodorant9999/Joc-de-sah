using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
      internal class Pion:Piesa
    {
        
        public Pion()
        {  
        }
        enum MUTARE
        {
            INVALID,
            PF1,
            PF2,
            PD           
        }
        
        public override int Muta(int i, int j,int ii, int ji, int c) 
        {
            switch (c)
            {
                case (int)CULOARE.ALB:
                    {
                        if (ii == 1)
                        {
                            switch (i - ii)
                            {
                                case 2: if(j-ji==0) return (int)MUTARE.PF2; 
                                        break;
                                case 1: if (j - ji == 1 || j - ji == -1) return (int)MUTARE.PD;
                                        if (j - ji == 0) return (int)MUTARE.PF1; 
                                        break;
                                default: return (int)MUTARE.INVALID;
                            }
                        }
                        else
                        {
                            if (i - ii == 1)
                            {
                                if (j - ji == 0) return (int)MUTARE.PF1;
                                if(j - ji == 1 || j - ji == -1) return(int)MUTARE.PD;
                            }
                            else return (int)MUTARE.INVALID;
                        }
                        return (int)MUTARE.INVALID;                       
                    }
                case (int)CULOARE.NEGRU:
                    {
                        if (ii == 6)
                        {
                            switch (i - ii)
                            {
                                case -2:
                                    if (j - ji == 0) return (int)MUTARE.PF2;
                                    break;
                                case -1:
                                    if (j - ji == 1 || j - ji == -1) return (int)MUTARE.PD;
                                    if (j - ji == 0) return (int)MUTARE.PF1;
                                    break;
                                default: return (int)MUTARE.INVALID;
                            }
                        }
                        else
                        {
                            if (i - ii == -1)
                            {
                                if (j - ji == 0) return (int)MUTARE.PF1;
                                if (j - ji == 1 || j - ji == -1) return (int)MUTARE.PD;
                            }
                            else return (int)MUTARE.INVALID;
                        }
                        return (int)MUTARE.INVALID;
                    }
                default: return (int)MUTARE.INVALID;
            }
        }
    }
}
