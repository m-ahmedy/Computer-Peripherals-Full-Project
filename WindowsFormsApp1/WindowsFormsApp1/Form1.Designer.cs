namespace WindowsFormsApp1
{
    partial class ControlGUI
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hidStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.DcMotorDirectionLabel = new System.Windows.Forms.Label();
            this.DcMotorHeader = new System.Windows.Forms.Label();
            this.DcMotorPower = new System.Windows.Forms.ComboBox();
            this.DcMotorPowerLabel = new System.Windows.Forms.Label();
            this.DcMotorDirection = new System.Windows.Forms.ComboBox();
            this.DcMotorSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ServoMotorHeader = new System.Windows.Forms.Label();
            this.ServoAngle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ServoMotorSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.StepperMotorHeader = new System.Windows.Forms.Label();
            this.StepperDirection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StepperAngle = new System.Windows.Forms.NumericUpDown();
            this.StepperSteps = new System.Windows.Forms.TextBox();
            this.StepperMotorSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TemperatureHeaderLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.HumidityHeaderLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PirHeaderLabel = new System.Windows.Forms.Label();
            this.PirLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepperAngle)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(782, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hidStatusLabel
            // 
            this.hidStatusLabel.Font = new System.Drawing.Font("Roboto", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidStatusLabel.Name = "hidStatusLabel";
            this.hidStatusLabel.Size = new System.Drawing.Size(105, 19);
            this.hidStatusLabel.Text = "Disconnected";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TitleLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 375);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 64);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 307);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.DcMotorDirectionLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.DcMotorHeader, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.DcMotorPower, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.DcMotorPowerLabel, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.DcMotorDirection, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.DcMotorSend, 0, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 98);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(221, 203);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // DcMotorDirectionLabel
            // 
            this.DcMotorDirectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DcMotorDirectionLabel.AutoSize = true;
            this.DcMotorDirectionLabel.Location = new System.Drawing.Point(19, 60);
            this.DcMotorDirectionLabel.Name = "DcMotorDirectionLabel";
            this.DcMotorDirectionLabel.Size = new System.Drawing.Size(72, 19);
            this.DcMotorDirectionLabel.TabIndex = 3;
            this.DcMotorDirectionLabel.Text = "Direction";
            // 
            // DcMotorHeader
            // 
            this.DcMotorHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DcMotorHeader.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.DcMotorHeader, 2);
            this.DcMotorHeader.Font = new System.Drawing.Font("Roboto", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DcMotorHeader.Location = new System.Drawing.Point(60, 12);
            this.DcMotorHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DcMotorHeader.Name = "DcMotorHeader";
            this.DcMotorHeader.Size = new System.Drawing.Size(101, 25);
            this.DcMotorHeader.TabIndex = 0;
            this.DcMotorHeader.Text = "DC Motor";
            // 
            // DcMotorPower
            // 
            this.DcMotorPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DcMotorPower.FormattingEnabled = true;
            this.DcMotorPower.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.DcMotorPower.Location = new System.Drawing.Point(113, 103);
            this.DcMotorPower.Name = "DcMotorPower";
            this.DcMotorPower.Size = new System.Drawing.Size(105, 27);
            this.DcMotorPower.TabIndex = 2;
            this.DcMotorPower.Text = "0";
            // 
            // DcMotorPowerLabel
            // 
            this.DcMotorPowerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DcMotorPowerLabel.AutoSize = true;
            this.DcMotorPowerLabel.Location = new System.Drawing.Point(139, 60);
            this.DcMotorPowerLabel.Name = "DcMotorPowerLabel";
            this.DcMotorPowerLabel.Size = new System.Drawing.Size(53, 19);
            this.DcMotorPowerLabel.TabIndex = 3;
            this.DcMotorPowerLabel.Text = "Power";
            // 
            // DcMotorDirection
            // 
            this.DcMotorDirection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DcMotorDirection.FormattingEnabled = true;
            this.DcMotorDirection.Items.AddRange(new object[] {
            "Clockwise",
            "Counter Clockwise"});
            this.DcMotorDirection.Location = new System.Drawing.Point(3, 103);
            this.DcMotorDirection.Name = "DcMotorDirection";
            this.DcMotorDirection.Size = new System.Drawing.Size(104, 27);
            this.DcMotorDirection.TabIndex = 2;
            this.DcMotorDirection.Text = "Clockwise";
            // 
            // DcMotorSend
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.DcMotorSend, 2);
            this.DcMotorSend.Location = new System.Drawing.Point(3, 143);
            this.DcMotorSend.Name = "DcMotorSend";
            this.DcMotorSend.Size = new System.Drawing.Size(215, 57);
            this.DcMotorSend.TabIndex = 4;
            this.DcMotorSend.Text = "Send";
            this.DcMotorSend.UseVisualStyleBackColor = true;
            this.DcMotorSend.Click += new System.EventHandler(this.DcMotorSend_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.ServoMotorHeader, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.ServoAngle, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.ServoMotorSend, 0, 3);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(545, 98);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(223, 203);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // ServoMotorHeader
            // 
            this.ServoMotorHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoMotorHeader.AutoSize = true;
            this.ServoMotorHeader.Font = new System.Drawing.Font("Roboto", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServoMotorHeader.Location = new System.Drawing.Point(49, 12);
            this.ServoMotorHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServoMotorHeader.Name = "ServoMotorHeader";
            this.ServoMotorHeader.Size = new System.Drawing.Size(125, 25);
            this.ServoMotorHeader.TabIndex = 0;
            this.ServoMotorHeader.Text = "Servo Motor";
            // 
            // ServoAngle
            // 
            this.ServoAngle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServoAngle.FormattingEnabled = true;
            this.ServoAngle.Items.AddRange(new object[] {
            "0",
            "45",
            "90",
            "135",
            "180"});
            this.ServoAngle.Location = new System.Drawing.Point(61, 103);
            this.ServoAngle.Name = "ServoAngle";
            this.ServoAngle.Size = new System.Drawing.Size(101, 27);
            this.ServoAngle.TabIndex = 2;
            this.ServoAngle.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Angle";
            // 
            // ServoMotorSend
            // 
            this.ServoMotorSend.Location = new System.Drawing.Point(3, 143);
            this.ServoMotorSend.Name = "ServoMotorSend";
            this.ServoMotorSend.Size = new System.Drawing.Size(217, 57);
            this.ServoMotorSend.TabIndex = 4;
            this.ServoMotorSend.Text = "Send";
            this.ServoMotorSend.UseVisualStyleBackColor = true;
            this.ServoMotorSend.Click += new System.EventHandler(this.ServoMotorSend_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel6.Controls.Add(this.StepperMotorHeader, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.StepperDirection, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.StepperAngle, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.StepperSteps, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.StepperMotorSend, 0, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(237, 98);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(298, 203);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // StepperMotorHeader
            // 
            this.StepperMotorHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StepperMotorHeader.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.StepperMotorHeader, 3);
            this.StepperMotorHeader.Font = new System.Drawing.Font("Roboto", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepperMotorHeader.Location = new System.Drawing.Point(76, 12);
            this.StepperMotorHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StepperMotorHeader.Name = "StepperMotorHeader";
            this.StepperMotorHeader.Size = new System.Drawing.Size(145, 25);
            this.StepperMotorHeader.TabIndex = 0;
            this.StepperMotorHeader.Text = "Stepper Motor";
            // 
            // StepperDirection
            // 
            this.StepperDirection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StepperDirection.FormattingEnabled = true;
            this.StepperDirection.Items.AddRange(new object[] {
            "Clockwise",
            "Counter Clockwise"});
            this.StepperDirection.Location = new System.Drawing.Point(3, 103);
            this.StepperDirection.Name = "StepperDirection";
            this.StepperDirection.Size = new System.Drawing.Size(92, 27);
            this.StepperDirection.TabIndex = 2;
            this.StepperDirection.Text = "Clockwise";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direction";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Steps";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Angle/Step";
            // 
            // StepperAngle
            // 
            this.StepperAngle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StepperAngle.Location = new System.Drawing.Point(202, 101);
            this.StepperAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.StepperAngle.Name = "StepperAngle";
            this.StepperAngle.Size = new System.Drawing.Size(93, 27);
            this.StepperAngle.TabIndex = 4;
            // 
            // StepperSteps
            // 
            this.StepperSteps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StepperSteps.Location = new System.Drawing.Point(101, 101);
            this.StepperSteps.MaxLength = 3;
            this.StepperSteps.Name = "StepperSteps";
            this.StepperSteps.Size = new System.Drawing.Size(95, 27);
            this.StepperSteps.TabIndex = 5;
            this.StepperSteps.TextChanged += new System.EventHandler(this.StepperSteps_TextChanged);
            // 
            // StepperMotorSend
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.StepperMotorSend, 3);
            this.StepperMotorSend.Location = new System.Drawing.Point(3, 143);
            this.StepperMotorSend.Name = "StepperMotorSend";
            this.StepperMotorSend.Size = new System.Drawing.Size(292, 57);
            this.StepperMotorSend.TabIndex = 4;
            this.StepperMotorSend.Text = "Send";
            this.StepperMotorSend.UseVisualStyleBackColor = true;
            this.StepperMotorSend.Click += new System.EventHandler(this.StepperMotorSend_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.TemperatureHeaderLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.TemperatureLabel, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(221, 82);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // TemperatureHeaderLabel
            // 
            this.TemperatureHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TemperatureHeaderLabel.AutoSize = true;
            this.TemperatureHeaderLabel.Font = new System.Drawing.Font("Roboto", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureHeaderLabel.Location = new System.Drawing.Point(45, 0);
            this.TemperatureHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureHeaderLabel.Name = "TemperatureHeaderLabel";
            this.TemperatureHeaderLabel.Size = new System.Drawing.Size(131, 24);
            this.TemperatureHeaderLabel.TabIndex = 0;
            this.TemperatureHeaderLabel.Text = "Temperature";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Roboto Light", 24.192F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(50, 27);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(121, 51);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "None";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.HumidityHeaderLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.HumidityLabel, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(260, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 82);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // HumidityHeaderLabel
            // 
            this.HumidityHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HumidityHeaderLabel.AutoSize = true;
            this.HumidityHeaderLabel.Font = new System.Drawing.Font("Roboto", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityHeaderLabel.Location = new System.Drawing.Point(78, 0);
            this.HumidityHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumidityHeaderLabel.Name = "HumidityHeaderLabel";
            this.HumidityHeaderLabel.Size = new System.Drawing.Size(96, 24);
            this.HumidityHeaderLabel.TabIndex = 0;
            this.HumidityHeaderLabel.Text = "Humidity";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Font = new System.Drawing.Font("Roboto Light", 24.192F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityLabel.Location = new System.Drawing.Point(65, 27);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(121, 51);
            this.HumidityLabel.TabIndex = 1;
            this.HumidityLabel.Text = "None";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.PirHeaderLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PirLabel, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(545, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(223, 82);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // PirHeaderLabel
            // 
            this.PirHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PirHeaderLabel.AutoSize = true;
            this.PirHeaderLabel.Font = new System.Drawing.Font("Roboto", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PirHeaderLabel.Location = new System.Drawing.Point(89, 0);
            this.PirHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PirHeaderLabel.Name = "PirHeaderLabel";
            this.PirHeaderLabel.Size = new System.Drawing.Size(44, 24);
            this.PirHeaderLabel.TabIndex = 0;
            this.PirHeaderLabel.Text = "PIR";
            // 
            // PirLabel
            // 
            this.PirLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PirLabel.AutoSize = true;
            this.PirLabel.Font = new System.Drawing.Font("Roboto Light", 24.192F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PirLabel.Location = new System.Drawing.Point(51, 27);
            this.PirLabel.Name = "PirLabel";
            this.PirLabel.Size = new System.Drawing.Size(121, 51);
            this.PirLabel.TabIndex = 1;
            this.PirLabel.Text = "None";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.Font = new System.Drawing.Font("Roboto", 20.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(289, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(204, 42);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Control App";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 5000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // ControlGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Roboto", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ControlGUI";
            this.Text = "Control GUI";
            this.Load += new System.EventHandler(this.ControlGUI_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepperAngle)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hidStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label ServoMotorHeader;
        private System.Windows.Forms.ComboBox ServoAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label StepperMotorHeader;
        private System.Windows.Forms.ComboBox StepperDirection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label TemperatureHeaderLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label HumidityHeaderLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label PirHeaderLabel;
        private System.Windows.Forms.Label PirLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StepperAngle;
        private System.Windows.Forms.TextBox StepperSteps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label DcMotorDirectionLabel;
        private System.Windows.Forms.Label DcMotorHeader;
        private System.Windows.Forms.ComboBox DcMotorPower;
        private System.Windows.Forms.Label DcMotorPowerLabel;
        private System.Windows.Forms.ComboBox DcMotorDirection;
        private System.Windows.Forms.Button DcMotorSend;
        private System.Windows.Forms.Button ServoMotorSend;
        private System.Windows.Forms.Button StepperMotorSend;
    }
}

