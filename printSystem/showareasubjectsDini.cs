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
    public partial class showareasubjectsDini : Form
    {
        public showareasubjectsDini()
        {
            InitializeComponent();
        }

        private void showareasubjectsDini_Load(object sender, EventArgs e)
        {
            this.decTblTableAdapter.FillBy1(this.dataDataSet.decTbl);
            //  this.decTblTableAdapter.FillByDepatrment(this.dataDataSet.decTbl, "1");


            this.reportViewer1.RefreshReport(); 

        }
    }
}
