namespace _77146773_cycle_part_a
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.form3_tab = new System.Windows.Forms.TabControl();
            this.graph_tab = new System.Windows.Forms.TabPage();
            this.data_grid_view_tab = new System.Windows.Forms.TabPage();
            this.get_graph_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.advanced_metrics = new System.Windows.Forms.TabPage();
            this.advMetricsGroupBox = new System.Windows.Forms.GroupBox();
            this.trainSSLabel = new System.Windows.Forms.Label();
            this.noramalPowerLabel = new System.Windows.Forms.Label();
            this.intensityFactorLabel = new System.Windows.Forms.Label();
            this.fnThresPowerLabel = new System.Windows.Forms.Label();
            this.labelAvgPower3Label = new System.Windows.Forms.Label();
            this.labelAvgPower2Label = new System.Windows.Forms.Label();
            this.labelAvgPower1Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.interval_detection_tab = new System.Windows.Forms.TabPage();
            this.labelHighPower1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAvgPower1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.labelHighPower4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.labelAvgPower4 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelHighPower2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelAvgPower2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelHighPower3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelAvgPower3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.form3_tab.SuspendLayout();
            this.data_grid_view_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.advanced_metrics.SuspendLayout();
            this.advMetricsGroupBox.SuspendLayout();
            this.interval_detection_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form3_tab
            // 
            this.form3_tab.Controls.Add(this.graph_tab);
            this.form3_tab.Controls.Add(this.data_grid_view_tab);
            this.form3_tab.Controls.Add(this.advanced_metrics);
            this.form3_tab.Controls.Add(this.interval_detection_tab);
            this.form3_tab.Location = new System.Drawing.Point(12, 12);
            this.form3_tab.Name = "form3_tab";
            this.form3_tab.SelectedIndex = 0;
            this.form3_tab.Size = new System.Drawing.Size(929, 482);
            this.form3_tab.TabIndex = 0;
            // 
            // graph_tab
            // 
            this.graph_tab.Location = new System.Drawing.Point(4, 22);
            this.graph_tab.Name = "graph_tab";
            this.graph_tab.Padding = new System.Windows.Forms.Padding(3);
            this.graph_tab.Size = new System.Drawing.Size(921, 456);
            this.graph_tab.TabIndex = 0;
            this.graph_tab.Text = "Graph";
            this.graph_tab.UseVisualStyleBackColor = true;
            // 
            // data_grid_view_tab
            // 
            this.data_grid_view_tab.BackColor = System.Drawing.Color.DimGray;
            this.data_grid_view_tab.Controls.Add(this.get_graph_button);
            this.data_grid_view_tab.Controls.Add(this.monthCalendar1);
            this.data_grid_view_tab.Controls.Add(this.dataGridView1);
            this.data_grid_view_tab.Location = new System.Drawing.Point(4, 22);
            this.data_grid_view_tab.Name = "data_grid_view_tab";
            this.data_grid_view_tab.Padding = new System.Windows.Forms.Padding(3);
            this.data_grid_view_tab.Size = new System.Drawing.Size(921, 456);
            this.data_grid_view_tab.TabIndex = 1;
            this.data_grid_view_tab.Text = "Data Grid View";
            // 
            // get_graph_button
            // 
            this.get_graph_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.get_graph_button.Location = new System.Drawing.Point(690, 180);
            this.get_graph_button.Name = "get_graph_button";
            this.get_graph_button.Size = new System.Drawing.Size(222, 23);
            this.get_graph_button.TabIndex = 2;
            this.get_graph_button.Text = "Get Graph";
            this.get_graph_button.UseVisualStyleBackColor = true;
            this.get_graph_button.Click += new System.EventHandler(this.get_graph_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(685, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // advanced_metrics
            // 
            this.advanced_metrics.Controls.Add(this.advMetricsGroupBox);
            this.advanced_metrics.Location = new System.Drawing.Point(4, 22);
            this.advanced_metrics.Name = "advanced_metrics";
            this.advanced_metrics.Padding = new System.Windows.Forms.Padding(3);
            this.advanced_metrics.Size = new System.Drawing.Size(921, 456);
            this.advanced_metrics.TabIndex = 2;
            this.advanced_metrics.Text = "Advanced Metrics";
            this.advanced_metrics.UseVisualStyleBackColor = true;
            // 
            // advMetricsGroupBox
            // 
            this.advMetricsGroupBox.BackColor = System.Drawing.Color.Crimson;
            this.advMetricsGroupBox.Controls.Add(this.trainSSLabel);
            this.advMetricsGroupBox.Controls.Add(this.noramalPowerLabel);
            this.advMetricsGroupBox.Controls.Add(this.intensityFactorLabel);
            this.advMetricsGroupBox.Controls.Add(this.fnThresPowerLabel);
            this.advMetricsGroupBox.Controls.Add(this.labelAvgPower3Label);
            this.advMetricsGroupBox.Controls.Add(this.labelAvgPower2Label);
            this.advMetricsGroupBox.Controls.Add(this.labelAvgPower1Label);
            this.advMetricsGroupBox.Controls.Add(this.label7);
            this.advMetricsGroupBox.Controls.Add(this.label6);
            this.advMetricsGroupBox.Controls.Add(this.label5);
            this.advMetricsGroupBox.Controls.Add(this.label4);
            this.advMetricsGroupBox.Controls.Add(this.label3);
            this.advMetricsGroupBox.Controls.Add(this.label2);
            this.advMetricsGroupBox.Controls.Add(this.label1);
            this.advMetricsGroupBox.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advMetricsGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.advMetricsGroupBox.Location = new System.Drawing.Point(6, 25);
            this.advMetricsGroupBox.Name = "advMetricsGroupBox";
            this.advMetricsGroupBox.Size = new System.Drawing.Size(909, 414);
            this.advMetricsGroupBox.TabIndex = 0;
            this.advMetricsGroupBox.TabStop = false;
            this.advMetricsGroupBox.Text = "Advanced Metrics";
            // 
            // trainSSLabel
            // 
            this.trainSSLabel.AutoSize = true;
            this.trainSSLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainSSLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.trainSSLabel.Location = new System.Drawing.Point(449, 305);
            this.trainSSLabel.Name = "trainSSLabel";
            this.trainSSLabel.Size = new System.Drawing.Size(65, 23);
            this.trainSSLabel.TabIndex = 13;
            this.trainSSLabel.Text = "label14";
            // 
            // noramalPowerLabel
            // 
            this.noramalPowerLabel.AutoSize = true;
            this.noramalPowerLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noramalPowerLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.noramalPowerLabel.Location = new System.Drawing.Point(449, 264);
            this.noramalPowerLabel.Name = "noramalPowerLabel";
            this.noramalPowerLabel.Size = new System.Drawing.Size(64, 23);
            this.noramalPowerLabel.TabIndex = 12;
            this.noramalPowerLabel.Text = "label13";
            // 
            // intensityFactorLabel
            // 
            this.intensityFactorLabel.AutoSize = true;
            this.intensityFactorLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intensityFactorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.intensityFactorLabel.Location = new System.Drawing.Point(449, 220);
            this.intensityFactorLabel.Name = "intensityFactorLabel";
            this.intensityFactorLabel.Size = new System.Drawing.Size(64, 23);
            this.intensityFactorLabel.TabIndex = 11;
            this.intensityFactorLabel.Text = "label12";
            // 
            // fnThresPowerLabel
            // 
            this.fnThresPowerLabel.AutoSize = true;
            this.fnThresPowerLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnThresPowerLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fnThresPowerLabel.Location = new System.Drawing.Point(449, 181);
            this.fnThresPowerLabel.Name = "fnThresPowerLabel";
            this.fnThresPowerLabel.Size = new System.Drawing.Size(62, 23);
            this.fnThresPowerLabel.TabIndex = 10;
            this.fnThresPowerLabel.Text = "label11";
            // 
            // labelAvgPower3Label
            // 
            this.labelAvgPower3Label.AutoSize = true;
            this.labelAvgPower3Label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower3Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelAvgPower3Label.Location = new System.Drawing.Point(449, 140);
            this.labelAvgPower3Label.Name = "labelAvgPower3Label";
            this.labelAvgPower3Label.Size = new System.Drawing.Size(65, 23);
            this.labelAvgPower3Label.TabIndex = 9;
            this.labelAvgPower3Label.Text = "label10";
            // 
            // labelAvgPower2Label
            // 
            this.labelAvgPower2Label.AutoSize = true;
            this.labelAvgPower2Label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower2Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelAvgPower2Label.Location = new System.Drawing.Point(449, 94);
            this.labelAvgPower2Label.Name = "labelAvgPower2Label";
            this.labelAvgPower2Label.Size = new System.Drawing.Size(58, 23);
            this.labelAvgPower2Label.TabIndex = 8;
            this.labelAvgPower2Label.Text = "label9";
            // 
            // labelAvgPower1Label
            // 
            this.labelAvgPower1Label.AutoSize = true;
            this.labelAvgPower1Label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower1Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelAvgPower1Label.Location = new System.Drawing.Point(449, 52);
            this.labelAvgPower1Label.Name = "labelAvgPower1Label";
            this.labelAvgPower1Label.Size = new System.Drawing.Size(58, 23);
            this.labelAvgPower1Label.TabIndex = 7;
            this.labelAvgPower1Label.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Training Stress Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Noramalized Power";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Intensity Factor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Functional Threshold Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average Power 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Power 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Power 1";
            // 
            // interval_detection_tab
            // 
            this.interval_detection_tab.Controls.Add(this.labelHighPower1);
            this.interval_detection_tab.Controls.Add(this.label11);
            this.interval_detection_tab.Controls.Add(this.labelAvgPower1);
            this.interval_detection_tab.Controls.Add(this.label8);
            this.interval_detection_tab.Controls.Add(this.groupBox1);
            this.interval_detection_tab.Location = new System.Drawing.Point(4, 22);
            this.interval_detection_tab.Name = "interval_detection_tab";
            this.interval_detection_tab.Padding = new System.Windows.Forms.Padding(3);
            this.interval_detection_tab.Size = new System.Drawing.Size(921, 456);
            this.interval_detection_tab.TabIndex = 3;
            this.interval_detection_tab.Text = "Interval Detection";
            this.interval_detection_tab.UseVisualStyleBackColor = true;
            // 
            // labelHighPower1
            // 
            this.labelHighPower1.AutoSize = true;
            this.labelHighPower1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighPower1.Location = new System.Drawing.Point(215, 149);
            this.labelHighPower1.Name = "labelHighPower1";
            this.labelHighPower1.Size = new System.Drawing.Size(51, 15);
            this.labelHighPower1.TabIndex = 5;
            this.labelHighPower1.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "High Power";
            // 
            // labelAvgPower1
            // 
            this.labelAvgPower1.AutoSize = true;
            this.labelAvgPower1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower1.Location = new System.Drawing.Point(215, 110);
            this.labelAvgPower1.Name = "labelAvgPower1";
            this.labelAvgPower1.Size = new System.Drawing.Size(52, 15);
            this.labelAvgPower1.TabIndex = 3;
            this.labelAvgPower1.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "SET 1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Peru;
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.labelHighPower4);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.labelAvgPower4);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.labelHighPower2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.labelAvgPower2);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelHighPower3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.labelAvgPower3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 429);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(562, 294);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 15);
            this.label23.TabIndex = 17;
            this.label23.Text = "Average Power";
            // 
            // labelHighPower4
            // 
            this.labelHighPower4.AutoSize = true;
            this.labelHighPower4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighPower4.Location = new System.Drawing.Point(720, 333);
            this.labelHighPower4.Name = "labelHighPower4";
            this.labelHighPower4.Size = new System.Drawing.Size(55, 15);
            this.labelHighPower4.TabIndex = 20;
            this.labelHighPower4.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(562, 333);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 15);
            this.label25.TabIndex = 19;
            this.label25.Text = "High Power";
            // 
            // labelAvgPower4
            // 
            this.labelAvgPower4.AutoSize = true;
            this.labelAvgPower4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower4.Location = new System.Drawing.Point(720, 294);
            this.labelAvgPower4.Name = "labelAvgPower4";
            this.labelAvgPower4.Size = new System.Drawing.Size(54, 15);
            this.labelAvgPower4.TabIndex = 18;
            this.labelAvgPower4.Text = "label26";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(650, 241);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 20);
            this.label27.TabIndex = 16;
            this.label27.Text = "SET 4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(57, 294);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 15);
            this.label18.TabIndex = 12;
            this.label18.Text = "Average Power";
            // 
            // labelHighPower2
            // 
            this.labelHighPower2.AutoSize = true;
            this.labelHighPower2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighPower2.Location = new System.Drawing.Point(213, 333);
            this.labelHighPower2.Name = "labelHighPower2";
            this.labelHighPower2.Size = new System.Drawing.Size(51, 15);
            this.labelHighPower2.TabIndex = 15;
            this.labelHighPower2.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(57, 333);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 15);
            this.label20.TabIndex = 14;
            this.label20.Text = "High Power";
            // 
            // labelAvgPower2
            // 
            this.labelAvgPower2.AutoSize = true;
            this.labelAvgPower2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower2.Location = new System.Drawing.Point(213, 294);
            this.labelAvgPower2.Name = "labelAvgPower2";
            this.labelAvgPower2.Size = new System.Drawing.Size(51, 15);
            this.labelAvgPower2.TabIndex = 13;
            this.labelAvgPower2.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(143, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 11;
            this.label22.Text = "SET 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(562, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Average Power";
            // 
            // labelHighPower3
            // 
            this.labelHighPower3.AutoSize = true;
            this.labelHighPower3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighPower3.Location = new System.Drawing.Point(720, 128);
            this.labelHighPower3.Name = "labelHighPower3";
            this.labelHighPower3.Size = new System.Drawing.Size(52, 15);
            this.labelHighPower3.TabIndex = 10;
            this.labelHighPower3.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "High Power";
            // 
            // labelAvgPower3
            // 
            this.labelAvgPower3.AutoSize = true;
            this.labelAvgPower3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgPower3.Location = new System.Drawing.Point(720, 89);
            this.labelAvgPower3.Name = "labelAvgPower3";
            this.labelAvgPower3.Size = new System.Drawing.Size(51, 15);
            this.labelAvgPower3.TabIndex = 8;
            this.labelAvgPower3.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(650, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "SET 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Average Power";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 541);
            this.Controls.Add(this.form3_tab);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.form3_tab.ResumeLayout(false);
            this.data_grid_view_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.advanced_metrics.ResumeLayout(false);
            this.advMetricsGroupBox.ResumeLayout(false);
            this.advMetricsGroupBox.PerformLayout();
            this.interval_detection_tab.ResumeLayout(false);
            this.interval_detection_tab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl form3_tab;
        private System.Windows.Forms.TabPage graph_tab;
        private System.Windows.Forms.TabPage data_grid_view_tab;
        private System.Windows.Forms.TabPage advanced_metrics;
        private System.Windows.Forms.TabPage interval_detection_tab;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button get_graph_button;
        private System.Windows.Forms.GroupBox advMetricsGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label trainSSLabel;
        private System.Windows.Forms.Label noramalPowerLabel;
        private System.Windows.Forms.Label intensityFactorLabel;
        private System.Windows.Forms.Label fnThresPowerLabel;
        private System.Windows.Forms.Label labelAvgPower3Label;
        private System.Windows.Forms.Label labelAvgPower2Label;
        private System.Windows.Forms.Label labelAvgPower1Label;
        private System.Windows.Forms.Label labelHighPower1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAvgPower1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelHighPower4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelAvgPower4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelHighPower2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelAvgPower2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelHighPower3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelAvgPower3;
        private System.Windows.Forms.Label label17;
    }
}