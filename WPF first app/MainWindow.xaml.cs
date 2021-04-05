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
using System.Drawing;
using System.Windows.Shapes;
using DocumentFormat.OpenXml.Drawing;
using Xamarin.Forms.PlatformConfiguration;

namespace WPF_first_app
{
  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static Color ToColor(this uint argb)
        //{
        //    return Color.FromArgb((byte)((argb & -16777216) >> 0x18),
        //                          (byte)((argb & 0xff0000) >> 0x10),
        //                          (byte)((argb & 0xff00) >> 8),
        //                          (byte)(argb & 0xff));
        //}
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(0, 256), (byte)rand.Next(0, 256), (byte)rand.Next(0, 256)));

            if (sender is Button btn)
            {
                btn.Background = brush;
                MessageBox.Show($"My color is {brush.ToString()}","Colors",MessageBoxButton.OK,MessageBoxImage.Information);
            }

        }

        private void Btn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (sender is Button btn)
            {
                Title = btn.Content.ToString();
                btn.Visibility = Visibility.Hidden;
                
                
            }
        }
    }
}
