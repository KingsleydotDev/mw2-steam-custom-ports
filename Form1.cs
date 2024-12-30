using Memory;
using System.ComponentModel;

namespace MW2_port_forwarding_STEAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mem m = new Mem();

        string processName = "iw4mp";
        bool procOpen = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            procOpen = m.OpenProcess(processName);
            if (!procOpen)
            {
                Thread.Sleep(1500);

                return;
            }
            Thread.Sleep(1500);

            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private async void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (procOpen)
            {
                gameStatus.Text = "GameStatus: " + "Game Found!";
                m.OpenProcess(processName);
                keepHookingCoD.Start();
            }
        }

        private void keepHookingCoD_Tick(object sender, EventArgs e)
        {
            m.OpenProcess(processName);
        }

        private void sendPortTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("0x642D6CC, C", "int", customPort.Text);
            }
            catch { }
        }

        private void enablePortForwarding_CheckedChanged(object sender, EventArgs e)
        {
            if (enablePortForwarding.Checked)
            {
                sendPortTimer.Start();
            }
            else
            {
                sendPortTimer.Stop();
            }
        }

    }
}
