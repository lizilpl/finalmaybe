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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using Microsoft.Kinect.Toolkit.FaceTracking;
using System.Drawing;
namespace fianalmaybe
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly KinectSensorChooser sensorChooser = new KinectSensorChooser();
        KinectSensor sensor;
        public MainWindow()
        {
           
            this.InitializeComponent();
           
            foreach (var potentialSensor in KinectSensor.KinectSensors)
            {
                if (potentialSensor.Status == KinectStatus.Connected)
                    this.sensor = potentialSensor;
                break;
            }
            if (this.sensor != null)
            {
                this.sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                this.sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                this.sensor.SkeletonStream.Enable();
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var FaceTrackWindow = new FaceTrackMainWindow();
            FaceTrackWindow.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var SpeechWindow = new Microsoft.Samples.Kinect.SpeechBasics.MainWindow();
            SpeechWindow.Show();
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
            this.Close();
        }

        //private void button1_MouseEnter(object sender, MouseEventArgs e)
        //{
        //   ImageBrush imageBrush = new ImageBrush();
        //   imageBrush.ImageSource = new BitmapImage(new Uri("voicecontroller_icon1.png", UriKind.Relative));
        //   button1.Background = imageBrush;

        //}

     
    }
}
