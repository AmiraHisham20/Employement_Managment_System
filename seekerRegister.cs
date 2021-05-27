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
   
    public partial class reg_seeker : Form
    {
        FindVacancies s = new FindVacancies();
        OracleConnection conn;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";
        string jobTitle;
        string jobType;
        string compName;
        public reg_seeker()
        {
            InitializeComponent();
            //this.jobTitle = jobTitle;
            //this.jobType = jobType;
            //this.compName = compName;

        }

        private void reg_seeker_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
           


        }

        private void btn_seeker_reg_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hekha form");
            Console.WriteLine(compName);
            Console.WriteLine(jobTitle);
            Console.WriteLine(jobType);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_seek";
            cmd.CommandType = CommandType.StoredProcedure;
            int SSN = Convert.ToInt32(txt_ssn.Text);
            int GYear = Convert.ToInt32(txt_gradeYear.Text);
            
            cmd.Parameters.Add("seeker_ssn", SSN);
            cmd.Parameters.Add("seeker_name", txt_name.Text);
            cmd.Parameters.Add("seeker_number", txt_number.Text);
            cmd.Parameters.Add("seeker_mail", txt_mail.Text);
            cmd.Parameters.Add("seeker_address", txt_adress.Text);
            cmd.Parameters.Add("seeker_field", txt_field_of_study.Text);
            cmd.Parameters.Add("seeker_gradeYear", Convert.ToInt32(txt_gradeYear.Text));
            cmd.Parameters.Add("seeker_gradeState", Convert.ToChar(txt_grade_state.Text));
            cmd.Parameters.Add("seeker_expYear", Convert.ToInt32(txt_exp_years.Text));
            //cmd.Parameters.Add("comp_name",compName);
            //cmd.Parameters.Add("Job_name", jobTitle);
            //cmd.Parameters.Add("job_type", jobType);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("seeker successfully added");
        }
    }
}
