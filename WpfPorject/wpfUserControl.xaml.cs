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

namespace WpfPorject
{
    /// <summary>
    /// Interação lógica para WpfUC.xam
    /// </summary>
    public partial class WpfUC : UserControl
    {
        public Button btn;
        public TextBox tbx;

        public WpfUC()
        {
            InitializeComponent();

            // incializa passando os objetos do form para variáveis.
            btn = btnTest;
            tbx = txtTest;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Text: " + btnTest.Content + "TextBox: " + txtTest.Text);
        }
    }
}
