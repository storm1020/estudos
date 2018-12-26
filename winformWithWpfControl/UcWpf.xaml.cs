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

namespace winformWithWpfControl
{
    /// <summary>
    /// Interação lógica para wpfUserControls.xam
    /// </summary>
    public partial class UcWpf : UserControl
    {
        public Button btn;
        public TextBox tbx;
        public Button btnC;

        public UcWpf()
        {
            InitializeComponent();
            btn = btnTest;
            tbx = tbxTest;
            btnC = btnCria;
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Botão no WPF: " + btnTest.Content + "\r"
                            + "Text no TextBox WPF: " + tbxTest.Text + "Btn Cria: " + btnCria.Content);
        }

        private void BtnCria_Click(object sender, RoutedEventArgs e)
        {
            btnCria.Content = "BRABO";
        }
    }
}
