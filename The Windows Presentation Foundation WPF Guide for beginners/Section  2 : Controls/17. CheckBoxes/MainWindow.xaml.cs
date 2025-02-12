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

namespace Chekboxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            lbcheese.Background = Brushes.LightPink;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            lbcheese.Background = Brushes.White;
        }

        private void cbparent_checked(object sender, RoutedEventArgs e)
        {
            bool intVal = (cbParent.IsChecked == true);
            cbcheese.IsChecked = intVal;
            cbOnion.IsChecked = intVal;
            cbTomato.IsChecked = intVal;
            cbPanner.IsChecked = intVal;

        }


        // Event to handle individual checkbox changes to update the parent checkbox state
        private void ChildCheckbox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            // Update the parent checkbox state based on the state of the child checkboxes
            cbParent.IsChecked = cbcheese.IsChecked == true &&
                                 cbOnion.IsChecked == true &&
                                 cbTomato.IsChecked == true &&
                                 cbPanner.IsChecked == true;

            // If any checkbox is unchecked, the parent should be unchecked
            if (cbcheese.IsChecked == false || cbOnion.IsChecked == false ||
                cbTomato.IsChecked == false || cbPanner.IsChecked == false)
            {
                cbParent.IsChecked = false;
            }
        }

    }
}
