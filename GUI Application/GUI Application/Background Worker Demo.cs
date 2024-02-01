using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class frmBackgroundWorker : Form
    {
        public frmBackgroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 0;
            for(int loop = 1; loop <= 100; loop++)
            {
                Thread.Sleep(100);
                total += loop;
                //backgroundWorker1.ReportProgress(loop);
                //Starting with 5%
                if(loop % 5 ==0)
                    backgroundWorker1.ReportProgress(loop);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            e.Result = total;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbTask.Value = e.ProgressPercentage;
            lblProgress.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                lblProgress.Text = "Processing Cancle";
            }
            else if(e.Error != null)
            {
                lblProgress.Text = e.Error.Message;
            }
            else
            {
                lblProgress.Text = "Total = " + e.Result.ToString();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                lblProgress.Text = "Worker Busy!";
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                lblProgress.Text = "There is nothing to cancle";
            }
        }
    }
}
