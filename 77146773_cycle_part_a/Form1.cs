using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace _77146773_cycle_part_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            int[] ARRHR;
            int[] ARRSPD;
            int[] ARRCAD;
            int[] ARRALT;
            int[] ARRPWR;
            int[] ARRPWRBAL;

            //Header Information
            foreach (string line in File.ReadAllLines("ASDBExampleCycleComputerData.hrm"))
            {
                string[] parts = line.Split('=');


                if (parts[0].Equals("Version"))
                {
                    label21.Text = parts[1];
                }

                if (parts[0].Equals("Monitor"))
                {
                    label22.Text = parts[1];
                }

                if (parts[0].Equals("StartTime"))
                {
                    label23.Text = parts[1];
                }

                if (parts[0].Equals("Length"))
                {
                    label24.Text = parts[1];
                }

                if (parts[0].Equals("SMode"))
                {
                    label13.Text = parts[1];
                }

                if (parts[0].Equals("Date"))
                {
                    label25.Text = parts[1];
                }

                if (parts[0].Equals("Interval"))
                {
                    label26.Text = parts[1];
                }

                if (parts[0].Equals("Weight"))
                {
                    label27.Text = parts[1];

                }

            }


            // Datagrid view colum header
            dataGridView1.Columns.Add("Line Number", "Line Number");
            dataGridView1.Columns.Add("HR", "HR");
            dataGridView1.Columns.Add("SPD", "SPD");
            dataGridView1.Columns.Add("CAD", "CAD");
            dataGridView1.Columns.Add("ALT", "ALT");
            dataGridView1.Columns.Add("PWR", "PWR");


            try
            {
                string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index2 = Array.IndexOf(arrData, "[HRData]");
                ARRHR = new int[arrData.Length - (index2 + 1)];
                ARRSPD = new int[arrData.Length - (index2 + 1)];
                ARRCAD = new int[arrData.Length - (index2 + 1)];
                ARRALT = new int[arrData.Length - (index2 + 1)];
                ARRPWR = new int[arrData.Length - (index2 + 1)];


                int j = 0;
                double total = 0;
                double heart = 0;
                double powertotal = 0;
                double alt = 0;


                for (int i = index2 + 1; i < arrData.Length; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");

                    ARRHR[j] = Convert.ToInt32(arrHrdata[0]);
                    ARRSPD[j] = Convert.ToInt32(arrHrdata[1]);
                    ARRCAD[j] = Convert.ToInt32(arrHrdata[2]);
                    ARRALT[j] = Convert.ToInt32(arrHrdata[3]);
                    ARRPWR[j] = Convert.ToInt32(arrHrdata[4]);


                    // for Average speed
                    double speed = Convert.ToDouble(arrHrdata[1]) / 10;
                    double xa = ARRSPD[j];
                    total = total + xa;

                    //Average heart Rate
                    double hrt = ARRHR[j];
                    heart = heart + hrt;


                    //Average power
                    double pwr = ARRPWR[j];
                    powertotal = powertotal + pwr;

                    double altitude = ARRALT[j];
                    alt = alt + altitude;

                    // Display data in DataGrid view
                    dataGridView1.Rows.Add(new object[] { i + 1, arrHrdata[0], speed.ToString(), ARRCAD[j], ARRALT[j], ARRPWR[j] });
                    j++;
                }


                double km = total / 10;

                //for total distance
                double distance = (km * 3978) / 3600;
                this.label28.Text = distance.ToString("#.###") + " km";

                //FOr average speed
                double avgspeed = km / (j);
                this.label29.Text = avgspeed.ToString("#.###") + " km";

                //for  maxspeed
                double maxspeed = ARRSPD.Max();
                double maxvalue = maxspeed / 10;
                this.label30.Text = maxvalue.ToString() + " km";


                //for average Heart Rate
                double avghr = heart / (j);
                this.label31.Text = avghr.ToString("#.###");

                //for maximum Hr data
                int maxhrt = ARRHR.Max();
                this.label32.Text = maxhrt.ToString();

                //for minimum Hr data
                int minhrt = ARRHR.Min();
                this.label33.Text = minhrt.ToString();


                //for average power
                double avgpwr = powertotal / (j);
                this.label34.Text = avgpwr.ToString("#.###");


                //for maximum power data
                int maxpwr = ARRPWR.Max();
                this.label35.Text = maxpwr.ToString();

                //for average ALT data
                double avgalt = alt / (j);
                this.label36.Text = avgalt.ToString("#.###");

                //For Maximum ALT data
                int Alt = ARRALT.Max();
                this.label37.Text = Alt.ToString();




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
