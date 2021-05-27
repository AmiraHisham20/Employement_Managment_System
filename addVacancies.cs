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
    public partial class AddVacancies : Form
    {
        OracleConnection conn;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";

        public AddVacancies()
        {
            InitializeComponent();
        }

        private void AddVacancies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select Comp_name from company";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_companyName.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Insert_vacancies";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("comp_name", cmb_companyName.SelectedItem.ToString());
            cmd.Parameters.Add("job_title", txt_JobTitle.Text);
            
            if (rdb_FullTime.Checked)
            {
                cmd.Parameters.Add("job_type",rdb_FullTime.Text);
            }

            else if(rdb_Internship.Checked)
            {
                cmd.Parameters.Add("job_type", rdb_Internship.Text);
            }

            else
            {
                MessageBox.Show("Choose job type");
            }

            cmd.Parameters.Add("job_vacancies", txt_vacanciesNo.Text);
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Vacancy successfully added");
        }
    }
}
