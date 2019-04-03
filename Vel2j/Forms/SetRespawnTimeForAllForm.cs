using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vel2j.Forms
{
    public partial class SetRespawnTimeForAllForm : Form
    {
        public SetRespawnTimeForAllForm()
        {
            InitializeComponent();
        }

        public int RespawnTime { get; private set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.RespawnTime = (int)numericUpDown1.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
