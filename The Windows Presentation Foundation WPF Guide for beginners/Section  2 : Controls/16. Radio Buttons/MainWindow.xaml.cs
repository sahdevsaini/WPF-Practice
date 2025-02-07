using System.Windows;
using System.Windows.Media;

namespace Radio_Buttons
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rbmodi_Checked(object sender, RoutedEventArgs e)
        {
            // Safely update the background color of lbmodi
            if (lbmodi != null)
            {
                lbmodi.Background = Brushes.LightBlue;
            }
        }
        private void Rbmodi_Unchecked(object sender, RoutedEventArgs e)
        {
            // Safely update the background color of lbmodi
            if (lbmodi != null)
            {
                lbmodi.Background = Brushes.White;
            }
        }
    }
}
