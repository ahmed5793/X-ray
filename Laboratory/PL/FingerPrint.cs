using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zkemkeeper;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class FingerPrint : Form
    {
         public  CZKEMClass zk = new CZKEMClass();
        public bool bIsConnect =false;
        private int iMachineNumber = 1;
        public FingerPrint()
        {
            InitializeComponent();
        }
        public void FPConnect(string ip , int Port)
        {
            bIsConnect = zk.Connect_Net(ip, Port);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Connect")
            {
                FPConnect(textBox1.Text, int.Parse(textBox2.Text));
                button2.Enabled = true;
                button1.Text = "Disconnect";
            }
            else
            {

                if (bIsConnect == true)
                {
                    zk.Disconnect();
                    button1.Text = "Connect";

                }
                else
                {
                    button1.Text = "Connect";
                }
            }

        }
        public void DoConnect()
        {
            FPConnect(textBox1.Text, int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("userno");
            dt.Columns.Add("CHECKTIME");
            dt.Columns.Add("Mode");


            if (bIsConnect == false)
            {
                DoConnect();
            }
            else
            {

                // dt.PrimaryKey = new[] { dt.Columns["CHECKTIME"] };

                string sdwEnrollNumber = "";
                int idwTMachineNumber = 0;
                int idwEMachineNumber = 0;
                int idwVerifyMode = 0;
                int idwInOutMode = 0;
                int idwYear = 0;
                int idwMonth = 0;
                int idwDay = 0;
                int idwHour = 0;
                int idwMinute = 0;
                int idwSecond = 0;
                int idwWorkcode = 0;

                int idwErrorCode = 0;
                int iGLCount = 0;
                int iIndex = 0;


                zk.EnableDevice(iMachineNumber, false);//disable the device
                if (zk.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                {

                    while (zk.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
                               out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                    {
                        iGLCount++;

                        DataRow row = dt.NewRow();
                        row[0] = sdwEnrollNumber;
                        row[1] = DateTime.Parse(idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString());
                        row[2] = idwInOutMode.ToString();
                        dt.Rows.Add(row);
                        iIndex++;
                    }
                }
                else
                {

                    zk.GetLastError(ref idwErrorCode);

                    if (idwErrorCode != 0)
                    {

                    }
                    else
                    {

                    }
                }
                zk.EnableDevice(iMachineNumber, true);//enable the device
                zk.Disconnect();


            }
            dataGridView1.DataSource = dt;
        }

        private void FingerPrint_Load(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Finger f = new Finger();
            DataTable dt = new DataTable();
            DataTable dt10 = new DataTable();



            if (dataGridView1.Rows.Count > 0)
            {
              

                  for (int i = 0; i < dataGridView1.Rows.Count; i++)
                  {

                    dt10.Clear();
                    dt10 = f.selectcountidfinger();

                        if (dt10.Rows.Count>0)
                        {
                            f.AddHrInOut(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));

                        }
                    dt.Clear();
                    dt = f.vildateHRINOUT(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value));


                    if (dt.Rows.Count==0)
                     {

                            f.AddHrInOut(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value), 1);
                     }

                    //else if (dt.Rows.Count > 0)
                    //{
                    //    f.AddHrInOut(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value), 0);

                    //}




                }
                MessageBox.Show("done");






            }
        }
    }
}
