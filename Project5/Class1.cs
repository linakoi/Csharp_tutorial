using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

class Class1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプルではない";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();

        Car c = new Car();
        c.Move();
        c.Move();

        pb.Image = c.img;
        pb.Top = c.top;
        pb.Left = c.left;

        pb.Parent = fm;

        Application.Run(fm);
    }
}

class Car
{
    public Image img;
    public int top;
    public int left;
    public Car()
    {
        img = Image.FromFile("C://jin.jpg");
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top += 10;
        left += 10;
    }
}