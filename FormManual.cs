using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limiari
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }

        private void FormManual_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"C:\Users\wesle\source\repos\ImageProcessing\manual\manual.html");
        }
    }
}
