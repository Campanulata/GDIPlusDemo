using System;
using System.Collections.Generic;
using System.Drawing;

namespace pic
{
    public class Pic
    {
        public string ImgPath { get; set; }
        public string Top { get; set; }
        public string BothSides { get; set; }
        public string Bottom { get; set; }
        public string[] ListName { get; set; }
        public string Names { get; set; }
        public string FontName { get; set; }
        public string Column { get; set; }
        public string Row { get; set; }
        public string Scale { get; set; }
        public Pic()
        {
        }
        public void Save()
        {
            Image image = Image.FromFile(@ImgPath);
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            //文字区域宽高
            float stringHeight = image.Height - float.Parse(Top) - float.Parse(Bottom);
            float stringWidth = image.Width - 2 * float.Parse(BothSides);
            //↖️↘️
            float x1 = float.Parse(BothSides);
            float y1 = float.Parse(Top);
            //间隔
            float xSpace = stringWidth / float.Parse(Column);
            float ySpace = stringHeight / float.Parse(Row);
            ListName = Names.Split(new string[] { "\r\n" },StringSplitOptions.None);
            for (int i = 0; i < int.Parse(Row); i++)//按行打印
            {
                float y = i * ySpace + y1;//计算当前行的纵坐标

                for (int j = 0; j < int.Parse(Column); j++)
                {
                    int num = i* int.Parse(Column) + j + 1;//第n个元素
                    //计算坐标
                    float x = j * xSpace + x1;
                    Point p = new Point((int)x, (int)y);//坐标

                    if (num>ListName.Length)
                    {
                        break;
                    }
                    else
                    {
                        graphics.DrawString(ListName[num-1], new Font(FontName, float.Parse(Scale)* 0.2f*stringHeight/int.Parse(Row), FontStyle.Bold), new SolidBrush(Color.Black), p);

                    }
                }
            }
            string output=ImgPath.Replace(@".png", @"副本.png");
            bitmap.Save(output);

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
            //    Point p = new Point(i * 20, 0);

            //    graphics.DrawString(str[i].ToString(), new Font(myfont[i], 16, FontStyle.Bold), new SolidBrush(colors[i]), p);
            //}
            //bitmap.Save(@"/Users/tylor/Desktop/1.png");

        }
    }
}
