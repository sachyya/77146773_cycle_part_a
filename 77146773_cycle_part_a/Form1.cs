using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ZedGraph;
using System.Collections;

namespace _77146773_cycle_part_a
{
    public partial class Form1 : Form
    {
        List<double> heartRate = new List<double>();
        static double minHr, maxHr, avgHr;

        List<double> speed = new List<double>();
        static double maxSpeed, minSpeed, avgSpeed, distance;

        List<double> cadence = new List<double>();
        static double minCadence, maxCadence, avgCadence;

        List<double> altitude = new List<double>();
        static double minAltitude, maxAltitude, avgAltitude;

        List<double> power = new List<double>();
        static double minPower, maxPower, avgPower;
        //ArrayList hrArray,speedArray;

        delegate void SetTextCallback(string text);
        delegate void axisChangeZedGraphCallBack(ZedGraphControl zg);
        public Thread garthererThread;

        LineItem myCurve, myCurve2, myCurve3, myCurve4, myCurve5;
        PointPairList list1;
        PointPairList list2;
        PointPairList list3;
        PointPairList list4;
        PointPairList list5;
        GraphPane myPane;
        public Form1()
        {

            InitializeComponent();
        }

        static string[] getParam(string line)
        {
            //handles splitting upon given string and character delimiters
            return line.Split('=');
        }

        static string[] getData(string line)
        {
            return Regex.Split(line, @"\W+");
        }

        //retrieves the result of a String splt() method to a C# List. 
        //converts the String Array to a List.
        static IDictionary<string, string> parameters = new Dictionary<string, string>();

        string[] ARRHR;
        string[] ARRSPD;
        string[] ARRCAD;
        string[] ARRALT;
        string[] ARRPWR;
        string[] ARRPWRBAL;

        public void Thread1()
        {
            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            ARRHR = new string[arrData.Length - index2];
            int j = 0;



            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                ARRHR[j] = arrHrdata[0];

                this.SetText(ARRHR[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }


        private void axisChangeZedGraph(ZedGraphControl zg)
        {
            if (zg.InvokeRequired)
            {
                axisChangeZedGraphCallBack ad = new axisChangeZedGraphCallBack(axisChangeZedGraph);
                zg.Invoke(ad, new object[] { zg });
            }
            else
            {
                sachyya.AxisChange();
                zg.Invalidate();
                zg.Refresh();
            }
        }
        public void Thread2()
        {
            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            ARRSPD = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                ARRSPD[j] = arrHrdata[1];
                this.SetText1(ARRSPD[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }


        public void Thread3()
        {
            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            ARRCAD = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                ARRCAD[j] = arrHrdata[2];

                this.SetText2(ARRCAD[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }


        public void Thread4()
        {
            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            ARRALT = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                ARRALT[j] = arrHrdata[3];
                this.SetText3(ARRALT[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }


        public void Thread5()
        {
            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            ARRPWR = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                ARRPWR[j] = arrHrdata[4];

                this.SetText4(ARRPWR[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            myPane = sachyya.GraphPane;
            list1 = new PointPairList();
            list2 = new PointPairList();
            list3 = new PointPairList();
            list4 = new PointPairList();
            list5 = new PointPairList();
            myCurve = myPane.AddCurve("HR",
                 list1, Color.Red, SymbolType.Diamond);


            myCurve2 = myPane.AddCurve("Speed",
                 list2, Color.Blue, SymbolType.Circle);


            myCurve3 = myPane.AddCurve("CAD",
               list3, Color.Green, SymbolType.Diamond);


            myCurve4 = myPane.AddCurve("ALT",
                 list4, Color.Purple, SymbolType.Diamond);


            myCurve5 = myPane.AddCurve("PWR",
                 list5, Color.Brown, SymbolType.Diamond);

            Thread tid1 = new Thread(new ThreadStart(Thread1));
            Thread tid2 = new Thread(new ThreadStart(Thread2));
            Thread tid3 = new Thread(new ThreadStart(Thread3));
            Thread tid4 = new Thread(new ThreadStart(Thread4));
            Thread tid5 = new Thread(new ThreadStart(Thread5));
            Thread tidgc = new Thread(new ThreadStart(CreateGraph));
            tid1.Start();
            tid2.Start();
            tid3.Start();
            tid4.Start();
            tid5.Start();
            tidgc.Start();

            try
            {
                bool isParameter = false;
                bool isData = false;

                // Instance created of StreamReader to read from a file.
                // using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("ASDBExampleCycleComputerData.hrm"))
                {
                    string line;
                    // to read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isParameter)
                        {
                            if (line.Length > 0)
                            {
                                string[] p = getParam(line);
                                if (p[1] != null)
                                {
                                    parameters.Add(p[0], p[1]);
                                    Console.WriteLine("Parameter:" + line);
                                }
                            }
                        }
                        if (line.Length < 1 || line.Substring(0, 1) == "[")
                        {
                            isParameter = false;

                        }
                        if (line == "[Params]")
                        {
                            isParameter = true;

                        }
                        if (isData)
                        {
                            storeData(line);
                        }
                        if (line == "[HRData]")
                        {
                            isData = true;
                        }
                        // Console.WriteLine("Data" + isData.ToString());
                        //Console.WriteLine("Param" + isParameter.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                // showing the user about the problem
                Console.WriteLine("Error in reading the file :");
                Console.WriteLine(ex.ToString());
            }

            lblVer.Text = parameters["Version"];
            lblMoniter.Text = parameters["Monitor"];
            lblStartTime.Text = parameters["StartTime"];
            lblLength.Text = parameters["Length"];
            lblWeight.Text = parameters["Weight"];

            setHeartRate();
            labelMinHR.Text = minHr.ToString();
            labelMaxHR.Text = maxHr.ToString();
            labelAvgHR.Text = avgHr.ToString();

            setSpeed();
            labelMinSpeed.Text = minSpeed.ToString();
            labelMaxSpeed.Text = maxSpeed.ToString();
            labelAvgSpeed.Text = avgSpeed.ToString();
            labelDistance.Text = distance.ToString();

            setCadence();
            labelMinCadence.Text = minCadence.ToString();
            labelMaxCadence.Text = maxCadence.ToString();
            labelAvgCadence.Text = avgCadence.ToString();

            setAltitude();
            labelMinAltitude.Text = minAltitude.ToString();
            labelMaxAltitude.Text = maxAltitude.ToString();
            labelAvgAltitude.Text = avgAltitude.ToString();

            setPower();
            labelMinPower.Text = minPower.ToString();
            labelMaxPower.Text = maxPower.ToString();
            labelAvgPower.Text = avgPower.ToString();
        }

        private void TimerCallback(object source, ElapsedEventArgs e)
        {
            garthererThread = new Thread(new ThreadStart(GartherData));
        }

        private void GartherData()
        {
            List<float> gartheredInfo = new List<float>();

            //Do your garthering and parsing here (and put it in the gartheredInfo variable)

            //InformationHolder.Instance().graphData = gartheredInfo;

            sachyya.Invoke(new MethodInvoker( //you need to have a reference to the form
                    delegate
                    {
                        sachyya.Invalidate(); //or another method that redraws the graph
                    }));
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            try
            {
                if (this.alx7.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.alx7.Text = text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetText1(string text)
        {

            if (this.sachyya8.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText1);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.sachyya8.Text = text;
            }
        }

        private void SetText2(string text)
        {

            if (this.sachyya8.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.sachyya9.Text = text;
            }
        }

        private void SetText3(string text)
        {

            if (this.sachyya10.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText3);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.sachyya10.Text = text;
            }
        }

        private void SetText4(string text)
        {

            if (this.sachyya11.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText4);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.sachyya11.Text = text;
            }
        }

        private void CreateGraph()
        {
            myPane.Title.Text = "My Graph";
            myPane.XAxis.Title.Text = "My X Axis(LINE NUM)";
            myPane.YAxis.Title.Text = "My Y Axis(HR, SPD, CAD, ALT, PWR)";

            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            ARRHR = new string[arrData.Length - index2];
            ARRSPD = new string[arrData.Length - index2];
            ARRCAD = new string[arrData.Length - index2];
            ARRALT = new string[arrData.Length - index2];
            ARRPWR = new string[arrData.Length - index2];
            int j = 0;

            // Make up some, data arrays based on the Sine function
            double x, y1, y2, y3, y4, y5;
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            PointPairList list3 = new PointPairList();
            PointPairList list4 = new PointPairList();
            PointPairList list5 = new PointPairList();

            for (int i = index2 + 1; i < arrData.Length - 1; i += 1)
            {
                string HRData = arrData[i];

                string[] arrHrdata = Regex.Split(HRData, @"\W+");

                ARRHR[j] = arrHrdata[0];
                ARRSPD[j] = arrHrdata[1];
                ARRCAD[j] = arrHrdata[2];
                ARRALT[j] = arrHrdata[3];
                ARRPWR[j] = arrHrdata[4];

                int a = Int32.Parse(ARRHR[j]);
                int b = Int32.Parse(ARRSPD[j]);
                int c = Int32.Parse(ARRCAD[j]);
                int d = Int32.Parse(ARRALT[j]);
                int e = Int32.Parse(ARRPWR[j]);
                x = i;
                y1 = a;
                y2 = b;
                y3 = c;
                y4 = d;
                y5 = e;

                LineItem curve = sachyya.GraphPane.CurveList["HR"] as LineItem;
                // Get the PointPairList
                IPointListEdit list = curve.Points as IPointListEdit;
                list.Add(x, y1);
                LineItem curve2 = sachyya.GraphPane.CurveList["Speed"] as LineItem;
                // Get the PointPairList
                IPointListEdit list12 = curve2.Points as IPointListEdit;
                list12.Add(x, y2);
                LineItem curve3 = sachyya.GraphPane.CurveList["CAD"] as LineItem;
                // Get the PointPairList
                IPointListEdit list13 = curve3.Points as IPointListEdit;
                list13.Add(x, y3);
                LineItem curve4 = sachyya.GraphPane.CurveList["ALT"] as LineItem;
                // Get the PointPairList
                IPointListEdit list14 = curve4.Points as IPointListEdit;
                list14.Add(x, y4);
                LineItem curve5 = sachyya.GraphPane.CurveList["PWR"] as LineItem;
                // Get the PointPairLists
                IPointListEdit list15 = curve5.Points as IPointListEdit;
                list15.Add(x, y5);


                axisChangeZedGraph(sachyya);
                Thread.Sleep(700);
            }
        }

        private void sachyyaBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sachyyaBox1.Checked == true)
            {
                myCurve.IsVisible = false;
                sachyya.Invalidate();
            }
            else
            {
                myCurve.IsVisible = true;
                sachyya.Invalidate();
            }

        }

        private void sachyyaBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (sachyyaBox2.Checked == true)
            {
                myCurve2.IsVisible = false;
                sachyya2.Invalidate();
            }
            else
            {
                myCurve2.IsVisible = true;
                sachyya2.Invalidate();
            }

        }

        private void sachyyaBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (sachyyaBox3.Checked == true)
            {
                myCurve3.IsVisible = false;
                sachyya.Invalidate();
            }
            else
            {
                myCurve3.IsVisible = true;
                sachyya3.Invalidate();
            }

        }

        private void sachyyaBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (sachyyaBox4.Checked == true)
            {
                myCurve4.IsVisible = false;
                sachyya4.Invalidate();
            }
            else
            {
                myCurve4.IsVisible = true;
                sachyya4.Invalidate();
            }
        }

        private void sachyyaBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (sachyyaBox5.Checked == true)
            {
                myCurve5.IsVisible = false;
                sachyya5.Invalidate();
            }
            else
            {
                myCurve5.IsVisible = true;
                sachyya5.Invalidate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public double getAvg(List<int> list)
        {
            double total = 0;
            int i = 0;

            while (list.Count > i)
            {
                total = total + list[i];
            }
            return total / list.Count;
        }

        public double getMax(List<int> list)
        {
            double total = 0;
            int i = 0;
            while (list.Count > i)
            {
                total = total + list[i];
            }
            return total / list.Count;
        }

        public double getMin(List<int> list)
        {
            double min = 0;
            int i = 0;
            while (list.Count > i)
            {
                if (min > list[i])
                {
                    min = list[i];
                }

            }
            return min;
        }

        public void setHeartRate()
        {

            int i = 0;
            minHr = heartRate[0];
            maxHr = heartRate[0];
            avgHr = 0;
            double totalhr = 0;
            while (heartRate.Count > i)
            {
                if (minHr > heartRate[i])
                {
                    minHr = heartRate[i];
                }
                else if (maxHr < heartRate[i])
                {
                    maxHr = heartRate[i];
                }
                totalhr = totalhr + heartRate[i];

                i++;
            }
            avgHr = totalhr / heartRate.Count;

        }

        public void setSpeed()
        {
            int i = 0;
            minSpeed = speed[0];
            maxSpeed = speed[0];
            avgSpeed = 0;
            distance = 0;
            double totalSpeed = 0;
            while (speed.Count > i)
            {
                if (minSpeed > speed[i])
                {
                    minSpeed = speed[i];
                }
                else if (maxSpeed < speed[i])
                {
                    maxHr = speed[i];
                }
                totalSpeed = totalSpeed + speed[i];
                i++;
            }
            distance = totalSpeed * 360;
            avgSpeed = totalSpeed / speed.Count;
        }

        public void setCadence()
        {
            int i = 0;
            minCadence = cadence[0];
            maxCadence = cadence[0];
            avgCadence = 0;
            double totalCadence = 0;
            while (cadence.Count > i)
            {
                if (minCadence > cadence[i])
                {
                    minCadence = cadence[i];
                }
                else if (maxHr < cadence[i])
                {
                    maxCadence = cadence[i];
                }
                totalCadence = totalCadence + cadence[i];

                i++;
            }
            avgCadence = totalCadence / cadence.Count;

        }

        public void setAltitude()
        {
            int i = 0;
            minAltitude = altitude[0];
            maxAltitude = altitude[0];
            avgAltitude = 0;
            double totalAlt = 0;
            while (altitude.Count > i)
            {
                if (minAltitude > altitude[i])
                {
                    minAltitude = altitude[i];
                }
                else if (maxHr < altitude[i])
                {
                    maxAltitude = altitude[i];
                }
                totalAlt = totalAlt + altitude[i];

                i++;
            }
            avgAltitude = totalAlt / altitude.Count;

        }

        public void setPower()
        {
            int i = 0;
            minPower = power[0];
            maxPower = power[0];
            avgPower = 0;
            double totalPower = 0;
            while (power.Count > i)
            {
                if (minPower > power[i])
                {
                    minPower = power[i];
                }
                else if (maxPower < power[i])
                {
                    maxPower = power[i];
                }
                totalPower = totalPower + power[i];

                i++;
            }
            avgPower = totalPower / power.Count;

        }

        public void storeData(string line)
        {
            string[] data = getData(line);
            if (data.Length >= 5)
            {
                heartRate.Add(Convert.ToDouble(data[0]));
                speed.Add(Convert.ToDouble(data[1]));
                cadence.Add(Convert.ToDouble(data[2]));
                altitude.Add(Convert.ToDouble(data[3]));
                power.Add(Convert.ToDouble(data[4]));
            }
        }

        private void buttonShowPartB_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }
    }
}
