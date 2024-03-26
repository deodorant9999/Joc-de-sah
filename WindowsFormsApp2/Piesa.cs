using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Piesa
    {
        
        protected enum CULOARE
        {
            ALB=1,
            NEGRU
        }
        enum TIP
        {
            PION = 0,
            TURA,
            CAL,
            NEBUN,
            REGINA,
            REGE
        }
        
        public Piesa()
        {
        }
        public virtual int Muta(int i,int j,int ii, int ji, int c)
        {
            return 0;
        }

    }
}
