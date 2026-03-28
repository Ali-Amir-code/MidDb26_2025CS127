using MidDb26_2025CS127.UI.Froms;
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
    public partial class AdvisoryControl : UserControl
    {
        public AdvisoryControl()
        {
            InitializeComponent();
        }

        private void addAdvisorBtn_Click(object sender, EventArgs e)
        {
            (new AddAdvisorForm()).ShowDialog();
        }
    }
}
