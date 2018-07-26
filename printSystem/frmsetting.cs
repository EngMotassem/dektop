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
    public partial class frmsetting : MetroFramework.Forms.MetroForm
    {

      //  String department;
        public frmsetting()
        {
            InitializeComponent();


        }

        dataDataSetTableAdapters.examTableTableAdapter adabexam = new dataDataSetTableAdapters.examTableTableAdapter();
        dataDataSetTableAdapters.studentDataTableAdapter adabstu = new dataDataSetTableAdapters.studentDataTableAdapter();
        dataDataSetTableAdapters.decTblTableAdapter adabdec = new dataDataSetTableAdapters.decTblTableAdapter();

        dataDataSetTableAdapters.medicalTableAdapter medical = new dataDataSetTableAdapters.medicalTableAdapter();

        dataDataSet.examTableDataTable list = new dataDataSet.examTableDataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcourse_SelectedValueChanged(object sender, EventArgs e)
        {



            if (cmbcourse.SelectedIndex != -1)
            {

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].examId == Convert.ToInt16(cmbcourse.SelectedValue))
                    {
                        string day = list[i].examDate.Date.Day.ToString();
                        string month = list[i].examDate.Date.Month.ToString();
                        string year = list[i].examDate.Date.Year.ToString();



                        txtDate.Text = year + "/" + month + "/" + day;
                        txtDay.Text = list[i].examday;
                        break;
                    }
                }
            }
        }
        public int contain()
        {

            try
            {

                adabdec.Fill(dataDataSet1.decTbl);

                dataDataSet.decTblDataTable list = dataDataSet1.decTbl;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].decNumber == txtnumherman.Text && list[i].seatNo==txtseatNo.Text)
                    {
                        return 1;
                    }

                }
                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }




        public int checknameandid()
        {

            try
            {

                adabdec.Fill(dataDataSet1.decTbl);

                dataDataSet.decTblDataTable list = dataDataSet1.decTbl;



                for (int i = 0; i < list.Count; i++)
                {


                    if (list[i].decNumber == txtnumherman.Text && list[i].stName != txtname.Text )
                    {
                        if (list[i].decType == cmbType.Text)
                            return 1;
                    }

                }
                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }
        string examscname = "";
        private void metroButton1_Click(object sender, EventArgs e)
        {
           // depatText.Text = "1";


           

            // البحث عن طالب
            try
            {
                if (txtseatNo.Text != "")
                {

                    dataGridView1.DataSource = this.medicalBindingSource;


                    int count = this.medicalTableAdapter.Fill(this.dataDataSet1.medical, Convert.ToDecimal(txtseatNo.Text), Convert.ToDecimal(txtseatNo.Text));
                    dataGridView1.Columns["stname"].Visible = false;

                    dataGridView1.Columns["seatno"].Visible = false;

                    if (count != 0)
                    {

                        //this.medicalTableAdapter.FillBy(this.dataDataSet1.medical, Convert.ToDecimal(txtseatNo.Text), txtseatNo.Text);
                       // dataGridView1.Show();


                        txtname.Text = dataDataSet1.medical.Rows[0]["stname"].ToString();
                        txtschool.Text = dataDataSet1.medical.Rows[0]["school"].ToString();

                       // txtschool.Text = count.ToString();
                        regionText.Text = dataDataSet1.medical.Rows[0]["days"].ToString();
                        seerTxt.Text = count.ToString();
                        lagnaNumTxt.Text = dataDataSet1.studentData.Rows[0]["seercode"].ToString();
                        typedesc.Text = dataDataSet1.studentData.Rows[0]["type_adesc"].ToString();
                        stType.Text = dataDataSet1.studentData.Rows[0]["st_type"].ToString();
                       // depatText.Text = dataDataSet1.studentData.Rows[0]["typecode"].ToString();
                        //gender = dataDataSet1.studentData.Rows[0]["sex"];
                        int typecode =Convert.ToInt32( dataDataSet1.studentData.Rows[0]["typecode"].ToString());

                       




                       if (cmbcourse.SelectedIndex == -1)


                       adabexam.FillBytype(dataDataSet1.examTable, typecode);


                      if(!IsEqualprevDep())

                           adabexam.FillBytype(dataDataSet1.examTable, typecode);

                        //adabexam.FillBytype(dataDataSet1.examTable, typecode);


                        cmbcourse.DisplayMember = "examName";
                        cmbcourse.ValueMember = "examId";
                        list = dataDataSet1.examTable;
                        cmbcourse.DataSource = list;
                        examscname = dataDataSet1.studentData.Rows[0]["examscname"].ToString();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "رقم الجلوس غير مسجل بالنظام", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);

                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "من فضلك أدخل رقم الجلوس", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);

                }

            }
            catch (Exception g)
            {


            }

        }

        private void txtseatNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // keypress
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtnumherman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void show()
        {
            try
            {

                adabdec.Fill(dataDataSet1.decTbl);
                devgrid.Rows.Clear();
                dataDataSet.decTblDataTable list = dataDataSet1.decTbl;

                for (int i = 0; i < list.Count; i++)
                {
                    devgrid.Rows.Add();
                    devgrid.Rows[i].Cells[0].Value = list[i].decID;
                    devgrid.Rows[i].Cells[1].Value = i + 1;
                    devgrid.Rows[i].Cells[2].Value = list[i].seatNo;
                    devgrid.Rows[i].Cells[3].Value = list[i].stName;
                    devgrid.Rows[i].Cells[4].Value = list[i].decNumber;
                    devgrid.Rows[i].Cells[5].Value = list[i].examName;
                }
            }
            catch (Exception)
            {


            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }



        private void devgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    // عرض قرار سابق من الجريد
                    if (e.ColumnIndex == 6)
                    {
                        adabdec.FillBy(dataDataSet1.decTbl, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));
                        dataDataSet.decTblDataTable list1 = dataDataSet1.decTbl;
                        if (list1.Count != 0)
                        {
                            txtname.Text = list1[0].stName;
                            txtschool.Text = list1[0].scName;
                            txtseatNo.Text = list1[0].seatNo.ToString();
                            txtnumherman.Text = list1[0].decNumber;
                            cmbType.Text = list1[0].decType;
                          //  txtreport.Text = list1[0].dec_desc;
                            regionText.Text = list1[0].region;
                            seerTxt.Text = list1[0].examscName;

                            lagnaNumTxt.Text = list1[0].type_str;


                            adabstu.FillBy(dataDataSet1.studentData, Convert.ToInt32(txtseatNo.Text));

                            adabexam.FillBytype(dataDataSet1.examTable, Convert.ToInt32(dataDataSet1.studentData.Rows[0][4].ToString()));
                            cmbcourse.DisplayMember = "examName";
                            cmbcourse.ValueMember = "examId";
                            list = dataDataSet1.examTable;
                            cmbcourse.DataSource = list;


                            cmbcourse.Text = list1[0].examName;
                            txtDay.Text = list1[0].examday;
                            txtDate.Text = list1[0].examDate;
                        }
                    }

                    // حذف قرار
                    else if (e.ColumnIndex == 7)
                    {
                        int test = 0;
                        DialogResult res = MetroMessageBox.Show(this, "هل أنت متأكد من حذف هذا القرار \n مع العلم  سيتم حذفه نهائياَ؟", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);
                        if (res == DialogResult.Yes)
                        {
                            adabdec.FillBy(dataDataSet1.decTbl, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));
                            dataDataSet.decTblDataTable list = dataDataSet1.decTbl;
                            if (list.Count != 0)
                            {
                                
                                test = adabdec.DeleteQuery(list[0].decNumber, Int32.Parse(list[0].seatNo));
                        
                                if (test == 1)
                                {
                                    MetroMessageBox.Show(this, "تم حذف البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);

                                    show();
                                }

                            }
                        }
                    }

                }
            }
            catch (Exception v)
            {
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adabdec.FillByname(dataDataSet1.decTbl,txtsearch.Text);

              //  adabdec.FillBySDS(dataDataSet1.decTbl,txtsearch.Text, txtsearch.Text, txtsearch.Text);

                devgrid.Rows.Clear();
                dataDataSet.decTblDataTable list = dataDataSet1.decTbl;

                for (int i = 0; i < list.Count; i++)
                {
                    devgrid.Rows.Add();
                    devgrid.Rows[i].Cells[0].Value = list[i].decID;
                    devgrid.Rows[i].Cells[1].Value = i + 1;
                    devgrid.Rows[i].Cells[2].Value = list[i].seatNo;
                    devgrid.Rows[i].Cells[3].Value = list[i].stName;
                    devgrid.Rows[i].Cells[4].Value = list[i].decNumber;
                    devgrid.Rows[i].Cells[5].Value = list[i].examName;
                }
            }
            catch (Exception)
            {


            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (devgrid.Rows.Count != -1)
                {

                }
            }
            catch (Exception)
            {
            }
        }


        // طباعة قرار الحرمان
        private void btnprintqarar_Click(object sender, EventArgs e)
        {

            // cofigure data 

            DataTable dt = new DataTable();
            dt.Columns.Add("seatno", typeof(string));
            dt.Columns.Add("studentname", typeof(string));

            dt.Columns.Add("school", typeof(string));
            dt.Columns.Add("subject", typeof(string));
            dt.Columns.Add("description", typeof(string));


            dt.Columns.Add("seername", typeof(string));
            dt.Columns.Add("examname", typeof(string));
            dt.Columns.Add("examdate", typeof(string));
            dt.Columns.Add("examday", typeof(string));
            dt.Columns.Add("depart", typeof(string));
            dt.Columns.Add("period", typeof(string));
            dt.Columns.Add("year", typeof(string));
            dt.Columns.Add("number", typeof(string));
            dt.Columns.Add("region", typeof(string));
            dt.Columns.Add("seercode", typeof(string));

            dt.Rows.Add(new object[] { txtseatNo.Text, txtname.Text, txtschool.Text, cmbcourse.Text, seerTxt.Text, cmbcourse.Text, txtDate.Text, txtDay.Text, "", "", "", txtnumherman.Text, regionText.Text, lagnaNumTxt.Text });
            int test = 0;



            try
            {

                if (txtname.Text != "" && txtschool.Text != "" && txtnumherman.Text != "" && cmbcourse.SelectedIndex != -1 && txtDate.Text != "" && txtDay.Text != "" )
                {

                    // found in grid

                    if (contain() == 1)
                    {

                        String descCode = getCodeType();
                        

                       // adabdec.UpdateQuery1(txtreport.Text,"حرمان من الدور الثاني",descCode, txtnumherman.Text);




                        printreport(dt);

                    }



                    // else not contain 
                    else
                    {


                        if (checknameandid() == 1)
                        {
                            // show error message 

                            MetroMessageBox.Show(this, "هذا الرقم مسجل لطالب اخر", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);

                            txtnumherman.Text = "";
                            return;
                        }



                        else
                        {
                            if (!hasOldReport(txtseatNo.Text))
                            {
                                if (addtodb(dt) == 1)
                                {
                                    MetroMessageBox.Show(this, "تم إدخال البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);

                                    printreport(dt);
                                    clear();
                                    show();

                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "مسجل للطالب قرار حرمان جميع مجالات او نهائي", " موجود من قبل ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100);


                            }                                                                                     


                        }


                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "من فضلك أكمل البيانات أولا", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);

                }
            }
            catch (Exception ff)
            {
                if (test == 1)
                {

                    MetroMessageBox.Show(this, "تم إدخال البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);
                    frmReportsMahader f = new frmReportsMahader(dt);

                    clear();
                    show();
                }
                

            }

        }

        private string getCodeType()
        {
            String decCode = "---";


            if (cmbType.SelectedIndex == 1)
            {
                decCode = "2";

                // حرمان جميع المجالات  نموذج 2


            }
            else if (cmbType.SelectedIndex == 2)
            {
                // حرمان من مجال دراسي   نموذج 4
                decCode = "1";


            }
            else if (cmbType.SelectedIndex == 3)
            {
                // حرمان من جميع المجالات  نموذج 6

                decCode = "2";


                //  


            }
            else if (cmbType.SelectedIndex == 4)
            {
                // حرمان من جميع المجالات  نموذج 7

                decCode = "3";


                // f.Show();

            }
            return "4";
        }

        private void clear()
        {
            int hermann = 0;
            txtname.Text = txtschool.Text = txtseatNo.Text = regionText.Text = seerTxt.Text = "";

            metroTextBox1.Text = "";
            //cmbcourse.SelectedIndex = -1;
            //  this.dataGridView1.DataSource = this.medicalTableAdapter.Fill(this.dataDataSet1.medical, 77777);

            //   dataGridView1.Show();

            // fillByToolStripButton_Click();

            // dataGridView1.DataBindings

            //dataGridView1.Refresh();
            this.dataGridView1.DataSource = null;



            if (txtnumherman.Text != "")
            {
                hermann = Convert.ToInt32(txtnumherman.Text);

                txtnumherman.Text = (hermann + 1).ToString();


            }

            // hermann = Convert.ToInt32(txtnumherman.Text);


        }

        private void cmbcourse_DropDown(object sender, EventArgs e)
        {

        }




        // ورقة مسحوبة
        private void btnprintgolaph_Click(object sender, EventArgs e)
        {






            DataTable dt = new DataTable();
            dt.Columns.Add("seatno", typeof(string));
            dt.Columns.Add("studentname", typeof(string));

            dt.Columns.Add("school", typeof(string));
            dt.Columns.Add("subject", typeof(string));

            dt.Columns.Add("seername", typeof(string));
            dt.Columns.Add("examname", typeof(string));
            dt.Columns.Add("examdate", typeof(string));
            dt.Columns.Add("examday", typeof(string));
            dt.Columns.Add("depart", typeof(string));
            dt.Columns.Add("period", typeof(string));
            dt.Columns.Add("year", typeof(string));
            dt.Columns.Add("number", typeof(string));
            dt.Columns.Add("typedesc", typeof(string));




            dt.Rows.Add(new object[] { txtseatNo.Text, txtname.Text, txtschool.Text, cmbcourse.Text, examscname, cmbcourse.Text, txtDate.Text, txtDay.Text, "", "", "", txtnumherman.Text, metroComboBox1.Text });


            if (txtname.Text != "")
            {

                frmReports sh = new frmReports(dt);

                show();

                clear();
            }
            else
            {
                MetroMessageBox.Show(this, "من فضلك اكمل البيانات", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);


            }


        }

        private void chkprint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkprint.Checked && devgrid.Rows.Count != 0)
            {
                frmReportsWay f = new printSystem.frmReportsWay(Convert.ToInt32(devgrid.Rows[devgrid.CurrentCellAddress.Y].Cells[1].Value));
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            show();
        }

        private void txtseatNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                metroButton1_Click(null, null);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void subjectStaticsmetroButton_Click(object sender, EventArgs e)
        {
            ShowareaCollection form = new ShowareaCollection();
            //ShowareaCollection
            form.Show();



        }


        private int addtodb(DataTable dt)
        {
            int test = 0;


            String gender = dataDataSet1.studentData.Rows[0]["sex"].ToString();
            String decCode = "4";

/*
            if (cmbType.SelectedIndex == 1)
            {
                decCode = "2";

                // حرمان جميع المجالات  نموذج 2


            }
            else if (cmbType.SelectedIndex == 2)
            {
                // حرمان من مجال دراسي   نموذج 4
                decCode = "1";


            }
            else if (cmbType.SelectedIndex == 3)
            {
                // حرمان من جميع المجالات  نموذج 6

                decCode = "2";


                //  


            }
            else if (cmbType.SelectedIndex == 4)
            {
                // حرمان من جميع المجالات  نموذج 7

                decCode = "3";


                // f.Show();

            }

            */



          //  test = adabdec.InsertQuery(Int32.Parse(txtseatNo.Text), txtname.Text, txtschool.Text, examscname, cmbcourse.Text, txtDay.Text, txtDate.Text, "قرار حرمان من الدور الثاني", txtreport.Text, txtnumherman.Text, regionText.Text, lagnaNumTxt.Text, typedesc.Text, Int32.Parse(stType.Text), Int32.Parse(gender), decCode,getDepartment());


          

            return test;

        }




        private bool hasOldReport( string seatNo)
        {


           int i=Convert.ToInt32( adabdec.CountOfHermanFinalOrAll(seatNo));


            if (i > 0)
                return true;



            return false;
        }


        private string getDepartment()
        {

            string dep = "";

           dep= dataDataSet1.studentData.Rows[0]["typecode"].ToString();
            return dep;

        }




        // print report fun
        private void printreport(DataTable dt)
        {

            //frmReportsMahader f = new frmReportsMahader(dt);
            
            if (cmbType.SelectedIndex == 1)
            {
                // حرمان مجال جميع المجالات نموذج 2
                frmReportsMahader f = new frmReportsMahader(dt);


            }
            else 
            {
                // حرمان من مجال دراسي  نموذج 4
                frmReportsMahader2 f = new frmReportsMahader2(dt);

            }
           
        }

        private void devgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool IsEqualprevDep()
        {



            int typecode =Convert.ToInt32(dataDataSet1.studentData.Rows[0]["typecode"].ToString());

            if (typecode.ToString() == depatText.Text)
            {

                depatText.Text = typecode.ToString();


                return true;

            }
            else
            {

                depatText.Text = typecode.ToString();


                return false;


            }


           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  this.medicalTableAdapter.FillBy(this.dataDataSet1.medical, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(txtseatNo.Text, typeof(decimal))))));

                this.medicalTableAdapter.Fill(this.dataDataSet1.medical, Convert.ToDecimal(txtseatNo.Text), Convert.ToDecimal(txtseatNo.Text));


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBynameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicalTableAdapter.FillByname(this.dataDataSet1.medical, metroTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = this.medicalBindingSource;

            dataGridView1.Columns["stname"].Visible = true;

            dataGridView1.Columns["seatno"].Visible = true;

            this.medicalTableAdapter.FillByname(this.dataDataSet1.medical, metroTextBox1.Text);


        }
    }
}
