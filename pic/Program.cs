using System;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Printing;
namespace pic
{
    class Program
    {
        static void Main(string[] args)
        {
            Pic pic = new Pic();
            pic.BothSides = "1";
            pic.Bottom = "1";
            pic.Top = "1";
            pic.ImgPath = @"/Users/tylor/Desktop/img.jpeg";
            pic.FontName = "微软雅黑";
            pic.Column = "2";
            pic.Row = "8";
            pic.Save();
            //Console.WriteLine("Hello World!");
            //Image image = Image.FromFile(@"/Users/tylor/Desktop/img.jpeg");
            //Bitmap bitmap = new Bitmap(image.Width, image.Height);
            //Graphics graphics = Graphics.FromImage(bitmap);
            //Random random = new Random();
            //string str = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    int x = random.Next(0, 10);
            //    str += x;
            //}
            
            //string[] myfont = { "宋体", "仿宋", "微软雅黑", "楷书", "黑体" };
            //Color[] colors = { Color.Red, Color.Green, Color.Black, Color.Blue, Color.Yellow };
            //for (int i = 0; i < 5; i++)
            //{
            //    Point p = new Point(i * 20, 0) ;

            //    graphics.DrawString(str[i].ToString(), new Font(myfont[i], 16, FontStyle.Bold), new SolidBrush(colors[i]), p);
            //}
            //bitmap.Save(@"/Users/tylor/Desktop/1.png");
        }
    }
}
