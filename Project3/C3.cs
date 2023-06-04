using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class C3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "ねみー！";
        fm.Width = 500;
        fm.Height = 500;

        Label lb = new Label();

        lb.Height = fm.Height;
        lb.Width =  fm.Width;

        int i = 1;
        do
        {
            lb.Text += "私は今日" + i +"度寝する\n";
            i++;
        }while (i < 11) ;

        lb.Parent = fm;

        Application.Run(fm);
    }

}