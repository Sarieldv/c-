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

namespace WPF_UI
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
        public bool IsLetter(char a)
        {
            if (((int)a>64&&(int)a<91)|| ((int)a > 96 && (int)a < 123) || (int)a==32)
            {
                return true;
            }
            return false;
        }
        public bool IsWords(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!IsLetter(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsNumber(char c)
        {
            if((int)c>47&&(int)c<58)
            {
                return true;
            }
            return false;
        }
        public bool IsStringNumbers(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!IsNumber(str[i]))
                    return false;
            }
            return true;
        }
    }
}
