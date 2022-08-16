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

namespace WpfApp1
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

        private void DO(chihe temp)
        {
            MessageBox.Show(temp.chi());
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            chen cc = new chen();
            sun ss = new sun();
            DO(cc);
            DO(ss);
        }
    }
    //第一个人陈
    class chen:chihe
    {
        public int Name { get; set; }

        public string chi()
        {
           return "chenchi";
        }

        public string he()
        {
            return "chenhe";
        }
    }
    //第一个人孙
    class sun : chihe
    {
        public int Name { get; set; }

        public string chi()
        {
            return "sunchi";
        }

        public string he()
        {
            return "sunhe";
        }
    }
    //吃喝
    interface chihe
    {
        string chi();
        string he();
    }
}
