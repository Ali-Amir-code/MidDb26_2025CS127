using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.UserControls
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void locationBrowse_HelpRequest(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            allReportsLocationBrowse.ShowDialog();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            pathText.Text = allReportsLocationBrowse.SelectedPath;
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void downloadBtn1_Click(object sender, EventArgs e)
        {
            report1LocationBrowse.ShowDialog();
        }

        private void downloadBtn2_Click(object sender, EventArgs e)
        {
            report2LocationBrowse.ShowDialog();
        }

        private void downloadBtn3_Click(object sender, EventArgs e)
        {
            report3LocationBrowse.ShowDialog();
        }

        private void downloadBtn4_Click(object sender, EventArgs e)
        {
            report4LocationBrowse.ShowDialog();
        }
    }
}
