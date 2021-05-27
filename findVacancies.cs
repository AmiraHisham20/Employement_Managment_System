﻿using System;
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
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select* from jobvacancies where job_name=:n and job_type=:T and NUMBER_VACANCIES>0";
            cmd.Parameters.Add("n", cmb_Jtitle.SelectedItem.ToString());
            cmd.Parameters.Add("T", cmb_JType.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            dr = cmd.ExecuteReader();


           while(dr.Read())

            {

                cmb_compName.Items.Add(dr[0]);

            }
            string job_title = cmb_Jtitle.SelectedItem.ToString();
            string job_type = cmb_JType.SelectedItem.ToString();
            Console.WriteLine( job_title, job_type);
            Console.WriteLine("hekha search");


        }

        private void btn_applay_Click(object sender, EventArgs e)
        {
           
            string comp_name = cmb_compName.SelectedItem.ToString();
            string job_title = cmb_Jtitle.SelectedItem.ToString();
            string job_type = cmb_JType.SelectedItem.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert_jobInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("seeke_ssn", txt_SSN.Text);
           
            cmd.Parameters.Add("comp_name", comp_name);
            cmd.Parameters.Add("JobTitle", job_title);
            cmd.Parameters.Add("JobType", job_type);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Application done");
            //var myForm = new reg_seeker(comp_name,job_title,job_type);
            //myForm.Show();
            //Console.WriteLine(comp_name);
            //Console.WriteLine(job_title);
            //Console.WriteLine( job_type);
            //Console.WriteLine("hekha");
        }

    
    }
}
