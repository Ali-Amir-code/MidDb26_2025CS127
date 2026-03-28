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
    public partial class SidebarControl : UserControl
    {
        public event EventHandler DashboardClicked;
        public event EventHandler StudentsClicked;
        public event EventHandler AdvisoryClicked;
        public event EventHandler ProjectsClicked;
        public event EventHandler GroupsClicked;
        public event EventHandler EvaluationsClicked;
        public event EventHandler ReportsClicked;
        public SidebarControl()
        {
            InitializeComponent();
            Setup(); 
        }

        private void navBtn_Click()
        {
            dashboardNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            dashboardNavBtn.BackColor = Color.Transparent;

            studentNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            studentNavBtn.BackColor = Color.Transparent;

            projectNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            projectNavBtn.BackColor = Color.Transparent;

            groupNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            groupNavBtn.BackColor = Color.Transparent;

            advisoryNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            advisoryNavBtn.BackColor = Color.Transparent;

            evaluationNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            evaluationNavBtn.BackColor = Color.Transparent;

            reportNavBtn.ForeColor = Color.FromArgb(148, 163, 184);
            reportNavBtn.BackColor = Color.Transparent;
        }
        private void dashboardNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            DashboardClicked?.Invoke(this, EventArgs.Empty);

            dashboardNavBtn.ForeColor = Color.White;
            dashboardNavBtn.BackColor = Color.FromArgb(99, 102, 241);
            
        }
        private void studentNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            StudentsClicked?.Invoke(this, EventArgs.Empty);

            studentNavBtn.ForeColor = Color.White;
            studentNavBtn.BackColor = Color.FromArgb(99, 102, 241);
        }
        private void advisoryNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            AdvisoryClicked?.Invoke(this, EventArgs.Empty);

            advisoryNavBtn.ForeColor = Color.White;
            advisoryNavBtn.BackColor = Color.FromArgb(99, 102, 241);
        }

        private void projectNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            ProjectsClicked?.Invoke(this, EventArgs.Empty);

            projectNavBtn.ForeColor = Color.White;
            projectNavBtn.BackColor = Color.FromArgb(99, 102, 241);
        }
        private void groupNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            GroupsClicked?.Invoke(this, EventArgs.Empty);

            groupNavBtn.ForeColor = Color.White;
            groupNavBtn.BackColor = Color.FromArgb(99, 102, 241);
        }

        private void evaluationNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            EvaluationsClicked?.Invoke(this, EventArgs.Empty);

            evaluationNavBtn.ForeColor = Color.White;
            evaluationNavBtn.BackColor = Color.FromArgb(99, 102, 241);
        }
        private void reportNavBtn_Click(object sender, EventArgs e)
        {
            this.navBtn_Click();

            ReportsClicked?.Invoke(this, EventArgs.Empty);

            reportNavBtn.ForeColor = Color.White;
            reportNavBtn.BackColor = Color.FromArgb(99, 102, 241);
        }

    }
}
