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
    public partial class frmReportsMahader2 : Form
    {

        public DataTable dt = new DataTable();

        public frmReportsMahader2(int  idd)
        {
            InitializeComponent();
            id = idd; this.Hide();
            this.dataDataSet.Clear();

            this.decTblTableAdapter.FillBy(this.dataDataSet.decTbl, id);
            this.reportViewer1.RefreshReport();
        }
        public frmReportsMahader2(DataTable dataTable)
        {
            InitializeComponent();
            dt = dataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

            this.Hide();
            this.reportViewer1.RefreshReport();
        }

        int id = 0;
      

        private void frmReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);
            //// TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            //this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);


            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.

            //      reportViewer1.PrintDialog();
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
