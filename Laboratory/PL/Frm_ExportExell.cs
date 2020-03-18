using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ExcelDataReader;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Laboratory.BL;




namespace Laboratory.PL
{
    public partial class Frm_ExportExell : DevExpress.XtraEditors.XtraForm
    {
        //OleDbConnection con;
        //OleDbDataAdapter da;
        //DataTable dt;
        Branches b = new Branches();
        Users u = new Users();
        public Frm_ExportExell()
        {
            InitializeComponent();
            Permision();
            //dataGridView1.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";



        }
        System.Data.DataTable dt = new System.Data.DataTable();

        void Permision()
        {
            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
                cmb_UserBranch.DataSource = u.SelectUserBranch(txt_username.Text);
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";

               
            }
            else
            {
                cmb_UserBranch.DataSource = b.SelectCompBranches();
                cmb_UserBranch.DisplayMember = "Name";
                cmb_UserBranch.ValueMember = "Branch_ID";

                
            }
        }
        private void Frm_ExportExell_Load(object sender, EventArgs e)
        {
         

            dataGridView1.RowTemplate.Height = 50;
            txt_username.Text = Program.salesman;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //dataGridView1.DefaultCellStyle.Format = "yyyy-MM-dd   hh:mm tt";


            //dataGridView1.Columns["DATETIME"].DefaultCellStyle.Format = "yyyy-MM-dd   hh:mm tt";


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
         

        }
    
        
            
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            



        }
        //private void BindDataCSV(string filePath)
        //{
        //    //DataTable dt = new DataTable();
        //    string[] lines = System.IO.File.ReadAllLines(filePath);
        //    if (lines.Length > 0)
        //    {
        //        string firstLine = lines[0];
        //        string[] headerLabels = firstLine.Split(',');
        //        foreach (string headerWord in headerLabels)
        //        {
        //            dt.Columns.Add(new DataColumn(headerWord));
        //        }
        //        for (int r = 1; r < lines.Length; r++)
        //        {
        //            string[] dataWords = lines[r].Split(',');
        //            DataRow dr = dt.NewRow();
        //            int columnIndex = 0;
        //            foreach (string headerWord in headerLabels)
        //            {
        //                dr[headerWord] = dataWords[columnIndex++];
        //            }
        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    if (dt.Rows.Count > 0)
        //    {
        //        dataGridView1.DataSource = dt;
        //    }
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void fileExcelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            /// DLL MICROSOFT.OFFICE.INTEROP.EXCEL
            
            _Application importExcelToDataGridViewApp;
            _Workbook importExcelToDataGridViewWorkbook;
            _Worksheet importExcelToDataGridViewWorksheet;
            Range importExcelToDataGridViewRange;


            try
            {
                importExcelToDataGridViewApp = new Microsoft.Office.Interop.Excel.Application();

                OpenFileDialog importExcelToDataGridViewOpenFileDialog = new OpenFileDialog();
                //importExcelToDataGridViewOpenFileDialog.InitialDirectory = @"C:/Users/Authentic/Desktop";
                //importExcelToDataGridViewOpenFileDialog.RestoreDirectory = true;
                //Dialog Box Title
                importExcelToDataGridViewOpenFileDialog.Title = "Import Excel File To DataGridView";
                //filter Excel Files Only
                importExcelToDataGridViewOpenFileDialog.Filter = "Choose Excel File | *.xlsx;*.csv;*.xlm";
                //If Open Button Is Clicked
                if (importExcelToDataGridViewOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = importExcelToDataGridViewOpenFileDialog.FileName;
                    importExcelToDataGridViewWorkbook = importExcelToDataGridViewApp.Workbooks.Open(importExcelToDataGridViewOpenFileDialog.FileName);
                    importExcelToDataGridViewWorksheet = importExcelToDataGridViewWorkbook.ActiveSheet;
                    importExcelToDataGridViewRange = importExcelToDataGridViewWorksheet.UsedRange;


                    //System.Data.DataTable dt7 = new System.Data.DataTable();
                    //dt7.Columns.Add("NO", typeof(String));
                    //dt7.Columns.Add("DN", typeof(String));
                    //dt7.Columns.Add("UID", typeof(String));
                    //dt7.Columns.Add("po", typeof(String));
                    //dt7.Columns.Add("cfe", typeof(String));
                    //dt7.Columns.Add("sw", typeof(String));
                    //dt7.Columns.Add("aq", typeof(String));
                    //dt7.Columns.Add("DSF", typeof(String));
                    //dt7.Columns.Add("DATETIME", typeof(DateTime));
                    //Start Importing from the second row.Since the first row is column header
                    //for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex  < importExcelToDataGridViewRange.Rows.Count; excelWorkSheetRowIndex++)
                    //{
                    for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex < importExcelToDataGridViewRange.Rows.Count ; excelWorkSheetRowIndex++)
                    {

                        if (importExcelToDataGridViewRange.Item[excelWorkSheetRowIndex, 2].Value == null)
                        {

                        }
                        else
                        {
                            //this.dataGridView1.Columns[8].DefaultCellStyle.Format =  "yyyy-MM-dd   hh:mm tt";
                            //if (importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 9].NumberFormat != "yyyy-MM-dd   hh:mm tt")
                            //    {
                            
                            dataGridView1.Rows.Add(importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 1].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 2].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 3].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 4].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 5].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 6].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 7].Value,
                          importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 8].Value,
                         Convert.ToDateTime( importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 9].Value)
                           .ToString("dddd", new System.Globalization.CultureInfo("ar-EG")),
                                     Convert.ToDateTime(importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 9].Value)
                           .ToString("dd-MM-yyyy  hh:mm tt", new System.Globalization.CultureInfo("ar-EG"))); 
                      //      }
                  


                        }

                        //if (dt7.Rows.Count>0)
                        //{
                        //    int n = 0;
                        //    for (int i = 0; i < dt7.Rows.Count; i++)
                        //    {
                        //        n = dataGridView1.Rows.Add();
                        //        dataGridView1.Rows[n].Cells[0].Value = dt7.Rows[i][0].ToString();
                        //        dataGridView1.Rows[n].Cells[1].Value = dt7.Rows[i][1].ToString();
                        //        dataGridView1.Rows[n].Cells[2].Value = dt7.Rows[i][2].ToString();
                        //        dataGridView1.Rows[n].Cells[3].Value = dt7.Rows[i][3].ToString();
                        //        dataGridView1.Rows[n].Cells[4].Value = dt7.Rows[i][4].ToString();
                        //        dataGridView1.Rows[n].Cells[5].Value = dt7.Rows[i][5].ToString();
                        //        dataGridView1.Rows[n].Cells[6].Value = dt7.Rows[i][6].ToString();
                        //        dataGridView1.Rows[n].Cells[7].Value = dt7.Rows[i][7].ToString();
                        //        dataGridView1.Rows[n].Cells[8].Value = DateTime.Parse(dt7.Rows[i][8].ToString()).ToString("dd-MM-yyyy hh:mm tt");
                        //    }
                        //}









                    }
                

                }
            }
            catch (Exception importExcelToDataGridViewException)
            {
                MessageBox.Show("Error" + importExcelToDataGridViewException);
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            cmb_UserBranch.Enabled = false;
            System.Data.DataTable dt10 = new System.Data.DataTable();
            System.Data.DataTable dt2 = new System.Data.DataTable();
            Finger f = new Finger();
            try
            {//

                //label1.Invoke( (MethodInvoker)delegate()

                //{ 



                //});

                
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        dt10.Clear();
                        dt10 = f.selectcountidfingerExcel();

                        if (dt10.Rows.Count > 0)
                        {
                            //ToString("dd-MM-YYYY hh:mm tt")
                           

                                f.AddFingeerExcel(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), dataGridView1.Rows[i].Cells[3].Value.ToString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[9].Value), Convert.ToInt32(cmb_UserBranch.SelectedValue), txt_username.Text);




                        }
                        dt2.Clear();
                        dt2 = f.vildateHRINOUTExcel(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDateTime(dataGridView1.Rows[i].Cells[9].Value),Convert.ToInt32(cmb_UserBranch.SelectedValue));


                        if (dt2.Rows.Count == 0)
                        {
                         
                                    f.AddFingeerExcel(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), dataGridView1.Rows[i].Cells[3].Value.ToString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[9].Value), Convert.ToInt32(cmb_UserBranch.SelectedValue), txt_username.Text);

                               
                         
                          
                        }
                      


                        backgroundWorker1.ReportProgress(i);

                        if (progressBar1.Value <= dataGridView1.Rows.Count)
                        {

                            progressBar1.Value += 1;

                            label3.Text = progressBar1.Value.ToString();


                        }
                       
                    


                    }

                  

                    






                }
            }
            catch (Exception ex)
            {
                //return;
               // MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.StackTrace);
                
              
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {




            progressBar1.Show();



            progressBar1.Maximum = dataGridView1.Rows.Count;




            if (backgroundWorker1.IsBusy)
            {
               
                MessageBox.Show("جارى حفظ البينات ");
            }
            else
            {



                backgroundWorker1.RunWorkerAsync();
             

            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            

                MessageBox.Show("تم حفظ الداتا بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = "0";
                dataGridView1.Rows.Clear();
            progressBar1.Value = 0;
            textBox1.Clear();
            cmb_UserBranch.Enabled = true;







        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
        
            
        }
    }
}


