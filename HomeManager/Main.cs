using System;
using System.Windows.Forms;

using Core.Services.Calculation;
using Infrastructure.Data.Repositories;

namespace HomeManager
{
    public partial class Main : Form
    {
        private readonly TestService _testService;
        private readonly SaveResultsRepository _saveResultsRepository;

        public Main()
        {
            InitializeComponent();

            _testService = new TestService();
            _saveResultsRepository = new SaveResultsRepository();
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
            if (rbFourThreads.Checked)
                return 4;
            if (rbFiveThreads.Checked)
                return 5;
            if (rbSixThreads.Checked)
                return 6;
            if (rbSevenThreads.Checked)
                return 7;
            if (rbEightThreads.Checked)
                return 8;

            return 1;
        }

        private void btnDbTest_Click(object sender, EventArgs e)
        {
            _saveResultsRepository.CreateTest();
            MessageBox.Show("Done");
        }
    }
}
