using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class C3
{
    public static void Main(){
        Form fm = new Form();
        fm.Text = "おやすみ";

        fm.Width = 500;
        fm.Height = 500;

        Label bl = new Label();
        bl.Text = "もうねろよ";

        Label bl2 = new Label();
        bl2.Text = "はい寝ます";
        bl2.Parent = fm;
        bl2.Left = bl.Width + 100;

        bl.Parent = fm;
        Application.Run(fm);
    }
}
