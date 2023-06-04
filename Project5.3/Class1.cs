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
        fm.Text = "だからサンプルじゃないって";
        fm.Width = 300;
        fm.Height = 200;

        PictureBox[] pb = new PictureBox[2];

        for (int i = 0;i < pb.Length;i++)
        {
            pb[i] = new PictureBox();
            pb[i].Parent = fm;
        }

        Car[] c = new Car[2];
        
        c[0] = new Car();
        c[1] = new RacingCar();

        for(int i = 0;i < c.Length; i++)
        {
            c[i].Move();
            pb[i].Image = c[i].GetImage();
            pb[i].Top = c[i].Top;
            pb[i].Left = c[i].Left;
        }

        Application.Run(fm);
    }
}

class Car
{
    private Image img;
    protected int top;
    protected int left;
    public static int count = 0;

    public Car()
    {
        count++;
        img = Image.FromFile("C://jin.jpg");
        top = 0;
        left = 0;
    }
    public static string CountCar()
    {
        return "車は" + count + "台あります";
    }
    virtual public void Move()
    {
        top += 10;
        left += 10;
    }
    
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
    }
    public int Top
    {
        set { top = value; }
        get { return top; }
    }

    public int Left
    {
        set { left = value; }
        get { return left; }
    }

}

class RacingCar : Car
{
    override public void Move()
    {
        top += 100;
        left += 100;
    }
}