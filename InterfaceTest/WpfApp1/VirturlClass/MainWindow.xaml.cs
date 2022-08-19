using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace VirturlClass
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 向上转型：将子类对象转为父类对象。此处父类对象可以是接口或抽象类。
            //抽象类
            Annimal amn = new Dog();
            amn.Eat();
            //接口
            Anmim amnn = new Cat();
            amnn.Eat();
        }
    }
    class Dog:Annimal
    {
     public  override void Eat()
        {
            Debug.WriteLine("Dog Eat!");
            Trace.WriteLine("123");
        }
        void Small()
        {
            Console.WriteLine("Dog small!");
        }
    }
    class Cat: Anmim
    {
        public void Eat()
        {
            Trace.WriteLine("Cat eat");
        }
        void Drink()
        {
            Trace.WriteLine("Cat Drink");
        }
    }
    interface Anmim
    {
        public void Eat();
    }
     class Annimal
    {
        public virtual void Eat()
        {
            Console.WriteLine("nomal eat");
        }
    }

}
