using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;

namespace KiyoskStatus
{
    public partial class Form1 : Form
    {
        List<kiyosk> KiyoskList;


        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 43;

            listView1.View = View.Details;

            listView1.Columns.Add("ID", 200);
            listView1.Columns.Add("resturant", 100);

            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            

            KiyoskList = new List<kiyosk>()
            {
                new kiyosk(){ComputerName= "3706A-2007-RST1",RestutantName="یک",ID_Khadamat="3706",type=false},
                new kiyosk(){ComputerName= "3707A-2007-RST1",RestutantName="یک",ID_Khadamat="3707",type=false},
                new kiyosk(){ComputerName= "3708A-2019-RST2",RestutantName="یک",ID_Khadamat="3708",type=false},
                new kiyosk(){ComputerName= "3710-7265-AR01",RestutantName="AR",ID_Khadamat="3710",type=false},
                new kiyosk(){ComputerName= "3631A-2736-RST4",RestutantName="AR",ID_Khadamat="3631",type=false},
                new kiyosk(){ComputerName= "3626-4145-OL01",RestutantName="AR",ID_Khadamat="3626",type=false},
                new kiyosk(){ComputerName= "3627-4145-OL02",RestutantName="AR",ID_Khadamat="3627",type=false},
                new kiyosk(){ComputerName= "3818-7265-AR03",RestutantName="AR",ID_Khadamat="3818",type=true},
                new kiyosk(){ComputerName= "3711-7265-AR02",RestutantName="AR",ID_Khadamat="3711",type=true},
                new kiyosk(){ComputerName= "3628-4145-OL03",RestutantName="AR",ID_Khadamat="3628",type=true},
                new kiyosk(){ComputerName= "3637-2014-RST3",RestutantName="مرکزی",ID_Khadamat="3637",type=false},
                new kiyosk(){ComputerName= "3636-2014-RST3",RestutantName="مرکزی",ID_Khadamat="3636",type=false},
                new kiyosk(){ComputerName= "3635-2014-RST3",RestutantName="مرکزی",ID_Khadamat="3635",type=false},
                new kiyosk(){ComputerName= "3638-2016-RST3",RestutantName="مرکزی",ID_Khadamat="3638",type=false},
                new kiyosk(){ComputerName= "3639-2014-RST3",RestutantName="مرکزی",ID_Khadamat="3639",type=false},
                new kiyosk(){ComputerName= "rst3-w02",RestutantName="مرکزی",ID_Khadamat="rst3-w02",type=true},
                new kiyosk(){ComputerName= "rst3-w01",RestutantName="مرکزی",ID_Khadamat="rst3-w01",type=true},
                new kiyosk(){ComputerName= "3620-3418-PVC",RestutantName="PVC",ID_Khadamat="3620",type=false},
                new kiyosk(){ComputerName= "3746A-3418-PVC",RestutantName="PVC",ID_Khadamat="3746",type=true},
                new kiyosk(){ComputerName= "3717-4305-CA02",RestutantName="CA",ID_Khadamat="3717",type=false},
                new kiyosk(){ComputerName= "3716-4305-CA01",RestutantName="CA",ID_Khadamat="3716",type=false},
                new kiyosk(){ComputerName= "3763-4305-CA",RestutantName="CA",ID_Khadamat="3763",type=true},
                new kiyosk(){ComputerName= "3621-4212-PP",RestutantName="PP",ID_Khadamat="3621",type=false},
                new kiyosk(){ComputerName= "3764-4212-PP",RestutantName="PP",ID_Khadamat="3764",type=true},
                new kiyosk(){ComputerName= "3623-4452-LD",RestutantName="LD",ID_Khadamat="3623",type=false},
                new kiyosk(){ComputerName= "3744A-4452-LD",RestutantName="LD",ID_Khadamat="3744",type=true},
                new kiyosk(){ComputerName= "3624A-4844-UT01",RestutantName="UT",ID_Khadamat="3624",type=false},
                new kiyosk(){ComputerName= "3625A-4844-UT02",RestutantName="UT",ID_Khadamat="3625",type=false},
                new kiyosk(){ComputerName= "3633A-4844-UT03",RestutantName="UT",ID_Khadamat="3633",type=true},
                new kiyosk(){ComputerName= "3719-4057-MTBE",RestutantName="MTBE",ID_Khadamat="3719",type=false},
                new kiyosk(){ComputerName= "3632-4145-OL04",RestutantName="MTBE",ID_Khadamat="3632",type=true},
                new kiyosk(){ComputerName= "3712-7265-AR03",RestutantName="انبارها",ID_Khadamat="3712",type=false},
                new kiyosk(){ComputerName= "3630A-3342-HSE",RestutantName="HSE",ID_Khadamat="3630",type=false},
                new kiyosk(){ComputerName= "3622-4034-BDSR",RestutantName="BDSR",ID_Khadamat="3622",type=false},
                new kiyosk(){ComputerName= "3765-4034-BDSR",RestutantName="BDSR",ID_Khadamat="3765",type=true},
                new kiyosk(){ComputerName= "3709A-2019-RST2",RestutantName="خواهران",ID_Khadamat="3709",type=false},
                new kiyosk(){ComputerName= "3704A-2007-RST1",RestutantName="خواهران",ID_Khadamat="3704",type=false},
                new kiyosk(){ComputerName= "3713-4174-CF",RestutantName="CF",ID_Khadamat="3713",type=false},
                new kiyosk(){ComputerName= "3629-7614-NF3",RestutantName="NF3",ID_Khadamat="3629",type=false},
                new kiyosk(){ComputerName= "3715-4544-HD",RestutantName="HD",ID_Khadamat="3715",type=false},
                new kiyosk(){ComputerName= "3766-4544-HD",RestutantName="HD",ID_Khadamat="3766",type=true},
                new kiyosk(){ComputerName= "3634-2014-RST3",RestutantName="MTBE2",ID_Khadamat="3634",type=false},
                new kiyosk(){ComputerName= "3762-4325-VC",RestutantName="VC",ID_Khadamat="3762",type=false},

            };

        }

        private void Form1_Load(object sender, EventArgs e)

        {



        }


        public void RunCheck()
        {



            List<kiyosk> error = new List<kiyosk>();
            int j = 1;
            foreach (var item in KiyoskList)
            {

                if (!item.ComputerName.Trim().CheckIp())
                {
                    error.Add(item);

                }
            }

            LoadLabels(error);

        }
        public void LoadLabels(List<kiyosk> list)
        {

            kiyosk item;
            listView1.Invoke(new Action(() =>
            {
                listView1.Items.Clear();
            }));
           

            for (int i = 0; i < list.Count(); i++)
            {
                item = list.ElementAt(i);
                listView1.Invoke(new Action(() =>
                {
                    listView1.Items.Add(new ListViewItem(new string[] { item.ID_Khadamat, item.RestutantName }));
                }));
            

            }




        }

        private void BtnRun_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "در حال بارگذاری ...";
            lblStatus.ForeColor = Color.Navy;
            BtnRun.Enabled = false;
            lblStatus.Visible = true;
            progressBar1.Visible = true;
            panel1.Visible = false;

            backgroundWorker1.RunWorkerAsync();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                var selectitem = item.SubItems[0].Text;

                var s = KiyoskList.Where(p => p.ID_Khadamat.CompareTo(selectitem) == 0).FirstOrDefault();

                panel1.Visible = true;

                lbKhadamat.Text = s.ID_Khadamat;
                lbResturant.Text = s.RestutantName;
                lbComputerName.Text = s.ComputerName;
                lbType.Text = (s.type ? "رزرو" : "ژتون دهی");
                lbTel.Text = s.Tel;

                BtnRun.Enabled = true;
                int x = 0;

            }
            else
            {
                //EmpIDtextBox.Text = string.Empty;
                //EmpNametextBox.Text = string.Empty;
            }
        }

        public static double PingTimeAverage(string host, int echoNum)
        {
            long totalTime = 0;
            int timeout = 120;
            Ping pingSender = new Ping();

            for (int i = 0; i < echoNum; i++)
            {
                PingReply reply = pingSender.Send(host, timeout);
                if (reply.Status == IPStatus.Success)
                {
                    totalTime += reply.RoundtripTime;
                }
            }
            return totalTime / echoNum;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<kiyosk> error = new List<kiyosk>();
            int j = 1;
            foreach (var item in KiyoskList)
            {

                if (!item.ComputerName.Trim().CheckIp())
                {
                    error.Add(item);

                }
                 backgroundWorker1.ReportProgress(j);
                j++;
            }

           
            LoadLabels(error);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "پردازش انجام شد";
            lblStatus.ForeColor = Color.DarkGreen;
            BtnRun.Enabled = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void lbComputerName_Click(object sender, EventArgs e)
        {
            lbComputerName.Focus();
            Clipboard.SetText(lbComputerName.Text);
        }

        private void lbKhadamat_Click(object sender, EventArgs e)
        {
            string computername = lbComputerName.Text;
            string aptracommand;
            aptracommand = "/k ping " + computername + " -t";
            Process.Start(@"cmd", aptracommand);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



    public static class StringExtension
    {
        public static bool CheckIp(this string ip)
        {
            try
            {
                Ping p = new Ping();
                PingReply r;
                string s;
                s = ip;
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {

                    //MessageBox.Show("Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                    //   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n");

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }




        }
    }


}


