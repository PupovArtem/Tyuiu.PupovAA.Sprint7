using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SpirinIS.Sprint7.Project.V9
{
    public partial class FormAbout_PAA : Form
    {
        public FormAbout_PAA()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void buttonCloseAbout_PAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
