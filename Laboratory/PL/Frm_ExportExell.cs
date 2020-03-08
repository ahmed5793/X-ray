using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ExcelDataReader;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Collections.Generic;
using CsvHelper;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace Laboratory.PL
{
    public partial class Frm_ExportExell : DevExpress.XtraEditors.XtraForm
    {
        //OleDbConnection con;
        //OleDbDataAdapter da;
        //DataTable dt;

        public Frm_ExportExell()
        {
            InitializeComponent();

        }

        private void Frm_ExportExell_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 50;
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

                    //Start Importing from the second row.Since the first row is column header
                    for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex < importExcelToDataGridViewRange.Rows.Count ; excelWorkSheetRowIndex++)
                    {
                        //Convert The Path to image and display it in datagridviewimagecolumn
                        dataGridView1.Rows.Add(importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 1].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 2].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 3].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 4].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 5].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 6].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 7].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 8].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 9].Value);
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
        //private void binddataCsv(string Filepath)
        //{
        //    DataTable dt = new DataTable();
        //    string[] lines = File.ReadAllLines(Filepath);
        //    if (lines.Length>0)
        //    {
        //        string FIRSTLINES = lines[0];
        //        string[] HEADERLABLES = FIRSTLINES.Split(',');
        //        foreach (string HEADERWORD in HEADERLABLES)
        //        {
        //            dt.Columns.Add(new DataColumn(HEADERWORD));
        //        }
        //        for (int i = 1; i < lines.Length; i++)
        //        {
        //            string[] datawords = lines[i].Split(',');
        //            DataRow dr = dt.NewRow();
        //            int columnindex = 0;
        //            foreach (string HEADERWORD in HEADERLABLES)
        //            {
        //                dr[HEADERWORD] = datawords[columnindex ++].Replace("\"", "").Replace("'", ""); ;  
        //            }
        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    if (dt.Rows.Count>0)
        //    {
        //        dataGridView1.DataSource = dt;
        //    }
        //}
    }
}


