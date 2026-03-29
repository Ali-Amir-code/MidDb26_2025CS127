using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.UI.UserControls;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI
{
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            SetupStatusBar();
            HandleEvents();
        }

        private void SetupStatusBar()
        {
            ApplicationStatusService.StatusChanged += ApplicationStatusService_StatusChanged;
            UpdateStatusBar("Ready. Choose a section from the sidebar.", ApplicationStatusLevel.Info);
        }

        private void ApplicationStatusService_StatusChanged(object sender, ApplicationStatusEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateStatusBar(e.Message, e.Level)));
                return;
            }

            UpdateStatusBar(e.Message, e.Level);
        }

        private void UpdateStatusBar(string message, ApplicationStatusLevel level)
        {
            statusLabel.Text = message;
            switch (level)
            {
                case ApplicationStatusLevel.Success:
                    statusLabel.ForeColor = Color.FromArgb(16, 185, 129);
                    break;
                case ApplicationStatusLevel.Warning:
                    statusLabel.ForeColor = Color.FromArgb(245, 158, 11);
                    break;
                case ApplicationStatusLevel.Error:
                    statusLabel.ForeColor = Color.FromArgb(239, 68, 68);
                    break;
                default:
                    statusLabel.ForeColor = Color.FromArgb(224, 231, 255);
                    break;
            }
        }

        private void HandleEvents()
        {
            sidebarControl1.DashboardClicked += Sidebar_DashboardClicked;
            sidebarControl1.StudentsClicked += Sidebar_StudentsClicked;
            sidebarControl1.AdvisoryClicked += Sidebar_AdvisoryClicked;
            sidebarControl1.ProjectsClicked += Sidebar_ProjectsClicked;
            sidebarControl1.GroupsClicked += Sidebar_GroupsClicked;
            sidebarControl1.EvaluationsClicked += Sidebar_EvaluationsClicked;
            sidebarControl1.ReportsClicked += Sidebar_ReportsClicked;
        }

        public void LoadControl(UserControl uc)
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void Sidebar_DashboardClicked(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        public void Sidebar_StudentsClicked(object sender, EventArgs e)
        {
            LoadControl(new StudentControl(StudentBL.GetAllStudents()));
        }

        private void Sidebar_AdvisoryClicked(object sender, EventArgs e)
        {
            LoadControl(new AdvisoryControl(AdvisorBL.GetAllAdvisors()));
        }

        private void Sidebar_ProjectsClicked(object sender, EventArgs e)
        {
            LoadControl(new ProjectControl(ProjectBL.GetAllProjects()));
        }

        private void Sidebar_GroupsClicked(object sender, EventArgs e)
        {
            LoadControl(new GroupControl());
        }

        private void Sidebar_EvaluationsClicked(object sender, EventArgs e)
        {
             LoadControl(new EvaluationControl());
        }

        private void Sidebar_ReportsClicked(object sender, EventArgs e)
        {
             LoadControl(new ReportControl());
        }

    }
}
