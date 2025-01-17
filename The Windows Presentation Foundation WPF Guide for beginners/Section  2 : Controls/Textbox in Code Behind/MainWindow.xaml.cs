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

namespace Textblock_in_code_Behind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock MyTb = new TextBlock();
            MyTb.Text = "Hello World";
            MyTb.Inlines.Add("This is added using Inlines");
            MyTb.Inlines.Add(new Run("Run the code which code behinnd")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            MyTb.TextWrapping = TextWrapping.Wrap;
            MyTb.Foreground = Brushes.SeaGreen;
            this.Content = MyTb;
        }
    }
}
