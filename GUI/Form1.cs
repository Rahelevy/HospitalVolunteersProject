using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void volunteerPage_Click(object sender, EventArgs e)
        {
            VolunteerFrm volunteerFrm = new VolunteerFrm();
            volunteerFrm.Show();
            this.Hide();
        }

        private void btnhlpreq_Click(object sender, EventArgs e)
        {
            HelpRequestFrm helpRequestFrm = new HelpRequestFrm();
            helpRequestFrm.Show();
            this.Hide();
        }
    }
}
