using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceylon_TimeTableManagement
{
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            DayHours f = new DayHours();
            f.TopLevel = false;
            f.MdiParent = null;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PreferredandUnavailableTime f = new PreferredandUnavailableTime();
            f.TopLevel = false;
            f.MdiParent = null;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }


    }
}
