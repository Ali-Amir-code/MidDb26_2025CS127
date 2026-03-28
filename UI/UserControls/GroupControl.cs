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
    public partial class GroupControl : UserControl
    {
        public GroupControl()
        {
            InitializeComponent();
        }

        private void regLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            (new AddGroupForm()).ShowDialog();
        }
    }
}
