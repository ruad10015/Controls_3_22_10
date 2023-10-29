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

namespace Controls
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
            //myLabel.Content = "OKAY";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
          //  myLabel.Content = "NO";
        }

        private void bakuRdb_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton rb)
            {
                rb.Content = rb.Content + " Selected";
            }
        }

        private void bakuRdb_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb)
            {
                rb.Content = rb.Content.ToString().Split(' ')[0];
            }
        }
        public int Count { get; set; } = 0;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            ++Count;
           // btn.Content = Count;
        }

        private void repeat_btn_Click(object sender, RoutedEventArgs e)
        {
            ++Count;
          //  repeat_btn.Content = Count;
        }

        private void togle_btn_Click(object sender, RoutedEventArgs e)
        {
            ++Count;
            //togle_btn.Content = Count;
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
