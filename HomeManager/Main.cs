using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _testService.Loop64();
        }
    }
}
