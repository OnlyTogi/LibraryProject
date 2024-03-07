using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProjesi
{
    public partial class emanetler : Form
    {
        public emanetler()
        {
            InitializeComponent();
        }

        private void btn_emanet_Click(object sender, EventArgs e)
        {
            emanetver emanetver = new emanetver();
            emanetver.ShowDialog();
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {
            teslimal teslimal = new teslimal();
            teslimal.ShowDialog();
        }
    }
}
