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

namespace Moskvina_01_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            P_txt.IsReadOnly = true;
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (nameTxt.Text != "")
            {
                if (int.TryParse(belkiTxt.Text, out int belki) && int.TryParse(uglevodiTxt.Text, out int ugl))
                {
                    if (IsParent.IsChecked == true && int.TryParse(P_txt.Text, out int p))
                    {
                        Pitanie_2 pi = new Pitanie_2(nameTxt.Text, belki, ugl, p);

                        resultTxt.Content = pi.calculateQp(pi.calculateQ());
                    }
                    else
                    {
                        Pitanie pi = new Pitanie(nameTxt.Text, belki, ugl);
                        resultTxt.Content = pi.calculateQ();

                    }
                }
                else resultTxt.Content = "Некоректные значения";
            }
            else resultTxt.Content = "Введите название";
        }

        private void IsParent_Checked(object sender, RoutedEventArgs e)
        {
            if (IsParent.IsChecked == true)
            {
                P_txt.IsReadOnly = false;
            }
            else P_txt.IsReadOnly = true;
        }
    }
}
