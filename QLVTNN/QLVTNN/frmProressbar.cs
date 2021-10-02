using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVTNN
{
    public partial class frmProressbar : Form
    {
        public frmProressbar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if(progressBar1.Value == 300)
            {
                this.Close();
            }
        }

        private void frmProresspa_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
