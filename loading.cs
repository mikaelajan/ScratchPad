using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try1234
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else 
            {
                timer1.Stop();
                
                this.Hide();
                HomePage home = new HomePage();
                home.ShowDialog();
            }

        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
