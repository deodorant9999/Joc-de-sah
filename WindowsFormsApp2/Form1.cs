using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
     partial class Form1 : Form
    {
        Joc mJoc;
        PictureBox[][] mPicturebox=new PictureBox[8][];
        int i = 0,j=0;

        public Form1()
        {
            InitializeComponent();
            for(int k=0;k<8;k++)
                mPicturebox[k]= new PictureBox[8];
            mPicturebox[i][j++] = mPicture1;
            mPicturebox[i][j++] =mPicture2;
            mPicturebox[i][j++] = mPicture3;
            mPicturebox[i][j++] =mPicture4;
            mPicturebox[i][j++] =mPicture5;
            mPicturebox[i][j++] =mPicture6;
            mPicturebox[i][j++]=mPicture7;
            mPicturebox[i++][j] = mPicture8;
            j = 0;
            mPicturebox[i][j++] = mPicture9;
            mPicturebox[i][j++]=mPicture10;
            mPicturebox[i][j++] = mPicture11;
            mPicturebox[i][j++]=mPicture12;
            mPicturebox[i][j++]=mPicture13;
            mPicturebox[i][j++] = mPicture14;
            mPicturebox[i][j++] = mPicture15;
            mPicturebox[i++][j] = mPicture16;
            j = 0;
            mPicturebox[i][j++] = mPicture17;
            mPicturebox[i][j++]=mPicture18;
            mPicturebox[i][j++]=mPicture19;
            mPicturebox[i][j++]=mPicture20;
            mPicturebox[i][j++]=mPicture21;
            mPicturebox[i][j++]=mPicture22;
            mPicturebox[i][j++] = mPicture23;
            mPicturebox[i++][j]=mPicture24;
            j = 0;
            mPicturebox[i][j++]=mPicture25;
            mPicturebox[i][j++] = mPicture26;
            mPicturebox[i][j++]=mPicture27;
            mPicturebox[i][j++]=mPicture28;
            mPicturebox[i][j++]=mPicture29;
            mPicturebox[i][j++]=mPicture30;
            mPicturebox[i][j++] = mPicture31;
            mPicturebox[i++][j]=mPicture32;
            j = 0;
            mPicturebox[i][j++]=mPicture33;
            mPicturebox[i][j++] = mPicture34;
            mPicturebox[i][j++] = mPicture35;
            mPicturebox[i][j++]=mPicture36;
            mPicturebox[i][j++] = mPicture37;
            mPicturebox[i][j++]=mPicture38;
            mPicturebox[i][j++] = mPicture39;
            mPicturebox[i++][j]=mPicture40;
            j= 0;
            mPicturebox[i][j++] = mPicture41;
            mPicturebox[i][j++]=mPicture42;
            mPicturebox[i][j++] = mPicture43;
            mPicturebox[i][j++]=mPicture44;
            mPicturebox[i][j++] = mPicture45;
            mPicturebox[i][j++]=mPicture46;
            mPicturebox[i][j++]=mPicture47;
            mPicturebox[i++][j]=mPicture48;
            j = 0;
            mPicturebox[i][j++]=mPicture49;
            mPicturebox[i][j++]=mPicture50;
            mPicturebox[i][j++] = mPicture51;
            mPicturebox[i][j++]=mPicture52;
            mPicturebox[i][j++] = mPicture53;
            mPicturebox[i][j++] = mPicture54;
            mPicturebox[i][j++]=mPicture55;
            mPicturebox[i++][j]=mPicture56;
            j = 0;
            mPicturebox[i][j++] = mPicture57;
            mPicturebox[i][j++]=mPicture58;
            mPicturebox[i][j++] = mPicture59;
            mPicturebox[i][j++] = mPicture60;
            mPicturebox[i][j++]=mPicture61;
            mPicturebox[i][j++] = mPicture62;
            mPicturebox[i][j++]=mPicture63;
            mPicturebox[i][j]=mPicture64;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mPicture1_MouseClick(object sender, MouseEventArgs e)
        {
            i = 0;j = 0;
            mJoc.Muta(i,j);
        }

        private void mPicture2_MouseClick(object sender, MouseEventArgs e)
        {
            i = 0;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture3_MouseClick(object sender, MouseEventArgs e)
        {
            i=0;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture4_MouseClick(object sender, MouseEventArgs e)
        {
            i=0;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture5_MouseClick(object sender, MouseEventArgs e)
        {
            i=0 ;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture6_MouseClick(object sender, MouseEventArgs e)
        {
            i = 0;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture7_MouseClick(object sender, MouseEventArgs e)
        {
            i = 0;j=6;
            mJoc.Muta(i, j);
        }

        private void mPicture8_MouseClick(object sender, MouseEventArgs e)
        {
            i = 0;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture9_MouseClick(object sender, MouseEventArgs e)
        {
            i = 1;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture10_MouseClick(object sender, MouseEventArgs e)
        {
            i = 1;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture11_MouseClick(object sender, MouseEventArgs e)
        {
            i=1;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture12_MouseClick(object sender, MouseEventArgs e)
        {
            i = 1;j=3;
            mJoc.Muta(i, j);
        }

        private void mPicture13_MouseClick(object sender, MouseEventArgs e)
        {
            i = 1;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture14_MouseClick(object sender, MouseEventArgs e)
        {
            i=1;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture15_MouseClick(object sender, MouseEventArgs e)
        {
            i = 1;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture16_MouseClick(object sender, MouseEventArgs e)
        {
            i = 1;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture17_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture18_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture19_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture20_MouseClick(object sender, MouseEventArgs e)
        {
            i=2;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture21_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture22_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j=5;
            mJoc.Muta(i, j);
        }

        private void mPicture23_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture24_MouseClick(object sender, MouseEventArgs e)
        {
            i = 2;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture25_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture26_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture27_MouseClick(object sender, MouseEventArgs e)
        {
            i=3;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture28_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture29_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture30_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture31_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture32_MouseClick(object sender, MouseEventArgs e)
        {
            i = 3;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture33_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture34_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture35_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture36_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture37_MouseClick(object sender, MouseEventArgs e)
        {
            i=4;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture38_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture39_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture40_MouseClick(object sender, MouseEventArgs e)
        {
            i = 4;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture41_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture42_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture43_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture44_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture45_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture46_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture47_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture48_MouseClick(object sender, MouseEventArgs e)
        {
            i = 5;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture49_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture50_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture51_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture52_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture53_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture54_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture55_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture56_MouseClick(object sender, MouseEventArgs e)
        {
            i = 6;j = 7;
            mJoc.Muta(i, j);
        }

        private void mPicture57_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 0;
            mJoc.Muta(i, j);
        }

        private void mPicture58_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 1;
            mJoc.Muta(i, j);
        }

        private void mPicture59_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 2;
            mJoc.Muta(i, j);
        }

        private void mPicture60_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 3;
            mJoc.Muta(i, j);
        }

        private void mPicture61_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 4;
            mJoc.Muta(i, j);
        }

        private void mPicture62_MouseClick(object sender, MouseEventArgs e)
        {
            i=7;j = 5;
            mJoc.Muta(i, j);
        }

        private void mPicture63_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 6;
            mJoc.Muta(i, j);
        }

        private void mPicture64_MouseClick(object sender, MouseEventArgs e)
        {
            i = 7;j = 7;
            mJoc.Muta(i, j);
        }

    

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            mJoc=new Joc(mPicturebox);
            mJoc.StartJoc();
        }
    }
}
