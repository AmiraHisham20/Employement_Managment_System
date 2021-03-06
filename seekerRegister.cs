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
        OracleConnection conn;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";

        public reg_seeker()
        {
            InitializeComponent();
        }

        private void reg_seeker_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_seeker_reg_Click(object sender, EventArgs e)
        {

            int age = Convert.ToInt32(txt_age.Text);
            if (age <= 18)
            {
                MessageBox.Show("Sorry you must be above or equal 18 years old!!");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "insert_seek";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("seeker_ssn", Convert.ToInt32(txt_ssn.Text));
                cmd.Parameters.Add("seeker_name", txt_name.Text);
                cmd.Parameters.Add("seeker_number", txt_number.Text);
                cmd.Parameters.Add("seeker_mail", txt_mail.Text);
                cmd.Parameters.Add("seeker_address", txt_adress.Text);
                cmd.Parameters.Add("seeker_field", txt_field_of_study.Text);

                cmd.Parameters.Add("seeker_gradeYear", Convert.ToInt32(txt_gradeYear.Text));
                cmd.Parameters.Add("seeker_gradeState", Convert.ToChar(txt_grade_state.Text));
                cmd.Parameters.Add("seeker_expYear", Convert.ToInt32(txt_exp_years.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("seeker successfully added");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page form = new home_page();
            form.ShowDialog();

            this.Close();
        }

        private void reg_seeker_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
