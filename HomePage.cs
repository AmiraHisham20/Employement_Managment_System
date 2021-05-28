using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Form1
{
    public partial class home_page : Form
    {
        OracleConnection conn;
        string ordb= "Data Source=PESO;User Id=hr;Password=hr;";
        public home_page()
        {
            InitializeComponent();
        }

        private void home_page_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_company_reg_Click(object sender, EventArgs e)
        {

            this.Hide();
            companyRegister form = new companyRegister();
            form.ShowDialog();

            this.Close();
        }

        private void btn_jobSeeker_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg_seeker form = new reg_seeker();
            form.ShowDialog();

            this.Close();
            //var myForm = new reg_seeker();
            //myForm.Show();
        }

        private void home_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void btn_addVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddVacancies form = new AddVacancies();
            form.ShowDialog();

            this.Close();
            //var myForm = new AddVacancies();
            //myForm.Show();
        }

        private void btn_findVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindVacancies form = new FindVacancies();
            form.ShowDialog();

            this.Close();
            //var myForm = new FindVacancies();
            //myForm.Show();
        }

        private void btn_applicantShow_Click(object sender, EventArgs e)
        {
        }
    }
}
