using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Bloc
    {
        
        int mTip;
        int mCuloare;
        enum TIP
        {
            PION = 0,
            TURA,
            CAL,
            NEBUN,
            REGINA,
            REGE,
            GOL
        }
        protected enum CULOARE
        {
            GOL=0,
            ALB,
            NEGRU
        }
        
        public Bloc( int mTip,int mCuloare)
        {
            
            this.mTip = mTip;
            this.mCuloare=mCuloare;
        }
        public Bloc() { mTip = (int)TIP.GOL; mCuloare = (int)CULOARE.GOL; }
        public int getTip() { return mTip; }
        public int getCuloare() {  return mCuloare; }
        
    }
}
