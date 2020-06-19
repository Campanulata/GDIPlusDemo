using Microsoft.Win32;
using pic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Pic pic = new Pic();
        public MainWindow()
        {
            InitializeComponent();
            pic.FontName = "微软雅黑";
            pic.Top = pic.Bottom = pic.BothSides = "100";
            pic.Scale = "1.3";
            DataContext = pic;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pic.Save();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var f = new OpenFileDialog();
            f.ShowDialog();
            string path = f.FileName;
            textImg.Text = @path;
            pic.ImgPath = @path;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Campanulata/GDIPlusDemo");
        }
    }
}
