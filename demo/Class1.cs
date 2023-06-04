using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class Demo
{
    public static void Main()
    {
        Form fm;

        fm = new Form();
        fm.Text = "ようそこC#へ！！！";

        

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c://Jin.jpg");
        pb.Parent = fm;

        Label bl;
        bl = new Label();
        bl.Text = "みみうどんを崇めよ";
        bl.Parent = fm;

        Application.Run(fm);
    }
}