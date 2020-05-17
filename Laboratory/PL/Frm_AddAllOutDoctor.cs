using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class Frm_AddAllOutDoctor : Form
    {
        Doctors d = new Doctors();
        public Frm_AddAllOutDoctor()
        {
            InitializeComponent();
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
                    for (int excelWorkSheetRowIndex = 1; excelWorkSheetRowIndex < importExcelToDataGridViewRange.Rows.Count; excelWorkSheetRowIndex++)
                    {

                        if (importExcelToDataGridViewRange.Item[excelWorkSheetRowIndex, 1].Value == null)
                        {

                        }
                        else
                        {

                            dataGridView1.Rows.Add(importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 0].Value);


                        }


                    }

                }
            }

            catch (Exception importExcelToDataGridViewException)
            {
                MessageBox.Show("Error" + importExcelToDataGridViewException);
            }
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                d.AddDoctor(dataGridView1.Rows[i].Cells[0].Value.ToString(), null, null, DateTime.Now , 1);
                MessageBox.Show("تم اضافه بيانات الطبيب بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
