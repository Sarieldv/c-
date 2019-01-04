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
    /// Interaction logic for GetFullName.xaml
    /// </summary>
    public partial class GetFullName : UserControl
    {
        public GetFullName()
        {
            InitializeComponent();
        }

        private void InputLastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (!Utilities.IsWords(textBox.Text))
            {

            }
        }
    }
}
