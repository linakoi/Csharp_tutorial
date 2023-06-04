using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
class Pro5 : Form
{
    public static void Main()
    {
        Application.Run(new Pro5());
    }
    public Pro5()
    {
        this.Text = "サンプル";
        this.Width = 400;this.Height = 200;
        this.BackgroundImage = Image.FromFile("C:/Users/maiku/OneDrive/画像/icons/Resized/guri.jpg");
    }
}
