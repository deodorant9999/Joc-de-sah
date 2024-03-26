using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Form myForm = new Form();
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Size = new System.Drawing.Size(100,100);
            //pictureBox.Image = Image.FromFile(@"C:\Users\deodo\Pictures\Screenshots\Screenshot 2023-12-06 183537.png");
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //myForm.Controls.Add(pictureBox);
            //myForm.ShowDialog();
            //pictureBox.Click += new EventHandler(test);

            /* PictureBox[,] tabla = new PictureBox[8, 8];
             tabla[0,0] = new PictureBox();
             tabla[0, 0].Image = Image.FromFile(Application.StartupPath+@"\Image\CalAlb.png");
             tabla[0, 0].Location = new System.Drawing.Point((i+ 1)*100,);
             tabla[0, 0].Click += new EventHandler(Pct_Click);

         }
         private void Pct_Click(object sender, EventArgs e)
         {
             (sender as PictureBox).Location = new System.Drawing.Point(421)
         }
            */
        }
        //public void test(object sender, EventArgs e)
        

        

    }
}
