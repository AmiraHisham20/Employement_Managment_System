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
            this.Hide();
            showApplicant form = new showApplicant();
            form.ShowDialog();
            this.Close();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageVacancies form = new manageVacancies();
            form.ShowDialog();
            this.Close();
            
        }

        private void btn_Credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sema Ghith\n"+"Amira Hesham\n" +"Mai Mansour\n" +"Omar Mohamed\n" +"Abdelrahman Tamer\n" +"Abdelwahab Mohamed\n");
        }

        private void btn_HowWorks_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" At first time weither you are a company or a job seeker \nyou must register by your info\nthen you choose the functionalites you want\ndepending on the type of your register\nall changes you make inside the system will be saved.\n***WARNING: Don't try to change what not for you or\nfake any of your info that will affect the \nefficiency of your recevied service***.");
        }

        private void btn_whatPeso_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" A software system that allows\n companies to register in it, set job\n vacancies in every available position and\n set the number of employees that they want\n in a particular position, also allow employees\n to register and search for jobs with the same job\n title that they want to apply in it,\n If he applied in any company this company will be\n able to see this applicant information.");
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeReport form = new HomeReport();
            form.ShowDialog();
            this.Close();
           
        }
    }
}
