using System;
using System.Windows.Forms;

using Core.Services.Calculation;

namespace HomeManager
{
    public partial class Main : Form
    {
        private readonly TestService _testService;

        public Main()
        {
            InitializeComponent();

            _testService = new TestService();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var start = DateTime.Now;

            lblStatus.Text = "Pending";
            var completionTimes = _testService.Loop32Mt(GetThreadNumber());
            lblStatus.Text = "Completed";

            var stop = DateTime.Now;

            foreach (var completionTime in completionTimes)
            {
                tbResult.Text += string.Format("Completion time: {0} s", completionTime.TotalSeconds);
                tbResult.Text += Environment.NewLine;
            } 
        }

        private int GetThreadNumber()
        {
            if (rbOneThread.Checked)
                return 1;
            if (rbTwoThreads.Checked)
                return 2;
            if (rbThreeThreads.Checked)
                return 3;

            return 1;
        }
    }
}
