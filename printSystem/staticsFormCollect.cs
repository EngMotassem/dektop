using MetroFramework;
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
    public partial class staticsFormCollect : MetroFramework.Forms.MetroForm
    {
        dataDataSetTableAdapters.examTableTableAdapter adabexam = new dataDataSetTableAdapters.examTableTableAdapter();
        dataDataSetTableAdapters.studentDataTableAdapter adabstu = new dataDataSetTableAdapters.studentDataTableAdapter();
        dataDataSetTableAdapters.decTblTableAdapter adabdec = new dataDataSetTableAdapters.decTblTableAdapter();
        dataDataSet.examTableDataTable list = new dataDataSet.examTableDataTable();


        public staticsFormCollect()
        {
            InitializeComponent();

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void subjectStaticsmetroButton_Click(object sender, EventArgs e)
        {
            

           // حرمان مجال الدراسي 


           // حكومي بنين مجال دراسي
           int  a = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 1, 1, "4"));
           //  int b = Convert.ToInt32(a);
           // مجال دراسي  حكومي بنات
           int b = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 1, 2, "4"));



           // خاص بنين مجال دراسي
           int c = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 2, 1, "4"));
           //  int b = Convert.ToInt32(a);
           // خاص بنيات مجال دراسي
           int d = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 2, 2, "4"));

           // مراكز رجال حرمان مجال

           int E  = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 3, 1, "4"));


           // مراكز نساء حرمان مجال

           int F = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 3, 2, "4"));
           // منازل رجال حرمان مجال
           int G = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 4, 1, "4"));

           // منازل نساء حرمان مجال
           int K = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 4, 2, "4"));

           int totalCodeOne = a + b + c + d + E + F + G + K;
           // نهاية حرمان المجال الدراسي 


           // بداية جميع المجالات الدراسية 

           // حكومي بنين 
           int a1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 1, 1, "2"));
           //  int b = Convert.ToInt32(a);
           //   حكومي بنات
           int b1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 1, 2, "2"));



           // خاص بنين 
           int c1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 2, 1, "2"));
           //  int b = Convert.ToInt32(a);
           // خاص بنيات 
           int d1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 2, 2, "2"));

           // مراكز رجال 

           int E1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 3, 1, "2"));


           // مراكز نساء 

           int F1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 3, 2, "2"));
           // منازل رجال 
           int G1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 4, 1, "2"));

           // منازل نساء 
           int K1 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 4, 2, "2"));

           int totalCodetwo = a1 + b1 + c1 + d1 + E1 + F1 + G1 + K1;


           // نهاية حرمان جميع المجالات 



           // بداية حرمان نهائي

           // حكومي بنين 
           int a2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 1, 1, "3"));
           //  int b = Convert.ToInt32(a);
           //   حكومي بنات
           int b2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 1, 2, "3"));



           // خاص بنين 
           int c2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 2, 1, "3"));
           //  int b = Convert.ToInt32(a);
           // خاص بنيات 
           int d2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 2, 2, "3"));

           // مراكز رجال 

           int E2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 3, 1, "3"));


           // مراكز نساء 

           int F2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 3, 2, "3"));
           // منازل رجال 
           int G2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 4, 1, "3"));

           // منازل نساء 
           int K2 = Convert.ToInt32(adabdec.CounterofregionbasedonExam(cmbcourse.Text, 4, 2, "3"));


           int totalCodethree = a2 + b2 + c2 + d2 + E2 + F2 + G2 + K2;



        //   MetroMessageBox.Show(this, depatText.Text, "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);



           DataTable dt = new DataTable();
           dt.Columns.Add("govBoycode1", typeof(string));
           dt.Columns.Add("govGirlcode1", typeof(string));
           dt.Columns.Add("specialboycode1", typeof(string));
           dt.Columns.Add("specialgirlcode1", typeof(string));
           dt.Columns.Add("centerboycode1", typeof(string));

           dt.Columns.Add("centergirlcode1", typeof(string));
           dt.Columns.Add("homeboycode1", typeof(string));
           dt.Columns.Add("homegirlcode1", typeof(string));
           dt.Columns.Add("totalCode1", typeof(string));
           //------------------
           dt.Columns.Add("govBoyCode2", typeof(string));
           dt.Columns.Add("govGirlCode2", typeof(string));
           dt.Columns.Add("specboyCode2", typeof(string));
           dt.Columns.Add("specGirlCode2", typeof(string));


           dt.Columns.Add("centerboyCode2", typeof(string));
           dt.Columns.Add("centerGirlCode2", typeof(string));
           dt.Columns.Add("homeboyCode2", typeof(string));
           dt.Columns.Add("homegirlCode2", typeof(string));

           dt.Columns.Add("totalCode2", typeof(string));

           //---------------------------------------------


           dt.Columns.Add("govboyCode3", typeof(string));
           dt.Columns.Add("govGirlCode3", typeof(string));
           dt.Columns.Add("specialboyCode3", typeof(string));
           dt.Columns.Add("specialGirlCode3", typeof(string));


           dt.Columns.Add("centerboyCode3", typeof(string));
           dt.Columns.Add("centerGirlCode3", typeof(string));
           dt.Columns.Add("homeboyCode3", typeof(string));
           dt.Columns.Add("homegirlCode3", typeof(string));

           dt.Columns.Add("totalCode3", typeof(string));

           dt.Columns.Add("examName", typeof(string));
           dt.Columns.Add("examDate", typeof(string));
           dt.Columns.Add("examDay", typeof(string));
           dt.Columns.Add("department", typeof(string));
           dt.Columns.Add("total", typeof(string));


           //
           int total = totalCodeOne + totalCodetwo + totalCodethree;

           dt.Rows.Add(new object[] { a, b, c, d, E, F, G, K, totalCodeOne,

                a1, b1, c1, d1, E1, F1, G1, K1, totalCodetwo,

                 a2, b2, c2, d2, E2, F2, G2, K2, totalCodethree,

                 cmbcourse.Text,txtDate.Text,txtDay.Text,metroComboBox1.Text,total


           });

            // AreaFormShow f = new AreaFormShow(dt);
          //  if (metroComboBox1.SelectedIndex==1) {

                StaticofSubjectShow f = new StaticofSubjectShow(dt);
                f.Show();
           // }

   
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroComboBox1.SelectedIndex==1)
            adabexam.FillBytype(dataDataSet1.examTable, Convert.ToInt32("1"));

            if (metroComboBox1.SelectedIndex == 2)
                adabexam.FillBytype(dataDataSet1.examTable, Convert.ToInt32("3"));

            cmbcourse.DisplayMember = "examName";
            cmbcourse.ValueMember = "examId";
            list = dataDataSet1.examTable;
            cmbcourse.DataSource = list;


         
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
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


        // حرمانات المناطق 
        private void AreaMetro_Click(object sender, EventArgs e)
        {

            
            // حرمانات العاصمة  


            int assemacode1 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text,"4", "العاصمة"));

            int assemacode2 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "2", "العاصمة"));

            int assemacode3 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "3", "العاصمة"));

            int assemaTotal = assemacode1 + assemacode2 + assemacode3;
            // حرمانات حولى  
          //   MetroMessageBox.Show(this, assemacode1.ToString(), "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);


            int hawalycode1 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "4", "حولي"));

            int hawalycode2 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "2", "حولي"));

            int hawalycode3 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "3", "حولي"));

            int hawalYTotal = hawalycode1 + hawalycode2 + hawalycode3;


            // حرمانات الفروانية  


            int farwanyacode1 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "4", "الفروانية"));

            int farwanyacode2 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "2", "الفروانية"));

            int farwanyacode3 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "3", "الفروانية"));

            int farwanyacodeTotal = farwanyacode1 + farwanyacode2 + farwanyacode3;


            // حرمانات مبارك الكبير  


            int mubarkcode1 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "4", "مبارك الكبير"));

            int mubarkcode2 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "2", "مبارك الكبير"));


            int mubarkcode3 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "3", "مبارك الكبير"));

            int mubarkcodeTotal = mubarkcode1 + mubarkcode2 + mubarkcode3;


            // حرمانات الأحمدي  


            int ahmadicode1 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "4", "الأحمدي"));

            int ahmadicode2 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "2", "الأحمدي"));

            int ahmadicode3 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "3", "الأحمدي"));

            int ahmadicodeTotal = ahmadicode1 + ahmadicode2 + ahmadicode3;

            // حرمانات الجهراء  


            int jahracode1 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "4", "الجهراء"));

            int jahracode2 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "2", "الجهراء"));

            int jahracode3 = Convert.ToInt32(adabdec.AreaCounter(cmbcourse.Text, "3", "الجهراء"));

            int jahracodeTotal = jahracode1 + jahracode2 + jahracode3;

            // code 1 total


            int code1Total = assemacode1 + hawalycode1 + farwanyacode1 + mubarkcode1 + jahracode1 + ahmadicode1;


            // code 2 total


            int code2Total = assemacode2 + hawalycode2 + farwanyacode2 + mubarkcode2 + jahracode2 + ahmadicode2;



            // code 3 total


            int code3Total = assemacode3 + hawalycode3 + farwanyacode3 + mubarkcode3 + jahracode3 + ahmadicode3;

            // all codes Total

            int allcodesTotal = code1Total + code2Total + code3Total;



            DataTable dt = new DataTable();
            dt.Columns.Add("assema1", typeof(string));
            dt.Columns.Add("assema2", typeof(string));
            dt.Columns.Add("assema3", typeof(string));
            dt.Columns.Add("assematotal", typeof(string));

            dt.Columns.Add("hawaly1", typeof(string));
            dt.Columns.Add("hawaly2", typeof(string));
            dt.Columns.Add("hawaly3", typeof(string));
            dt.Columns.Add("hawalttotal", typeof(string));

            dt.Columns.Add("farwanya1", typeof(string));
            dt.Columns.Add("farwanya2", typeof(string));
            dt.Columns.Add("farwanya3", typeof(string));
            dt.Columns.Add("farwanyatotal", typeof(string));

            dt.Columns.Add("mubark1", typeof(string));
            dt.Columns.Add("mubark2", typeof(string));
            dt.Columns.Add("mubark3", typeof(string));
            dt.Columns.Add("mubarktotal", typeof(string));


            dt.Columns.Add("ahamadi1", typeof(string));
            dt.Columns.Add("ahamadi2", typeof(string));
            dt.Columns.Add("ahamadi3", typeof(string));
            dt.Columns.Add("ahamaditotal", typeof(string));



            dt.Columns.Add("jahra1", typeof(string));
            dt.Columns.Add("jahra2", typeof(string));
            dt.Columns.Add("jahra3", typeof(string));
            dt.Columns.Add("jahratotal", typeof(string));


            //ahamadi1

            dt.Columns.Add("totalcode1", typeof(string));
            dt.Columns.Add("totalcode2", typeof(string));
            dt.Columns.Add("totalcode3", typeof(string));
            dt.Columns.Add("totalcodes", typeof(string));


            dt.Columns.Add("examName", typeof(string));
            dt.Columns.Add("examDate", typeof(string));
            dt.Columns.Add("examDay", typeof(string));
            dt.Columns.Add("department", typeof(string));




            dt.Rows.Add(new object[] {
                assemacode1, assemacode2, assemacode3, assemaTotal,
                hawalycode1, hawalycode2, hawalycode3, hawalYTotal,
                farwanyacode1,farwanyacode2, farwanyacode3, farwanyacodeTotal,
                mubarkcode1, mubarkcode2, mubarkcode3, mubarkcodeTotal,
                ahmadicode1, ahmadicode2,ahmadicode3, ahmadicodeTotal,
                jahracode1, jahracode2, jahracode3, jahracodeTotal,
                code1Total, code2Total, code3Total,allcodesTotal,

                 cmbcourse.Text,txtDate.Text,txtDay.Text,metroComboBox1.Text


           });

           // if (metroComboBox1.SelectedIndex == 1)
            //{

                FormStatics f = new FormStatics(dt);
                f.Show();
            //}

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();


            showStudentNames f = new showStudentNames();

            f.Show();
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            showareassubjects f = new showareassubjects();
            f.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            showareasubjectsDini f = new showareasubjectsDini();
            f.Show();

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ShowareaCollection f = new ShowareaCollection();
            f.Show();
        }
    }
}
