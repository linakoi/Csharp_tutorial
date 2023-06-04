using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class Class
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "うんこ";
        fm.Width = 600; fm.Height = 300;

        PictureBox[,] pb = new PictureBox[3, 5];


        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                pb[i, j] = new PictureBox();
                pb[i, j].Image = Image.FromFile("C:\\jin.jpg");

                pb[i, j].Left = pb[i, j].Width * i;
                pb[i, j].Top = pb[i, j].Height * j;
                pb[i, j].Parent = fm;
            };
        };

        Application.Run(fm);
    }
}