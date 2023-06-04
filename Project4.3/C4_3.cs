using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class C4_3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "黙れ";

        fm.Width = 250;fm.Height = 100;

        Label lb = new Label();
        lb.Height = fm.Height;
        lb.Width = fm.Width;

        string[] str = new string[3] {"鉛筆","消しゴム","定規"};

        foreach(string s in str)
        {
            lb.Text += s + "\n";
        }

        lb.Parent = fm;

        Application.Run(fm);
    }

}