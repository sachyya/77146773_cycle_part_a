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
using ZedGraph;

namespace _77146773_cycle_part_a
{
    public partial class single_data_graph : Form
    {
        public single_data_graph()
        {
            InitializeComponent();
        }

        public int leftvalue;
        public int rightvalue;
        string[] ARRHR;
        string[] ARRSPD;
        string[] ARRCAD;
        string[] ARRALT;
        string[] ARRPWR;

        int[] HR;
        int[] SPD;
        int[] CAD;
        int[] ALT;
        int[] PWR;
        private void single_data_graph_Load(object sender, EventArgs e)
        {


            // Setup the graph
            GetGraph(zedGraph);



            string txtData = File.ReadAllText("ASDBExampleCycleComputerData.hrm");
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            HR = new int[arrData.Length - (index2 + 1)];
            SPD = new int[arrData.Length - (index2 + 1)];
            CAD = new int[arrData.Length - (index2 + 1)];
            ALT = new int[arrData.Length - (index2 + 1)];
            PWR = new int[arrData.Length - (index2 + 1)];

            int j = 0;
            double hr = 0;
            double speed = 0;
            double cad = 0;
            double alt = 0;
            double pow = 0;


            for (int i = (index2 + 1) + leftvalue; i <= (index2 + 1) + rightvalue; i++)
            {

                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");

                HR[j] = Convert.ToInt32(arrHrdata[0]);
                SPD[j] = Convert.ToInt32(arrHrdata[1]);
                CAD[j] = Convert.ToInt32(arrHrdata[2]);
                ALT[j] = Convert.ToInt32(arrHrdata[3]);
                PWR[j] = Convert.ToInt32(arrHrdata[4]);

                double avghr = HR[j];
                hr = hr + avghr;
                j++;

            }

        }

        private void GetGraph(ZedGraphControl zedGraph)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zedGraph.GraphPane;

            // Set the Titles
            myPane.Title.Text = " Graph\n(Range Data Graph)";
            myPane.XAxis.Title.Text = "X Axis";
            myPane.YAxis.Title.Text = "Y Axis(HR, SPD, CAD, ALT, PWR)";



            ///
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




            for (int i = (index2 + 1) + leftvalue; i <= (index2 + 1) + rightvalue; i++)
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

                list1.Add(x, y1);
                list2.Add(x, y2);
                list3.Add(x, y3);
                list4.Add(x, y4);
                list5.Add(x, y5);
            }

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            myCurve = myPane.AddCurve("HR",
             list1, Color.Red, SymbolType.Diamond);

            // Generate a blue curve with circle
            // symbols, and "Piper" in the legend
            myCurve2 = myPane.AddCurve("Speed",
             list2, Color.Blue, SymbolType.Circle);


            myCurve3 = myPane.AddCurve("CAD",
           list3, Color.Green, SymbolType.Diamond);


            myCurve4 = myPane.AddCurve("ALT",
          list4, Color.Purple, SymbolType.Diamond);


            myCurve5 = myPane.AddCurve("PWR",
             list5, Color.Brown, SymbolType.Diamond);

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zedGraph.AxisChange();

            // Change the color of the title
            myPane.Title.FontSpec.FontColor = Color.Green;

            // Add gridlines to the plot, and make them gray
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.LightGray;
            myPane.YAxis.MajorGrid.Color = Color.LightGray;

            // Move the legend location
            myPane.Legend.Position = ZedGraph.LegendPos.Bottom;

            // Make both curves thicker
            myCurve.Line.Width = 2.0F;
            myCurve2.Line.Width = 2.0F;
            myCurve3.Line.Width = 2.0F;
            myCurve4.Line.Width = 2.0F;
            myCurve5.Line.Width = 2.0F;






        }
        LineItem myCurve, myCurve2, myCurve3, myCurve4, myCurve5;
    }
}
