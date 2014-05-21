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

namespace EventlogViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            datePicker_from.SelectedDate = DateTime.Today;
            datePicker_to.SelectedDate = DateTime.Today;

        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            textBox_output.AppendText("Start Pressed\n");
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            textBox_output.Clear();
        }



    }
}
