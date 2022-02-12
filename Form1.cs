using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            rH_ProgressBar1.Increment(4);
            if (rH_ProgressBar1.Value == 100)
            {
                timer1.Enabled=false;
                logsign fm2 = new logsign();
                fm2.Show();
                this.Hide();
                
            }
        }
    }
}
