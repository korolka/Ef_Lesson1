using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EF_Ex3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products1;
        public MainWindow()
        {
            InitializeComponent();
            products1 = new List<Product>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(Lesson1DbContext db = new Lesson1DbContext())
            {
                table.ItemsSource= db.Products.ToList();
            }
        }
    }
}
