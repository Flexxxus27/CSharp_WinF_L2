using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WinF_L2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2 (Object ob)
        {
            InitializeComponent();

            this.lstForm2.Items.AddRange((ob as ListBox).Items);
        }
        private void lstForm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
