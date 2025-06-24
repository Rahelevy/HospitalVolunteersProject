using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class HelpRequestFrm : Form
    {
        VolunteerBLL volunteerBLL = new VolunteerBLL();
        public HelpRequestFrm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnishour_Click(object sender, EventArgs e)
        {
            //2
            try
            {
                int ids = Convert.ToInt32(textBox1.Text);
                if (ids <= 0)
                {
                    lblmosthours.Text = "נא להזין מספר שירות תקין.";
                }
                GetTopVolunteersByServiceDTO v = volunteerBLL.GetTopVolunteersByService(ids);
                lblmosthours.Text = $"Id:{v.IdVolunteer}, Name: {v.NameVolunteer}, Phone: {v.Phone}";
                lblmosthours.Visible = true;

            }
            catch (Exception)
            {
                lblmosthours.Text = "אירעה שגיאה";
                lblmosthours.Visible = true;
            }

            //3
            try
            {
                int cntV, cntAR;
                int ids = Convert.ToInt32(textBox1.Text);
                volunteerBLL.GetServiceStatistics(ids, out cntV, out cntAR);
                lblvolinservice.Text = cntV.ToString();
                lblvolinservice.Visible = true;
                lblreqapproved.Text = cntAR.ToString();
                lblreqapproved.Visible = true;
            }
            catch (Exception)
            {
                lblvolinservice.Text = "אירעה שגיאה";
                lblvolinservice.Visible = true;
                lblreqapproved.Text = "אירעה שגיאה";
                lblreqapproved.Visible = true;
            }

        }
    }
}
