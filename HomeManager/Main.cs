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
            _testService.Loop32();
            lblStatus.Text = "Completed";

            var stop = DateTime.Now;
            lblTimeSpan.Text = string.Format("Competion time: {0}", stop.Subtract(start).TotalMilliseconds);
        }
    }
}
