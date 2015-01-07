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
            var completionTimes = _testService.Loop32Mt(2);
            lblStatus.Text = "Completed";

            var stop = DateTime.Now;

            foreach (var completionTime in completionTimes)
            {
                tbResult.Text += string.Format("Competion time: {0} ms", completionTime.TotalMilliseconds);
                tbResult.Text += Environment.NewLine;
            } 
        }
    }
}
