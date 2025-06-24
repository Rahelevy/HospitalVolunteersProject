using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class VolunteerFrm : Form
    {
        VolunteerBLL volunteerBLL = new VolunteerBLL();
        public VolunteerFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int h = volunteerBLL.GetRemainingMonthlyHours(Convert.ToInt32(idvolunteer.Text));
                label2.Text = h.ToString();
                label2.Visible = true;
            }
            catch (Exception ex)
            {
                label2.Text = "אירעה שגיאה";
            }


            try
            {
                var res = volunteerBLL.getVolunteerAssignmentsDetails_ResultDTOs(Convert.ToInt32(idvolunteer.Text));
                dataGridView1.DataSource = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה");
            }


            try
            {
                int idv = Convert.ToInt32(idvolunteer.Text);
                volunteerBLL.GetVolunteerMonthlyHours(idv, out int currentMonthHours, out int previousMonthHours);
                lblmonthlyhrs.Text = currentMonthHours.ToString();
                lblmonthlyhrs.Visible = true;
                lblprevmonth.Text = previousMonthHours.ToString();
                lblprevmonth.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה בהבאת שעות מתנדב");
            }

            try
            {
                int idv = Convert.ToInt32(idvolunteer.Text);
                lblonlyservice.Text = volunteerBLL.GetExclusiveServicesCount(idv).ToString();
                lblonlyservice.Visible = true;
            }
            catch (Exception)
            {
                lblonlyservice.Text = "אירעה שגיאה ";
                lblonlyservice.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = Convert.ToInt32(textBox1.Text);

                if (volunteerBLL.IsServiceHoursSufficient(ids) == true)
                {
                    lblres.Text = "כן";
                    lblres.Visible = true;
                }
                else
                {
                    lblres.Text = "לא";
                    lblres.Visible = true;
                }
            }
            catch (Exception)
            {
                lblres.Text = "אירעה שגיאה";
                lblres.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idservicetxt_Click(object sender, EventArgs e)
        {

        }

        private void VolunteerFrm_Load(object sender, EventArgs e)
        {

        }

        private void lblrequestsvol_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
