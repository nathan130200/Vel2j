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
    public partial class LoadingForm : Form, IProgress<int>
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        public void SetMaximum(int x)
        {
            if (pbDisplay.InvokeRequired)
                pbDisplay.Invoke(new Action<int>(SetMaximum), x);

            else
            {
                if (!(x < 0))
                    this.pbDisplay.Maximum = x;
                else
                    this.pbDisplay.Style = ProgressBarStyle.Marquee;
            }
        }

        public void Report(int value)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (this.pbDisplay.Style == ProgressBarStyle.Marquee)
                    return;

                if (value < this.pbDisplay.Maximum)
                {
                    this.pbDisplay.Value += value;

                    if (value >= this.pbDisplay.Maximum)
                        this.NotifyOnComplete();
                }
                else
                    this.NotifyOnComplete();
            }));
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }

        bool got;

        void NotifyOnComplete()
        {
            if (got)
                return;

            got = true;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
