using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace fianalmaybe
{
    /// <summary>
    /// FaceTrackMainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FaceTrackMainWindow : Window
    {
        public FaceTrackMainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //var login = new login();
            //login.Show();
            var facetrackmainwindow = new FaceTracking3D.MainWindow();
            facetrackmainwindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Normal;
            this.WindowStyle = System.Windows.WindowStyle.None;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            this.Topmost = true;

            this.Left = 0.0;
            this.Top = 0.0;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var newmainwindow = new MainWindow();
            newmainwindow.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var newmainwindow = new Monitor.MainWindow();
            newmainwindow.Show();
            this.Close();
        }
    }
}
