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

namespace Treangle_Lad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Go_Click(object sender, RoutedEventArgs e)
        {
            TreanglIF triangle = Controlers.GoControl(First.Text, Second.Text, Third.Text);
            Output(triangle);
        }

        private void Output(TreanglIF triangle)
        {
            Result.Text =
                $"{triangle.firsts} \n{triangle.seconds} \n{triangle.thirds} \n{triangle.typess} \n{triangle.exception}";
        }

    }
}
