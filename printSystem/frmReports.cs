using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class frmReports : Form
    {


        public DataTable dt = new DataTable();
        public frmReports(DataTable datatable)
        {
            InitializeComponent();
            dt = datatable;

            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

            this.Hide();
            this.reportViewer1.RefreshReport();
            

        }
        public frmReports(int idd)
        {
            InitializeComponent();
           
            id = idd;
            this.Hide();
            this.decTblTableAdapter.FillBy(this.dataDataSet.decTbl, id);
            this.reportViewer1.RefreshReport();

        }
        int id = 0;
        private void frmReports_Load(object sender, EventArgs e)
        {
          
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();
        }
    }
}
