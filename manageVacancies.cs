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
    public partial class manageVacancies : Form
    {

        OracleDataAdapter adaptor;
        DataSet ds;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";
        OracleCommandBuilder builder;
        public manageVacancies()
        {
            InitializeComponent();
        }

        private void manageVacancies_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page form = new home_page();
            form.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Validatee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CID", txt_compId.Text);
            cmd.Parameters.Add("n", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();


            string x = (cmd.Parameters["n"].Value).ToString();
            
            if (x == "0")
            {
                MessageBox.Show("Sorry this ID doesn't exist");
            }
            else
            {
                string cmdstr = @"select comp_name ,job_name,job_type, number_vacancies 
                              from jobvacancies
                              where comp_name=
                              (select comp_name from company where comp_id= :n)";
                adaptor = new OracleDataAdapter(cmdstr, ordb);
                adaptor.SelectCommand.Parameters.Add("n", txt_compId.Text);
                ds = new DataSet();
                adaptor.Fill(ds);
                dgv_vacancies.DataSource = ds.Tables[0];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adaptor);
            adaptor.Update(ds.Tables[0]);
            MessageBox.Show("Modification is successfully done");

        }


    }
}
