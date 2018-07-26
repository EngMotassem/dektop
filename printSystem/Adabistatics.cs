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
    public partial class Adabistatics : Form
    {
        public Adabistatics()
        {
            InitializeComponent();
        }

        private void Adabistatics_Load(object sender, EventArgs e)
        {

            this.decTblTableAdapter.FillByDepatrment(this.dataDataSet.decTbl, "1");


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
