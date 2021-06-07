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
    public partial class FindVacancies : Form
    {
        OracleConnection conn;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";
               
        public FindVacancies()
        {
            InitializeComponent();
        }

        private void FindVacancies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open(); 

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select distinct JOB_NAME from jobvacancies";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_Jtitle.Items.Add(dr[0]);
            }

            dr.Close();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select distinct job_Type from jobvacancies";

            OracleDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                cmb_JType.Items.Add(dr1[0]);
            }

            dr1.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cmb_compName.Items.Clear();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Find_Vacancy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("job_name", cmb_Jtitle.SelectedItem.ToString());
            cmd.Parameters.Add("job_type", cmb_JType.SelectedItem.ToString());
            cmd.Parameters.Add("cname", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            dr = cmd.ExecuteReader();

           while(dr.Read())
           {
                cmb_compName.Items.Add(dr[0]);
           }

            string job_title = cmb_Jtitle.SelectedItem.ToString();
            string job_type = cmb_JType.SelectedItem.ToString();

            Console.WriteLine( job_title, job_type);
        }

        private void btn_applay_Click(object sender, EventArgs e)
        {
            string comp_name = cmb_compName.SelectedItem.ToString();
            string job_title = cmb_Jtitle.SelectedItem.ToString();
            string job_type = cmb_JType.SelectedItem.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Insert_jobInf";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("seeke_ssn", txt_SSN.Text);
            cmd.Parameters.Add("comp_name", comp_name);
            cmd.Parameters.Add("JobTitle", job_title);
            cmd.Parameters.Add("JobType", job_type);
            cmd.Parameters.Add("n", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();
            string x = (cmd.Parameters["n"].Value).ToString();
            if(x=="0")
            {
                MessageBox.Show("Sorry this ID doesn't exist");
            }
            else
            MessageBox.Show("Application done");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page form = new home_page();
            form.ShowDialog();

            this.Close();
        }

        private void FindVacancies_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report2 form = new Report2();

            form.ShowDialog();

            this.Close();
        }
    }
}
