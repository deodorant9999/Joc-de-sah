using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Joc
    {
        int aMutare;
        bool aRand;
        Bloc[][] mTabla;
        Piesa[] mPiese;
        PictureBox[][] mPicturebox;
        int i, j;
        int aSfarsit=0;
        enum SFARSIT
        {
            ALB=1,
            NEGRU,
            EGALITATE,
            PAT
        }
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
        enum CULOARE
        {
            GOL=0,
            ALB,
            NEGRU
        }
        enum MUTARE
        {
            INVALID,
            PF1,
            PF2,
            PD,
            CVALID,
            TS,
            TDR,
            TJ,
            TST,
            NSTS,
            NDRS,
            NSTJ,
            NDRJ,
            QST,
            QSTS,
            QS,
            QDRS,
            QDR,
            QDRJ,
            QJ,
            QSTJ,
            KVALID
        }
        public Joc(PictureBox[][] mPicturebox)
        {
            aMutare = 0;
            aRand = true;
            mPiese = new Piesa[6];
            this.mPicturebox = mPicturebox;
        }

        void StergePiese()
        {
            for (int i = 2; i < 6; i++)
                for (int j = 0; j < 8; j++)
                    mPicturebox[i][j].Image = null;
        }
        void InitTabla()
        {
            mTabla = new Bloc[8][];
            for (int i = 0; i < 8; i++)
                mTabla[i] = new Bloc[8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    mTabla[i][j] = new Bloc();    
                
            int k = 0, ok = 0;

            for (int i = 0; i < 8; i++)
            {
                if (i < 5) k++;
                else if (ok == 0) { ok = 1; k = 3; }
                else k--;
                mTabla[0][i]=new Bloc(k,(int)CULOARE.ALB);
                mTabla[7][i] = new Bloc(k, (int)CULOARE.NEGRU);
            }

            k = 0;

            for (int i = 0; i < 8; i++)
            {
                mTabla[1][i] = new Bloc(k, (int)CULOARE.ALB);
                mTabla[6][i] = new Bloc(k, (int)CULOARE.NEGRU);
            }
        }
        void InitPiese()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                mPiese[i] = new Piesa();
                switch (i)
                {
                    case (int)TIP.PION: { mPiese[i] = new Pion(); break; }
                    case (int)TIP.TURA: { mPiese[i] = new Tura(); break; }
                    case (int)TIP.CAL: { mPiese[i] = new Cal(); break; }
                    case (int)TIP.NEBUN: { mPiese[i] = new Nebun(); break; }
                    case (int)TIP.REGINA: { mPiese[i] = new Regina(); break; }
                    case (int)TIP.REGE: { mPiese[i] = new Rege(); break; }
                }
            }

        }
        void AfisarePiese()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    switch (mTabla[i][j].getTip())
                    {
                        case (int)TIP.PION:
                            switch (mTabla[i][j].getCuloare())
                            {
                                case (int)CULOARE.ALB: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\PawnW.png"); break;
                                case (int)CULOARE.NEGRU: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\PawnB.png"); break;
                            }
                            break;
                        case (int)TIP.TURA:
                            switch (mTabla[i][j].getCuloare())
                            {
                                case (int)CULOARE.ALB: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\RookW.png"); break;
                                case (int)CULOARE.NEGRU: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\RookB.png"); break;
                            }
                            break;
                        case (int)TIP.CAL:
                            switch (mTabla[i][j].getCuloare())
                            {
                                case (int)CULOARE.ALB: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KnightW.png"); break;
                                case (int)CULOARE.NEGRU: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KnightB.png"); break;
                            }
                            break;
                        case (int)TIP.NEBUN:
                            switch (mTabla[i][j].getCuloare())
                            {
                                case (int)CULOARE.ALB: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\BishopW.png"); break;
                                case (int)CULOARE.NEGRU: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\BishopB.png"); break;
                            }
                            break;
                        case (int)TIP.REGINA:
                            switch (mTabla[i][j].getCuloare())
                            {
                                case (int)CULOARE.ALB: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\QueenW.png"); break;
                                case (int)CULOARE.NEGRU: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\QueenB.png"); break;
                            }
                            break;
                        case (int)TIP.REGE:
                            switch (mTabla[i][j].getCuloare())
                            {
                                case (int)CULOARE.ALB: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KingW.png"); break;
                                case (int)CULOARE.NEGRU: mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KingB.png"); break;
                            }
                            break;
                            
                    }
        }
        public void StartJoc()
        {
            StergePiese();
            InitTabla();
            InitPiese();
            AfisarePiese();
            i = j = -1;
        }
        void MutaJ1(int i,int j ,int t, int c)
        {
            if (mTabla[i][j].getTip() == (int)TIP.REGE)
                if (c == (int)CULOARE.ALB) aSfarsit = (int)SFARSIT.ALB;
                else aSfarsit=(int)SFARSIT.NEGRU;
            mPicturebox[this.i][this.j].Image = null;
            mTabla[i][j] = new Bloc(t, c);
            mTabla[this.i][this.j] = new Bloc();          
            this.i = this.j = -1;
            aRand = !aRand;
            aMutare++;
        }
        void MutaJ(int i, int j, int t,int c)
        {
            switch (t)
            {
                case (int)TIP.PION:
                    switch (c)
                    {
                        case (int)CULOARE.ALB:
                        {
                            mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\PawnW.png");
                            MutaJ1(i, j, t, c);
                            break;
                        }
                        case (int)CULOARE.NEGRU:
                        {
                             mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\PawnB.png");
                             MutaJ1(i, j, t, c);
                             break;
                        }
                    }
                    break;
                case (int)TIP.CAL:
                    switch(c)
                    {
                        case (int)CULOARE.ALB:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KnightW.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                        case (int)CULOARE.NEGRU:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KnightB.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                    }
                    break;
                case (int)TIP.TURA:
                    switch (c)
                    {
                        case (int)CULOARE.ALB:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\RookW.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                        case (int)CULOARE.NEGRU:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\RookB.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                    }
                    break;
                case (int)TIP.NEBUN:
                    switch (c)
                    {
                        case (int)CULOARE.ALB:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\BishopW.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                        case (int)CULOARE.NEGRU:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\BishopB.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                    }
                    break;
                case (int)TIP.REGINA:
                    {
                        switch (c)
                        {
                            case (int)CULOARE.ALB:
                                {
                                    mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\QueenW.png");
                                    MutaJ1(i, j, t, c);
                                    break;
                                }
                            case (int)CULOARE.NEGRU:
                                {
                                    mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\QueenB.png");
                                    MutaJ1(i, j, t, c);
                                    break;
                                }

                        }
                        break;
                    }
                case (int)TIP.REGE:
                    switch(c)
                    {
                        case (int)CULOARE.ALB:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KingW.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                        case (int)CULOARE.NEGRU:
                            {
                                mPicturebox[i][j].Image = (Image)new Bitmap("C:\\proiect\\KingB.png");
                                MutaJ1(i, j, t, c);
                                break;
                            }
                    }
                    break;
            }

        }
        public void Muta (int i, int j)
        {
            int mutare;
            if (this.i >= 0)
            {                
                    if (this.i != i || this.j != j)                   
                    {
                    if (mTabla[i][j].getCuloare() == mTabla[this.i][this.j].getCuloare())
                    {
                        this.i = i;
                        this.j = j;
                    }
                    else
                    {
                        int t, c;
                        t = mTabla[this.i][this.j].getTip();
                        c = mTabla[this.i][this.j].getCuloare();
                        mutare = mPiese[t].Muta(i, j, this.i, this.j, c);
                        switch (mutare)
                        {
                            case (int)MUTARE.PF2:
                                {
                                    switch (c)
                                    {
                                        case (int)CULOARE.ALB:
                                            {

                                                if (mTabla[i][j].getTip() == (int)TIP.GOL && mTabla[i - 1][j].getTip() == (int)TIP.GOL)                                                
                                                    MutaJ(i, j, t, c);                                                                                                 
                                                break;
                                            }
                                        case (int)CULOARE.NEGRU:
                                            {
                                                if (mTabla[i][j].getTip() == (int)TIP.GOL && mTabla[i + 1][j].getTip() == (int)TIP.GOL)                                               
                                                    MutaJ(i, j, t, c);                                               
                                                break;
                                            }
                                        default: break;
                                    }
                                    break;
                                }
                            case (int)MUTARE.PF1:
                                {
                                    if (mTabla[i][j].getTip() == (int)TIP.GOL)                                   
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.PD:
                                {

                                    if (mTabla[i][j].getCuloare() != c && mTabla[i][j].getCuloare() != (int)CULOARE.GOL)                                                                                
                                            MutaJ(i, j, t, c);                                                                                    
                                    break;
                                }
                            case (int)MUTARE.CVALID:
                                if (mTabla[i][j].getCuloare() != c)                                
                                    MutaJ(i, j, t, c);                                                                   
                                break;
                            case (int)MUTARE.TST:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.j - 1; k >= j; k--)
                                        if (mTabla[i][k].getCuloare() != (int)CULOARE.GOL)
                                            if (k == j && mTabla[i][k].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                   
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.TS:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.i - 1; k >= i; k--)
                                        if (mTabla[k][j].getCuloare() != (int)CULOARE.GOL)
                                            if (k == i && mTabla[k][j].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.TDR:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.j + 1; k <= j; k++)
                                        if (mTabla[i][k].getCuloare() != (int)CULOARE.GOL)
                                            if (k == j && mTabla[i][k].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.TJ:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.i + 1; k <= i; k++)
                                        if (mTabla[k][j].getCuloare() != (int)CULOARE.GOL)
                                            if (k == i && mTabla[k][j].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                               
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.NSTS:
                                {
                                    bool ok = true;
                                    bool ok1 = true;
                                    int x, y;
                                    for (x = this.i + 1, y = this.j - 1; x <= i && y >= j; x++, y--)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                         
                                    break;
                                }
                            case (int)MUTARE.NDRS:
                                {
                                    bool ok = true, ok1 = true;
                                    int x, y;
                                    for (x = this.i - 1, y = this.j + 1; x >= i && y <= j; x--, y++)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                   
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.NSTJ:
                                {
                                    bool ok = true, ok1 = true;
                                    int x, y;
                                    for (x = this.i + 1, y = this.j - 1; x <= i && y >= j; x++, y--)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.NDRJ:
                                {
                                    bool ok = true, ok1 = true;
                                    int x, y;
                                    for (x = this.i + 1, y = this.j + 1; x <= i && y <= j; x++, y++)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                               
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                          
                                    break;
                                }
                            case (int)MUTARE.QST:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.j - 1; k >= j; k--)
                                        if (mTabla[i][k].getCuloare() != (int)CULOARE.GOL)
                                            if (k == j && mTabla[i][k].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.QSTS:
                                {
                                    bool ok = true;
                                    bool ok1 = true;
                                    int x, y;
                                    for (x = this.i - 1, y = this.j - 1; x >= i && y >= j; x--, y--)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                               
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.QS:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.i - 1; k >= i; k--)
                                        if (mTabla[k][j].getCuloare() != (int)CULOARE.GOL)
                                            if (k == i && mTabla[k][j].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                               
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                   
                                        MutaJ(i, j, t, c);                                                                          
                                    break;
                                }
                            case (int)MUTARE.QDRS:
                                {
                                    bool ok = true, ok1 = true;
                                    int x, y;
                                    for (x = this.i - 1, y = this.j + 1; x >= i && y <= j; x--, y++)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.QDR:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.j + 1; k <= j; k++)
                                        if (mTabla[i][k].getCuloare() != (int)CULOARE.GOL)
                                            if (k == j && mTabla[i][k].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                            case (int)MUTARE.QDRJ:
                                {
                                    bool ok = true, ok1 = true;
                                    int x, y;
                                    for (x = this.i + 1, y = this.j + 1; x <= i && y <= j; x++, y++)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                               
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.QJ:
                                {
                                    bool ok = true, ok1 = true;
                                    for (int k = this.i + 1; k <= i; k++)
                                        if (mTabla[k][j].getCuloare() != (int)CULOARE.GOL)
                                            if (k == i && mTabla[k][j].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                               
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.QSTJ:
                                {
                                    bool ok = true, ok1 = true;
                                    int x, y;
                                    for (x = this.i + 1, y = this.j - 1; x <= i && y >= j; x++, y--)
                                        if (mTabla[x][y].getCuloare() != (int)CULOARE.GOL)
                                            if (x == i && y == j && mTabla[x][y].getCuloare() != c)
                                            {
                                                MutaJ(i, j, t, c);                                                
                                                ok1 = false;
                                            }
                                            else { ok = false; break; }
                                    if (ok && ok1)                                    
                                        MutaJ(i, j, t, c);                                                                           
                                    break;
                                }
                            case (int)MUTARE.KVALID:
                                {
                                    if (mTabla[i][j].getCuloare() != c)                                    
                                        MutaJ(i, j, t, c);                                                                            
                                    break;
                                }
                        }
                    }
                    }                   
            }
            else
            {
                if (aMutare == 0)
                {
                    if (mTabla[i][j].getCuloare() == (int)CULOARE.ALB) { this.i = i; this.j = j; }
                }
                else switch(aRand)
                    {
                        case true:
                            if (mTabla[i][j].getCuloare() == (int)CULOARE.ALB) { this.i = i; this.j = j; }
                            break;
                        case false: 
                            if(mTabla[i][j].getCuloare() == (int)CULOARE.NEGRU) { this.i = i;this.j = j; }
                            break;
                    }
                
            }
            //if(aSfarsit !=0)
                
       
        }
        
    }
}
