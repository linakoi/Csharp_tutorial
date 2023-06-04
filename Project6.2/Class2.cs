using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Sample6_2 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample6_2());
    }

    public Sample6_2()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 100;

        lb = new Label();
        lb.Text = "いらっしゃいませ";

        lb.Width = 150;
        bt = new Button();
        bt.Text = "購入";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        bt.Parent = this;
        lb.Parent = this;

        bt.Click += new EventHandler(bt_Click);

    }

    public void bt_Click(object sender,EventArgs e)
    {
        lb.Text = "ありがとうございます";
    }


}



