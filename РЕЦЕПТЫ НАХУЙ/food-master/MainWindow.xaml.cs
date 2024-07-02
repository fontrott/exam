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

namespace food
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
        List<string> soup = new List<string>() { "Борщ" };
        List<string> salad = new List<string>() { "Оливье" };
        List<string> second = new List<string>() { "Пицца" };
        List<string> dessert = new List<string>() { "Наполеон" };
        private void cb_food_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cb_food.SelectedIndex)
            {
                case 0:
                    lb_fod.ItemsSource = soup;
                    break;
                case 1:
                    lb_fod.ItemsSource = salad;
                    break;
                case 2:
                    lb_fod.ItemsSource = second;
                    break;
                case 3:
                    lb_fod.ItemsSource = dessert;
                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                if (lb_fod.SelectedItem.ToString() == "Борщ")              
                    frama.Navigate(new Uri("/Borszh.xaml", UriKind.Relative)); //frama (Frame) — это элемент управления содержимым, предоставляющий возможность перехода к содержимому и его отображения. Показывает pagee
                else if (lb_fod.SelectedItem.ToString() == "Оливье")
                    frama.Navigate(new Uri("/Olivie.xaml", UriKind.Relative));

                else if (lb_fod.SelectedItem.ToString() == "Пицца")
                    frama.Navigate(new Uri("/Pizza.xaml", UriKind.Relative));

                else if (lb_fod.SelectedItem.ToString() == "Наполеон")
                    frama.Navigate(new Uri("/Napoleon.xaml", UriKind.Relative));
            }
        }
    }