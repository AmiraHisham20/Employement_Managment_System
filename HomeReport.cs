using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SWE_Form1
{
    public partial class HomeReport : Form
    {
        CachedCrystalReport3 CR3;

        public HomeReport()
        {
            InitializeComponent();
        }

        private void HomeReport_Load(object sender, EventArgs e)
        {
            CR3 = new CachedCrystalReport3();
           
        }

        private void btn_report2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR3;        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page form = new home_page();
            form.ShowDialog();

            this.Close();
        }
    }
}
