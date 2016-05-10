using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _77146773_cycle_part_a
{
    public partial class calender : Form
    {
        public calender()
        {
            InitializeComponent();
        }

        private void calender_Load(object sender, EventArgs e)
        {
            int[] arrHR;
            int[] arSpeed;
            int[] arrCadance;
            int[] arrAltitude;
            int[] arrPower;


            string file1 = label_file.Text;

            //Header Information
            foreach (string line in File.ReadAllLines(file1))
            {
                string[] parts = line.Split('=');


                if (parts[0].Equals("Version"))
                {
                    label_version.Text = parts[1];
                }

                if (parts[0].Equals("Monitor"))
                {
                    label_monitor.Text = parts[1];
                }

                if (parts[0].Equals("StartTime"))
                {
                    label_start_time.Text = parts[1];
                }

                if (parts[0].Equals("Length"))
                {
                    label_length.Text = parts[1];
                }

                if (parts[0].Equals("SMode"))
                {
                    label_smode.Text = parts[1];
                }

                if (parts[0].Equals("Date"))
                {
                    label_date.Text = parts[1];
                }

                if (parts[0].Equals("Interval"))
                {
                    label_interval.Text = parts[1];
                }
            }

            // Datagrid view colum header
        
            calanderDataGridView.Columns.Add("HR", "HR");
            calanderDataGridView.Columns.Add("SPD", "SPD");
            calanderDataGridView.Columns.Add("CAD", "CAD");
            calanderDataGridView.Columns.Add("ALT", "ALT");
            calanderDataGridView.Columns.Add("PWR", "PWR");

            string txtData = File.ReadAllText(file1);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            arrHR = new int[arrData.Length - (index2 + 1)];
            arSpeed = new int[arrData.Length - (index2 + 1)];
            arrCadance = new int[arrData.Length - (index2 + 1)];
            arrAltitude = new int[arrData.Length - (index2 + 1)];
            arrPower = new int[arrData.Length - (index2 + 1)];

            int j = 0;
            double total = 0;
            double heart = 0;
            double powertotal = 0;
            double alt = 0;

            for (int i = index2 + 1; i < arrData.Length; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");

                arrHR[j] = Convert.ToInt32(arrHrdata[0]);
                arSpeed[j] = Convert.ToInt32(arrHrdata[1]);
                arrCadance[j] = Convert.ToInt32(arrHrdata[2]);
                arrAltitude[j] = Convert.ToInt32(arrHrdata[3]);
                arrPower[j] = Convert.ToInt32(arrHrdata[4]);


                // for Average speed
                double speed = Convert.ToDouble(arrHrdata[1]) / 10;
                double xa = arSpeed[j];
                total = total + xa;

                //Average heart Rate
                double hrt = arrHR[j];
                heart = heart + hrt;


                //Average power
                double pwr = arrPower[j];
                powertotal = powertotal + pwr;

                double altitude = arrAltitude[j];
                alt = alt + altitude;

                // Display data in DataGrid view
                calanderDataGridView.Rows.Add(new object[] { arrHrdata[0], speed.ToString(), arrCadance[j], arrAltitude[j], arrPower[j], (j + 1).ToString() });
                j++;
            }

            double km = total / 10;

            //FOr average speed
            double avgspeed = km / (j);
            this.label_speed.Text = avgspeed.ToString("#.####");

            //for average Heart Rate
            double avghr = heart / (j);
            this.label_hr.Text = avghr.ToString("#.###");

            double avgpwr = powertotal / (j);
            this.label_pwr.Text = avgpwr.ToString("#.###");

            //for average ALT data
            double avgalt = alt / (j);
            this.label_avg.Text = avgalt.ToString("#.###");
        }

        }
    }
