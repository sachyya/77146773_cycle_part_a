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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /**
             ********************************************** DATA GRID VIEW TABLE ******************************************************
            **/
            int[] HR;
            int[] SPD;
            int[] CAD;
            int[] ALT;
            int[] PWR;

            // Datagrid view colum header
            dataGridView1.Columns.Add("SN", "SN");
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
                HR = new int[arrData.Length - (index2 + 1)];
                SPD = new int[arrData.Length - (index2 + 1)];
                CAD = new int[arrData.Length - (index2 + 1)];
                ALT = new int[arrData.Length - (index2 + 1)];
                PWR = new int[arrData.Length - (index2 + 1)];

                int j = 0;
                double total = 0;
                double heart = 0;
                double powerTotal = 0;
                double alt = 0;
                double sn = 1;

                for (int i = index2 + 1; i < arrData.Length; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");

                    HR[j] = Convert.ToInt32(arrHrdata[0]);
                    SPD[j] = Convert.ToInt32(arrHrdata[1]);
                    CAD[j] = Convert.ToInt32(arrHrdata[2]);
                    ALT[j] = Convert.ToInt32(arrHrdata[3]);
                    PWR[j] = Convert.ToInt32(arrHrdata[4]);

                    // Average speed
                    double speed = Convert.ToDouble(arrHrdata[1]) / 10;
                    double xa = SPD[j];
                    total = total + xa;

                    //Average heart Rate
                    double hrt = HR[j];
                    heart = heart + hrt;

                    //Average power
                    double pwr = PWR[j];
                    powerTotal = powerTotal + pwr;

                    //Average altitude
                    double altitude = ALT[j];
                    alt = alt + altitude;

                    // Display data in DataGrid view
                    dataGridView1.Rows.Add(new object[] { sn++, arrHrdata[0], speed.ToString(), CAD[j], ALT[j], PWR[j] });
                    j++;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /**
             ********************************************** DATA GRID VIEW TABLE ENDS ******************************************************
            **/

            /**
            ********************************************** INTERVAL DETECTION STARTS ******************************************************
            **/

            int[] GEPPWR;
            int[] GEPPWR2;
            int[] GEPPWR3;
            int[] GEPPWR4;

            //for 1st set
            try
            {
                string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index2 = Array.IndexOf(arrData, "[HRData]");

                GEPPWR = new int[arrData.Length - (index2 + 1)];

                int j = 0;
                double powertotal = 0;

                for (int i = index2 + 1; i < 147; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");

                    GEPPWR[j] = Convert.ToInt32(arrHrdata[4]);

                    // total power1
                    double pwr = GEPPWR[j];
                    powertotal = powertotal + pwr;

                    j++;
                }

                // average power1
                double avgpower1 = Math.Round(powertotal / j);
                this.labelAvgPower1.Text = avgpower1.ToString();

                // maximum power1
                int maxpwr1 = GEPPWR.Max();
                this.labelHighPower1.Text = maxpwr1.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //for 2nd Group
            try
            {
                string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index2 = Array.IndexOf(arrData, "[HRData]");

                GEPPWR2 = new int[arrData.Length - (index2 + 1)];

                int k = 0;
                double powertotal2 = 0;

                for (int i = index2 + 35; i < 723; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");

                    GEPPWR2[k] = Convert.ToInt32(arrHrdata[4]);

                    // total power2
                    double pwr2 = GEPPWR2[k];
                    powertotal2 = powertotal2 + pwr2;
                    k++;
                }

                // average power2
                double avgpower2 = Math.Round(powertotal2 / k);
                this.labelAvgPower2.Text = avgpower2.ToString();

                // maximum power2
                int maxpwr2 = GEPPWR2.Max();
                this.labelHighPower2.Text = maxpwr2.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //for 3rd Group
            try
            {
                string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index2 = Array.IndexOf(arrData, "[HRData]");

                GEPPWR3 = new int[arrData.Length - (index2 + 1)];

                int b = 0;
                double powertotal3 = 0;

                for (int i = index2 + 608; i < 1339; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");

                    GEPPWR3[b] = Convert.ToInt32(arrHrdata[4]);

                    // total power3
                    double pwr3 = GEPPWR3[b];
                    powertotal3 = powertotal3 + pwr3;
                    b++;
                }

                // average power3
                double avgpower3 = Math.Round(powertotal3 / b);
                this.labelAvgPower3.Text = avgpower3.ToString();

                // maximum power2
                int maxpwr3 = GEPPWR3.Max();
                this.labelHighPower3.Text = maxpwr3.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //for 4th set
            try
            {
                string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index2 = Array.IndexOf(arrData, "[HRData]");

                GEPPWR4 = new int[arrData.Length - (index2 + 1)];

                int d = 0;
                double powertotal4 = 0;

                for (int i = index2 + 1510; i < 2245; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");

                    GEPPWR4[d] = Convert.ToInt32(arrHrdata[4]);

                    // total power4
                    double pwr4 = GEPPWR4[d];
                    powertotal4 = powertotal4 + pwr4;
                    d++;
                }

                // average power4
                double avgpower4 = Math.Round(powertotal4 / d);
                this.labelAvgPower4.Text = avgpower4.ToString();

                // maximum power4
                int maxpwr4 = GEPPWR4.Max();
                this.labelHighPower4.Text = maxpwr4.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /**
            ********************************************** INTERVAL DETECTION ENDS ******************************************************
            **/
                
            /**
             ********************************************** ADVANCED METRIC ******************************************************
            **/
            int[] power1;
            int[] power2;
            int[] power3;
            double avgPwr1 = 0;
            double avgPwr3 = 0;
            double avgPwr2 = 0;

            //read data from ASDBExampleCycleComputerData.hrm
            try
            {
                string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index1 = Array.IndexOf(arrData, "[HRData]");

                power1 = new int[arrData.Length - (index1 + 1)];


                int j = 0;
                double powerTotal1 = 0;

                for (int i = index1 + 1; i < arrData.Length; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");
                    power1[j] = Convert.ToInt32(arrHrdata[4]);

                    powerTotal1 = powerTotal1 + power1[j];
                    j++;
                }

                //calculate average power
                avgPwr1 = Math.Round(powerTotal1 / (j));
                this.labelAvgPower1Label.Text = avgPwr1.ToString("#.###") + " watts";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // read data from data1.hrm
            try
            {
                string txtData = File.ReadAllText("data1.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index2 = Array.IndexOf(arrData, "[HRData]");

                power2 = new int[arrData.Length - (index2 + 1)];


                int j = 0;
                double powerTotal2 = 0;

                for (int i = index2 + 1; i < arrData.Length; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");
                    power2[j] = Convert.ToInt32(arrHrdata[4]);

                    powerTotal2 = powerTotal2 + power2[j];
                    j++;
                }

                // calculate average power
                avgPwr2 = Math.Round(powerTotal2 / (j));

                this.labelAvgPower2Label.Text = avgPwr2.ToString("#.###") + " watts";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            // read data from data2.hrm
            try
            {
                string txtData = File.ReadAllText("data2.hrm");
                string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int index3 = Array.IndexOf(arrData, "[HRData]");

                power3 = new int[arrData.Length - (index3 + 1)];


                int j = 0;
                double powerTotal3 = 0;

                for (int i = index3 + 1; i < arrData.Length; i++)
                {
                    string HRData = arrData[i];
                    string[] arrHrdata = Regex.Split(HRData, @"\W+");
                    power3[j] = Convert.ToInt32(arrHrdata[4]);

                    powerTotal3 = powerTotal3 + power3[j];
                    j++;
                }

                // calculate average power
                avgPwr3 = Math.Round(powerTotal3 / (j));
                this.labelAvgPower3Label.Text = avgPwr3.ToString("#.###") + " watts";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // calculate Functional Threshold Power (FTP): 
            double ftp = avgPwr1 * 0.05;
            double totalftp = avgPwr1 - ftp;
            this.fnThresPowerLabel.Text = totalftp.ToString("#.#####") + " watts";


            // calculate Normalized Power (NP)

            double f1 = Math.Pow(avgPwr1, 4.0);
            double f2 = Math.Pow(avgPwr2, 4.0);
            double f3 = Math.Pow(avgPwr3, 4.0);

            double m1 = f1 * 66.0;
            double m2 = f2 * 10.0;
            double m3 = f3 * 27.0;

            double totalm = m1 + m2 + m3;
            double timedoubel = totalm / 60.0;
            double np = Math.Pow(timedoubel, (1.0 / 4));

            this.noramalPowerLabel.Text = np.ToString("#.###") + " watts";


            // calculate Intensity Factor:

            double iF = np / totalftp;
            this.intensityFactorLabel.Text = iF.ToString("#.###");



            //calculating Total Stress Score
            double tss = ((3960 * np * iF) / (totalftp * 3600)) * 100;

            trainSSLabel.Text = tss.ToString("#.###");
        }
        /**
        ********************************************** ADVANCED METRIC ENDS ******************************************************
        **/

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /**
        ********************************************** TABLE CELL CLICK EVENT ******************************************************
        **/
        int left;
        int right;
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    left = Convert.ToInt32( row.Cells["SN"].Value.ToString() );
                    MessageBox.Show("Selected left value: " + left);
                }
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                right = Convert.ToInt32(row.Cells["SN"].Value.ToString());
                MessageBox.Show("Selected right value: " + right);
            }
        }
        /**
        ********************************************** TABLE CELL CLICK EVENT ENDS ******************************************************
        **/

        /**
        ********************************************** GET GRAPH EVENT TRIGGER ******************************************************
        **/
        private void get_graph_button_Click(object sender, EventArgs e)
        {
            if (left < right)
            {
                single_data_graph obj = new single_data_graph();
                obj.leftvalue = left;
                obj.rightvalue = right;

                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid range selected!!!");
            }
        }
        /**
        ********************************************** GET GRAPH EVENT TRIGGER ENDS ******************************************************
        **/

        /**
        ********************************************** CALENDER DAY CLICK EVENT ******************************************************
        **/
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            String a = e.Start.Date.ToString();


            if ("5/1/2016 12:00:00 AM" == a)
            {

                calender obj = new calender();
                string file = "ASDBExampleCycleComputerData.hrm";
                obj.label_file.Text = file;
                obj.ShowDialog();
            }


            else if ("5/4/2016 12:00:00 AM" == a)
            {
                calender obj = new calender();
                string file = "Data1.hrm";
                obj.label_file.Text = file;
                obj.ShowDialog();

            }

            else if ("5/7/2016 12:00:00 AM" == a)
            {
                calender obj = new calender();
                string file = "Data2.hrm";
                obj.label_file.Text = file;
                obj.ShowDialog();

            }
            else
            {
                MessageBox.Show("failed");
            }

        /**
        ********************************************** CALENDER DAY CLICK EVENT ENDS ******************************************************
        **/

        
        }
    }
}
