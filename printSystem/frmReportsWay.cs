using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace printSystem
{
    public partial class frmReportsWay : Form
    {

        public DataTable dt = new DataTable();
        public frmReportsWay(DataTable datatable)
        {
            InitializeComponent();
            dt = datatable;

            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt);
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts);
            reportViewer1.LocalReport.DataSources.Add(rts2);


            this.reportViewer1.RefreshReport();

        }

        public frmReportsWay(int idd)
        {
            /*
            InitializeComponent();
            id = idd;
            this.Hide();
            this.decTblTableAdapter.FillBy(this.dataDataSet.decTbl, id);
            this.studentDataTableAdapter.FillBy(this.dataDataSet.studentData, Convert.ToDouble(dataDataSet.decTbl.Rows[0][1].ToString()));
            this.reportViewer1.RefreshReport();
            */
        }
        int id = 0;
        private void frmReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.studentData' table. You can move, or remove it, as needed.

           /* reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Add(rts);

            this.reportViewer1.RefreshReport();

    */


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
