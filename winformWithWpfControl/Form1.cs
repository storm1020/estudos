using System;
using System.Windows.Forms;
using wpf = winformWithWpfControl;

namespace winformWithWpfControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void winformButton_Click(object sender, EventArgs e)
        {
            wpf.UcWpf uc = elementHost1.Child as wpf.UcWpf;
            MessageBox.Show("Botão no WPF: " + uc.btn.Content + "\r" + "Textbox no WPF: " + uc.tbx.Text + "\r" + uc.btnCria.Content);
        }
    }
}
