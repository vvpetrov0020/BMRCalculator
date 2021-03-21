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

namespace BMRCalculator
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

        bool gender;

        private void btn_male_Click(object sender, RoutedEventArgs e)
        {
            gender = true;
            btn_male.IsEnabled = false;
            btn_female.IsEnabled = true;
        }

        private void btn_female_Click(object sender, RoutedEventArgs e)
        {
            gender = false;
            btn_male.IsEnabled = true;
            btn_female.IsEnabled = false;
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            double bmr = 0;

            if (gender)
            {
                bmr = 66 + (13.7 * Convert.ToDouble(txtbox_weight.Text)) + (5 * Convert.ToDouble(txtbox_height.Text)) - (6.8 * Convert.ToDouble(txtbox_age.Text));
            }

            else
            {
                bmr = 655 + (9.6 * Convert.ToDouble(txtbox_weight.Text)) + (1.8 * Convert.ToDouble(txtbox_height.Text)) - (4.7 * Convert.ToDouble(txtbox_age.Text));
            }

            txtblock_result.Text = Convert.ToString(bmr);
            tblck_sid.Text = "Сидячий образ: " + Convert.ToString(bmr * 1.2);
            tblck_min.Text = "Маленькая активность: " +  Convert.ToString(bmr * 1.375);
            tblck_mid.Text = "Средняя активность: " + Convert.ToString(bmr * 1.55);
            tblck_strong.Text = "Сильная активность:" + Convert.ToString(bmr * 1.725);
            tblck_max.Text = "Максимальная активность: " + Convert.ToString(bmr * 1.9);


        }

    }
}
